﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model.Repositories
{
    public interface ICourseRepository
    {
        public int GetCourseHours(CourseGrade courseGrade);
    }
}
