using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TaskHandlerPro
{
    public class Student
    {
       
        int id;
        string fullName;
        int section;
        public Student()
        {

        }
        public Student(string fullName, int id, int section)
        {
            this.fullName = fullName;
            this.section = section;
            this.id = id;
        }
        public static List<Student> loadStudents()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var output = cnn.Query<Student>("select * from student", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<int> loadSections()
        {
            using (var cnn = new SQLiteConnection(loadConnectionString()))
            {
                List<int> lst = new List<int>();
                cnn.Open();
                var cmd = new SQLiteCommand($"SELECT DISTINCT section FROM Student ", cnn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                    lst.Add(rdr.GetInt32(0));
                cnn.Close();
                return lst;
            }
        }
        public static string getName(int id)
        {
            using (var cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                var cmd = new SQLiteCommand($"select fulName from student where id={id}", cnn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                string name= rdr.GetString(0);
                cnn.Close();
                return name;

            }
        }
        private static string loadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public string FullName { get { return fullName; } }
        public int Section { get { return section; } }
        public int Id { get { return id; } }
    }
}
