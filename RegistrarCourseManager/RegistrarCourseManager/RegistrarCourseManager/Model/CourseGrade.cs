
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
    }
}
