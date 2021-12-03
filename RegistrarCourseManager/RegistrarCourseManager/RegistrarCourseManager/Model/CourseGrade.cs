
namespace RegistrarCourseManager.Model
{
    public class CourseGrade
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

        public override bool Equals(object obj)
        {
            var dst = obj as CourseGrade;

            return StudentID.Equals(dst.StudentID) &&
                CoursePrefix.Equals(dst.CoursePrefix) &&
                CourseNum == CourseNum &&
                Grade.Equals(dst.Grade) &&
                Year == dst.Year &&
                Semester.Equals(dst.Semester);
            
        }
    }
}
