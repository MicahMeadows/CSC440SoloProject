using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model.Repositories.sql
{

    class SqlCourseRepository : ICourseRepository
    {
        string connectionString = "";

        public int GetCourseHours(CourseGrade courseGrade)
        {

            string query = "SELECT * FROM course WHERE CoursePrefix = @pre AND CourseNum = @cn AND Year = @yer AND Semester = @sem";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@pre", courseGrade.CoursePrefix);
            command.Parameters.AddWithValue("@cn", courseGrade.CourseNum);
            command.Parameters.AddWithValue("@yer", courseGrade.Year);
            command.Parameters.AddWithValue("@sem", courseGrade.Semester);

            connection.Open();

            List<Course> cList = new List<Course>();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string pre = reader.GetString("CoursePrefix");
                int cNum = reader.GetInt16("CourseNum");
                int year = reader.GetInt16("Year");
                string sem = reader.GetString("Semester");
                int cH = reader.GetInt16("Hours");

                cList.Add(new Course(pre, cNum, year, sem, cH));
            }

            return cList.First().Hours;
        }

        public SqlCourseRepository(string connStr)
        {
            this.connectionString = connStr;
        }
    }
}
