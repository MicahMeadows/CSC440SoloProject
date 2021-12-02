using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrarCourseManager.Model;

namespace RegistrarCourseManager.ViewModel.Tabs
{
    class StudentSearchViewModel : ViewModelBase
    {
        private Student selectedStudent;
        public Student SelectedStudent
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;
                OnPropertyChanged("SelectedStudent");
            }
        }

        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        public ObservableCollection<Student> Students
        {
            get => students;
            set
            {
                students = Students;
                OnPropertyChanged("Students");
            }
        }

        public StudentSearchViewModel()
        {
            Students.Add(new Student(Name: "Micah", StudentID: "901901901", OverallGPA: 2.5));
            Students.Add(new Student(Name: "Micah2", StudentID: "901901902", OverallGPA: 2.6));
            Students.Add(new Student(Name: "Micah3", StudentID: "901901903", OverallGPA: 2.7));
        }
    }
}
