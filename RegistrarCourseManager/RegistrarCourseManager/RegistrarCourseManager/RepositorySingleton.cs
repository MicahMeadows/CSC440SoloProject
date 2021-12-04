using RegistrarCourseManager.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager
{
    public class RepositorySingleton
    {
        public IStudentRepository studentRepository;
        public IGradesRepository gradesRepository;
        public ICourseRepository courseRepository;

        private static RepositorySingleton instance;
        public static RepositorySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RepositorySingleton();
                }
                return instance;
            }
        }
        private RepositorySingleton()
        {
            studentRepository = new TestingStudentRepository();
            gradesRepository = new TestingGradesRepository();
            courseRepository = new TestingCourseRepository();
        }
    }
}
