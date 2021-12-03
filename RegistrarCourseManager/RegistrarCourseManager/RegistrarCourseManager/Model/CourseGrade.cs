
using System;

namespace RegistrarCourseManager.Model
{
    public class CourseGrade : IComparable
    {
        public CourseGrade(string studentID, string coursePrefix, int courseNum, string grade, int year, string semester)
        {
            StudentID = studentID;
            CoursePrefix = coursePrefix;
            CourseNum = courseNum;
            Grade = grade;
            Year = year;
            Semester = semester;
        }

        public string StudentID { get; set; }
        public string CoursePrefix { get; set; }
        public int CourseNum { get; set; }
        public string Grade { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }

        public int CompareTo(object obj)
        {
            var dst = obj as CourseGrade;

            bool id = StudentID.Equals(dst.StudentID);
            bool prefix = CoursePrefix.Equals(dst.CoursePrefix);
            bool cNum = CourseNum.Equals(dst.CourseNum);
            bool year = Year.Equals(dst.Year);
            bool semester = Semester.Equals(dst.Semester);
            bool grade = Grade.Equals(dst.Grade);

            return id && prefix && cNum && year && semester && grade ? 0 : -1;
        }

        //public override bool Equals(object obj)
        //{
        //    var dst = obj as CourseGrade;

        //    return 
        //        StudentID.Equals(dst.StudentID) &&
        //        CoursePrefix.Equals(dst.CoursePrefix) &&
        //        CourseNum.Equals(CourseNum) &&
        //        Year.Equals(dst.Year) &&
        //        Semester.Equals(dst.Semester);
        //}


        public CourseGrade Copy()
        {
            return new CourseGrade(this.StudentID, this.CoursePrefix, this.CourseNum, this.Grade, this.Year, this.Semester);
        }
    }
}
