namespace RegistrarGradeManager.Models
{
    public class CourseModel
    {
        private string _studentID;
        private string _coursePrefix;
        private int _courseNum;
        private string _grade;
        private int _year;
        private string _semester;

        public CourseModel(string studentID, string coursePrefix, int courseNum, string grade, int year, string semester)
        {
            _studentID = studentID;
            _coursePrefix = coursePrefix;
            _courseNum = courseNum;
            _grade = grade;
            _year = year;
            _semester = semester;
        }
    }
}
