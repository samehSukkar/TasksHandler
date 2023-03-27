using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;

namespace TaskHandlerPro
{
    public class Task
    {
        int num;
        string title;
        int section;
        string location;
        public Task()
        {

        }
        public Task(int num,string title,string location,int section)
        {
            this.num = num;
            this.title = title;
            this.location = location;
            this.section = section;
        }
        
        public static List<Task> loadTasks()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var output = cnn.Query<Task>("select * from task", new DynamicParameters());
                return output.ToList();
            }
        }
        public static Task GetTask(int num,int section)
        {
            using (var cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                var cmd = new SQLiteCommand($"select title,location from task where num={num} and section={section}", cnn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                Task task = new Task(num, rdr.GetString(0), rdr.GetString(1), section);
                cnn.Close();
                return task;
            }
        }
        public static List<int> LoadTaskNums()
        {
            using (var cnn = new SQLiteConnection(loadConnectionString()))
            {
                List<int> lst = new List<int>();
                cnn.Open();
                var cmd = new SQLiteCommand($"SELECT DISTINCT num FROM task ", cnn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                    lst.Add(rdr.GetInt32(0));
                cnn.Close();
                return lst;
            }
        }
        private static string loadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
        public int Num
        {
            set { num = value; }
            get { return num; }
        }
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public string Location
        {
            set { location = value; }
            get { return location; }
        }
        public int Section
        {
            set { section = value; }
            get { return section; }
        }
    }
}
