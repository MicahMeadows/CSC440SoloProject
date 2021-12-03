namespace RegistrarCourseManager.Model
{
    public class Course
    {
        public string CoursePrefix { get; set; }
        public int CourseNum { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }
        public int Hours { get; set; }

        public Course(string CoursePrefix, int CourseNum, int Year, string Semester, int Hours)
        {
            this.CoursePrefix = CoursePrefix;
            this.CourseNum = CourseNum;
            this.Year = Year;
            this.Semester = Semester;
            this.Hours = Hours;
        }

    }
}