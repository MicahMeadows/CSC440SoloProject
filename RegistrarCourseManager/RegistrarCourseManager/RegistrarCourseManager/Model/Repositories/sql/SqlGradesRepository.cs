using MySql.Data.MySqlClient;
using RegistrarCourseManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrarCourseManager.Model.Repositories.sql
{
    class SqlGradesRepository : IGradesRepository
    {
        string connectionString = "";

        public SqlGradesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddCourseGrade(CourseGrade grade)
        {
            if (CourseGradeExists(grade))
                throw new AddGradeException("Grade exists already");

            try
            {
                string query = "INSERT INTO grades (StudentID, CoursePrefix, CourseNum, Grade, Year, Semester) VALUES (@id, @cp, @cn, @gra, @year, @sem)";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", grade.StudentID);
                command.Parameters.AddWithValue("@cp", grade.CoursePrefix);
                command.Parameters.AddWithValue("@cn", grade.CourseNum);
                command.Parameters.AddWithValue("@gra", grade.Grade);
                command.Parameters.AddWithValue("@year", grade.Year);
                command.Parameters.AddWithValue("@sem", grade.Semester);

                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool CourseGradeExists(CourseGrade grade)
        {
            return GetCourseGrades(grade.StudentID).Any(cGrade => cGrade.CompareTo(grade) == 0);
        }

        public void DeleteCourseGrade(CourseGrade grade)
        {

            try
            {
                string query = "DELETE FROM grades WHERE StudentID = @id AND CoursePrefix = @cp AND CourseNum = @cn AND Grade = @gra AND Year = @year AND Semester = @sem";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", grade.StudentID);
                command.Parameters.AddWithValue("@cp", grade.CoursePrefix);
                command.Parameters.AddWithValue("@cn", grade.CourseNum);
                command.Parameters.AddWithValue("@gra", grade.Grade);
                command.Parameters.AddWithValue("@year", grade.Year);
                command.Parameters.AddWithValue("@sem", grade.Semester);

                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void EditCourseGrade(CourseGrade grade)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<CourseGrade> GetCourseGrades(string studentId)
        {
            List<CourseGrade> courseGrades = new List<CourseGrade>();

            try
            {
                string query = "SELECT * FROM grades WHERE StudentID = @id";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", studentId);

                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("StudentID");
                    string prefix = reader.GetString("CoursePrefix");
                    int cNum = reader.GetInt16("CourseNum");
                    string grade = reader.GetString("Grade");
                    int year = reader.GetInt16("Year");
                    string semester = reader.GetString("Semester");

                    courseGrades.Add(new CourseGrade(id, prefix, cNum, grade, year, semester));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return new ObservableCollection<CourseGrade>(courseGrades);
        }
    }
}
