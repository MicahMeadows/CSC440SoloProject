using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrarCourseManager.Exceptions;

namespace RegistrarCourseManager.Model.Repositories
{
    public class TestingCourseRepository : ICourseRepository
    {
        List<Course> allCourses = new List<Course>();

        public TestingCourseRepository()
        {
            allCourses.Add(new Course("CSC", 191, 2021, "Spring", 3));
            allCourses.Add(new Course("EET", 252, 2021, "Fall", 3));
            allCourses.Add(new Course("MAT", 234, 2021, "Fall", 3));
            allCourses.Add(new Course("MUS", 290, 2019, "Fall", 3));
            
        }

        public int GetCourseHours(CourseGrade courseGrade)
        {
            var course = allCourses.First(course =>
            course.CoursePrefix == courseGrade.CoursePrefix
            && course.CourseNum == courseGrade.CourseNum
            && course.Year == courseGrade.Year
            && course.Semester == courseGrade.Semester);

            if(course == null)
                throw new CourseNotExistException("Course doesnt exist");

            return course.Hours;
        }
    }
}
