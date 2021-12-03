namespace RegistrarCourseManager.Model
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public double OverallGPA { get; set; }
       

        public Student(string StudentID, string Name, double OverallGPA)
        {
            this.StudentID = StudentID;
            this.Name = Name;
            this.OverallGPA = OverallGPA;
        }
    }
}
