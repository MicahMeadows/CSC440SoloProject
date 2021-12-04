using RegistrarCourseManager.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrarCourseManager.Model.ReportGeneration
{
    class MessageBoxReportGenerator : IReportGenerator
    {


        public void GenerateReport(Student student, ICourseRepository courseRepository, IGradesRepository gradesRepository)
        {
            string name = student.Name;
            string id = student.StudentID;
            string gpa = student.OverallGPA.ToString();


            ObservableCollection<CourseGrade> studentsGrades = gradesRepository.GetCourseGrades(student.StudentID);

            var grades = "";
            foreach(var grade in studentsGrades)
            {
                grades += grade.CoursePrefix + "\n";
                grades += grade.CourseNum + "\n";
                grades += grade.Year + "\n";
                grades += grade.Semester + "\n";
                grades += grade.Grade + "\n";
                grades += courseRepository.GetCourseHours(grade) + "\n\n";
            }

            string transcript = name + id + gpa + "\n" + grades;


            MessageBox.Show(transcript);
        }
    }
}
