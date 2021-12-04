using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace RegistrarCourseManager.Model.Repositories.sql
{
    class SqlStudentRepository : IStudentRepository
    {
        string connectionString = "";

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Student> GetStudents()
        {
            List<Student> studentList = new List<Student>();

            try
            {
                string query = "SELECT * FROM student";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("StudentID");
                    string name = reader.GetString("Name");
                    double gpa = reader.GetDouble("OverallGPA");

                    studentList.Add(new Student(id, name, gpa));
                }

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return new ObservableCollection<Student>(studentList);
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public SqlStudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
