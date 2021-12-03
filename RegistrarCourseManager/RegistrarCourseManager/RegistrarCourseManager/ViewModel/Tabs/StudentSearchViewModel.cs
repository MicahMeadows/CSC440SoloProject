using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.Model;
using RegistrarCourseManager.Model.Repositories;

namespace RegistrarCourseManager.ViewModel.Tabs
{
    class StudentSearchViewModel : ViewModelBase
    {
        public IStudentRepository studentRepository;

        public ICommand AddStudentCommand { get; set; }
        public ICommand EditStudentCommand { get; set; }
        public ICommand EditRecordCommand { get; set; }
        public ICommand DeleteRecordCommand { get; set; }
        public ICommand FilterChangedCommand { get; set; }
        public ICommand GenerateReportCommand { get; set; }

        private string idFilter = "";
        public string IdFilter
        {
            get => idFilter;
            set
            {
                idFilter = value;
                OnPropertyChanged("IdFilter");
            }
        }

        private string nameFilter = "";
        public string NameFilter
        {
            get => nameFilter;
            set
            {
                nameFilter = value;
                OnPropertyChanged("NameFilter");
            }
        }

        private StudentCourseResult selectedCourseResult;
        public StudentCourseResult SelectedCourseResult
        {
            get => selectedCourseResult;
            set
            {
                selectedCourseResult = value;
                OnPropertyChanged("SelectedCourseResult");
            }
        }

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

        private ObservableCollection<StudentCourseResult> selectedStudentCourseResults = new ObservableCollection<StudentCourseResult>();
        public ObservableCollection<StudentCourseResult> SelectedStudentCourseResults
        {
            get => selectedStudentCourseResults;
            set
            {
                selectedStudentCourseResults = value;
                OnPropertyChanged("SelectedStudentCourseResults");
            }
        }

        private ObservableCollection<Student> students = new ObservableCollection<Student>();

        private ObservableCollection<Student> filteredStudents;
        public ObservableCollection<Student> FilteredStudents
        {
            get => filteredStudents;
            set
            {
                filteredStudents = value;
                OnPropertyChanged("FilteredStudents");
            }
        }

        void GenerateReport(object _)
        {
            MessageBox.Show("generate report click");
        }

        bool StudentMatchesFilter(Student student)
        {
            bool nameMatch = student.Name.ToLower().Contains(NameFilter);
            bool idMatch = student.StudentID.ToString().Contains(IdFilter);

            return nameMatch && idMatch;
        }

        void UpdateFilteredStudents(object _)
        {
            FilteredStudents = new ObservableCollection<Student>(students.Where(student => StudentMatchesFilter(student)));
        }

        void EditRecord(object _)
        {
            MessageBox.Show($"Edit record {SelectedCourseResult.CourseName}");
        }

        void DeleteRecord(object _)
        {
            MessageBox.Show($"Delete record {SelectedCourseResult.CourseName}");
        }

        void EditStudent(object _)
        {
            MessageBox.Show($"Edit Student {SelectedStudent.Name}");
        }

        void AddStudent(object _)
        {
            studentRepository.AddStudent(new Student("999999999", "test add", 0.5));
            students = studentRepository.GetStudents();
            UpdateFilteredStudents(null);
        }

        void SetupCommands()
        {
            GenerateReportCommand = new BaseCommand(GenerateReport);
            FilterChangedCommand = new BaseCommand(UpdateFilteredStudents);

            EditRecordCommand = new BaseCommand(EditRecord);
            DeleteRecordCommand = new BaseCommand(DeleteRecord);

            EditStudentCommand = new BaseCommand(EditStudent);
            AddStudentCommand = new BaseCommand(AddStudent);
        }

        void SetupRepositories()
        {
            studentRepository = new TestingStudentRepository();
        }

        public StudentSearchViewModel()
        {
            SetupCommands();
            SetupRepositories();

            filteredStudents = students = studentRepository.GetStudents();

            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 440", "Fall 2021",    4, "A"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 360", "Spring 2020",  4, "C"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("MAT 234", "Fall 2019",    3, "B"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 340", "Spring 2020",  3, "A"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 311", "Fall 2021",    3, "B")); 
            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 440", "Fall 2021",    4, "A"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 360", "Spring 2020",  4, "C"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("MAT 234", "Fall 2019",    3, "B"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 340", "Spring 2020",  3, "A"));
            SelectedStudentCourseResults.Add(new StudentCourseResult("CSC 311", "Fall 2021",    3, "B"));
        }
    }
}
