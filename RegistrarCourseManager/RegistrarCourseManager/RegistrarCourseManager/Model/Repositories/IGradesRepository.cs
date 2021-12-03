using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model.Repositories
{
    public interface IGradesRepository
    {
        public ObservableCollection<CourseGrade> GetCourseGrades(Student student);
        public void DeleteCourseGrade(CourseGrade grade);
        public void AddCourseGrade(CourseGrade grade);
        public void EditCourseGrade(CourseGrade grade);
        public bool CourseGradeExists(CourseGrade grade);
    }
}
