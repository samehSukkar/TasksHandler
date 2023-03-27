using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Dapper;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace TaskHandlerPro
{
    public class Solution
    {
        string name;
        int taskNo;
        int studentId;
        string location;
        bool marked;
        double mark;

        public Solution()
        {
          
        }
        public Solution(DirectoryInfo dir)
        {
            Name = dir.Name;
            location = dir.FullName;
            marked = false;
            mark = 0;
        }  
        public Solution(string name, int taskNo, int studentId, string location, double mark)
        {
            this.name = name;
            this.taskNo = taskNo;
            this.studentId = studentId;
            this.location = location;
            this.mark = mark;
             marked = false;
        }
        public static List<Solution> loadSolutions()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var output = cnn.Query<Solution>("SELECT * FROM Solution ", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Solution> GetByStudentId(int id )
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var output = cnn.Query<Solution>($"SELECT * FROM Solution where studentId = {id}", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Solution> GetByTaskNo(int taskNo )
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var output = cnn.Query<Solution>($"SELECT * FROM Solution where taskNo = {taskNo}", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void Insert(Solution solution)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute($"INSERT INTO SOLUTION (name,taskNo,studentId,location,mark) VALUES ('{solution.Name}',{solution.TaskNo},{solution.StudentId},'{solution.Location}',{solution.Mark})");
            }
        }
        private static string loadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
        public void RunExe()
        {
            DirectoryInfo dir = new DirectoryInfo(location);
            FileInfo[] files = dir.GetFiles("*.exe", SearchOption.AllDirectories);

            foreach (FileInfo f in files)
            {
                if (f.Exists && f.FullName.Contains("bin"))
                {
                    Process.Start(f.FullName);
                }
            }
        }

        public void OpenSLN()
        {
            DirectoryInfo dir = new DirectoryInfo(location);
            FileInfo[] files = dir.GetFiles("*.sln", SearchOption.AllDirectories);
            if (files.Length > 0 && files[0].Exists)
                Process.Start(files[0].FullName);
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int TaskNo
        {
            set { taskNo = value; }
            get { return taskNo; }
        }
        public int StudentId
        {
            set { studentId = value; }
            get { return studentId; }
        }
        public string Location
        {
            set { location = value; }
            get { return location; }
        }
        public double Mark
        {
            set { mark = value; }
            get { return mark; }
        }
        public bool Marked
        {
            get
            {
                return marked;
            }
            set
            {
                marked = value;
            }
        }
    }
}
