using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RegistrarCourseManager.Model.Repositories
{
    public class TestingStudentRepository : IStudentRepository
    {
        private List<Student> students = new List<Student>();

        public TestingStudentRepository()
        {
            students.Add(new Student(Name: "Micah", StudentID: "901901901", OverallGPA: 2.36));
            students.Add(new Student(Name: "John", StudentID: "901901902", OverallGPA: 1.36));
            students.Add(new Student(Name: "Toby", StudentID: "901901903", OverallGPA: 3.5));
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public ObservableCollection<Student> GetStudents()
        {
            return new ObservableCollection<Student>(students);
        }

        public void UpdateStudent(Student student)
        {
            var idx = students.FindIndex(stu => stu.StudentID == student.StudentID);
            students.RemoveAt(idx);
            students.Insert(idx, student);
        }
    }
}
