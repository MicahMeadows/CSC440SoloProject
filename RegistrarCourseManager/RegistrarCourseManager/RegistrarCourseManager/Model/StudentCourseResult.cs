using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model
{
    public class StudentCourseResult
    {
        public StudentCourseResult(string courseName, string semester, int hours, string grade)
        {
            CourseName = courseName;
            Semester = semester;
            Hours = hours;
            Grade = grade;
        }

        public string CourseName { get; set; }
        public string Semester { get; set; }
        public int Hours { get; set; }
        public string Grade { get; set; }
    }
}
