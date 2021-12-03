﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model.Repositories
{
    public class TestingCourseRepository : ICourseRepository
    {
        List<Course> allCourses = new List<Course>();

        public TestingCourseRepository()
        {
            allCourses.Add(new Course("CSC", 191, 2021, "Spring", 3));
            allCourses.Add(new Course("MAT", 234, 2021, "Spring", 4));
            allCourses.Add(new Course("MUS", 290, 2019, "Fall", 2));
        }

        public Course GetCourse(CourseGrade courseGrade)
        {
            
        }
    }
}
