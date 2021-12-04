using RegistrarCourseManager.Model.Repositories;
using RegistrarCourseManager.Model.Repositories.sql;
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
        public IAccountRepository accountRepository;

        public string connectionString = "server=127.0.0.1;database=csc440solo;uid=root;";

        public string authUsername;

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
            // studentRepository = new TestingStudentRepository();
            studentRepository = new SqlStudentRepository(connectionString);

            // gradesRepository = new TestingGradesRepository();
            gradesRepository = new SqlGradesRepository(connectionString);

            // courseRepository = new TestingCourseRepository();
            courseRepository = new SqlCourseRepository(connectionString);

            accountRepository = new SqlAccountRepository(connectionString);
        }
    }
}
