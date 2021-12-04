using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RegistrarCourseManager.Exceptions;

namespace RegistrarCourseManager.Model.Repositories
{
    public class TestingGradesRepository : IGradesRepository
    {
        private List<CourseGrade> allGrades = new List<CourseGrade>();

        public TestingGradesRepository()
        {
            //AddCourseGrade(new CourseGrade("901901901", "CSC", 191, "A", 2020, "Spring"));
            //AddCourseGrade(new CourseGrade("901901901", "CSC", 360, "B", 2021, "Fall"));
            //AddCourseGrade(new CourseGrade("901901901", "MAT", 237, "C", 2021, "Spring"));
            //AddCourseGrade(new CourseGrade("901901901", "CSC", 190, "D", 2019, "Fall"));

            //AddCourseGrade(new CourseGrade("901901902", "CSC", 191, "B", 2020, "Spring"));
            //AddCourseGrade(new CourseGrade("901901902", "CSC", 360, "C", 2021, "Fall"));
            //AddCourseGrade(new CourseGrade("901901902", "MAT", 237, "D", 2021, "Spring"));
            //AddCourseGrade(new CourseGrade("901901902", "CSC", 190, "F", 2019, "Fall"));

            //AddCourseGrade(new CourseGrade("901901903", "CSC", 191, "B", 2020, "Spring"));
            //AddCourseGrade(new CourseGrade("901901903", "CSC", 360, "A", 2021, "Fall"));
            //AddCourseGrade(new CourseGrade("901901903", "MAT", 237, "B", 2021, "Spring"));
            //AddCourseGrade(new CourseGrade("901901903", "CSC", 190, "A", 2019, "Fall"));

            //AddCourseGrade(new CourseGrade("901901904", "CSC", 191, "C", 2020, "Spring"));
            //AddCourseGrade(new CourseGrade("901901904", "CSC", 360, "A", 2021, "Fall"));
            //AddCourseGrade(new CourseGrade("901901904", "MAT", 237, "B", 2021, "Spring"));
            //AddCourseGrade(new CourseGrade("901901904", "CSC", 190, "D", 2019, "Fall"));
        }

        public void AddCourseGrade(CourseGrade grade)
        {
            if (CourseGradeExists(grade))
            {
                throw new AddGradeException("grade already exists");
            }
            allGrades.Add(grade);
        }

        public bool CourseGradeExists(CourseGrade grade)
        {
            return allGrades.Any(cGrade => cGrade.CompareTo(grade) == 0);
        }

        public void DeleteCourseGrade(CourseGrade grade)
        {
            try
            {
                var result = allGrades.Remove(grade);

                if (result == false)
                    throw new DeleteCourseException("couldnt find course to delete");
            }
            catch (Exception e)
            {
                MessageBox.Show("couldnt find course grade");
            }

        }

        public void EditCourseGrade(CourseGrade grade)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<CourseGrade> GetCourseGrades(string studentId)
        {
            if(studentId == null || studentId == "")
            {
                throw new ArgumentException("null student passed");
            }

            List<CourseGrade> studentsGrades = allGrades.Where(grade => grade.StudentID == studentId).ToList();

            return new ObservableCollection<CourseGrade>(studentsGrades);
        }
    }
}
