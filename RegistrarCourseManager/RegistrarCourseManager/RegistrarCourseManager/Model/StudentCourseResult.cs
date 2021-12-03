using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model
{
    public class StudentCourseResult
    {
        public StudentCourseResult(CourseGrade courseGrade, int hours)
        {
            this.CourseGrade = courseGrade;
            Hours = hours;
        }

        public CourseGrade CourseGrade { get; set; }

        public string CourseName => CourseGrade.CoursePrefix + CourseGrade.CourseNum.ToString();

        public string Semester => CourseGrade.Semester + " " + CourseGrade.Year.ToString();

        public int Hours { get; set; }

        public string Grade => CourseGrade.Grade;
    }
}
