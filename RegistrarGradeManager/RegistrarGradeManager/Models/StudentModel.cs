using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarGradeManager.Models
{
    class StudentModel
    {
        private string _studentID;
        private string _studentName;
        private double _overallGPA;
        public StudentModel(string studentID, string studentName, double overallGPA)
        {
            _studentID = studentID;
            _studentName = studentName;
            _overallGPA = overallGPA;
        }
    }
}
