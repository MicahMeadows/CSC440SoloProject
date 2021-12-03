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
            AddCourseGrade(new CourseGrade("901901901", "CSC", 191, "A", 2020, "Spring"));
            AddCourseGrade(new CourseGrade("901901901", "CSC", 360, "A", 2021, "Fall"));
            AddCourseGrade(new CourseGrade("901901901", "MAT", 237, "A", 2021, "Spring"));
            AddCourseGrade(new CourseGrade("901901901", "CSC", 190, "A", 2019, "Fall"));

            AddCourseGrade(new CourseGrade("901901902", "CSC", 191, "B", 2020, "Spring"));
            AddCourseGrade(new CourseGrade("901901902", "CSC", 360, "B", 2021, "Fall"));
            AddCourseGrade(new CourseGrade("901901902", "MAT", 237, "B", 2021, "Spring"));
            AddCourseGrade(new CourseGrade("901901902", "CSC", 190, "B", 2019, "Fall"));

            AddCourseGrade(new CourseGrade("901901903", "CSC", 191, "C", 2020, "Spring"));
            AddCourseGrade(new CourseGrade("901901903", "CSC", 360, "C", 2021, "Fall"));
            AddCourseGrade(new CourseGrade("901901903", "MAT", 237, "C", 2021, "Spring"));
            AddCourseGrade(new CourseGrade("901901903", "CSC", 190, "C", 2019, "Fall"));

            AddCourseGrade(new CourseGrade("901901904", "CSC", 191, "D", 2020, "Spring"));
            AddCourseGrade(new CourseGrade("901901904", "CSC", 360, "D", 2021, "Fall"));
            AddCourseGrade(new CourseGrade("901901904", "MAT", 237, "D", 2021, "Spring"));
            AddCourseGrade(new CourseGrade("901901904", "CSC", 190, "D", 2019, "Fall"));
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
            return allGrades.Contains(grade);
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

        public ObservableCollection<CourseGrade> GetCourseGrades(Student student)
        {
            if(student == null)
            {
                throw new ArgumentException("null student passed");
            }

            List<CourseGrade> studentsGrades = allGrades.Where(grade => grade.StudentID == student.StudentID).ToList();

            return new ObservableCollection<CourseGrade>(studentsGrades);
        }
    }
}
