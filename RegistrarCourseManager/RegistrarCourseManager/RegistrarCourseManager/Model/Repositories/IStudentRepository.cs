using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model.Repositories
{
    public interface IStudentRepository
    {
        public ObservableCollection<Student> GetStudents();
        public void AddStudent(Student student);
    }
}
