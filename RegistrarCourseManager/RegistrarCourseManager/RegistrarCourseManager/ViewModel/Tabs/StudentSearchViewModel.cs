using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.Model;
using RegistrarCourseManager.Model.Repositories;
using RegistrarCourseManager.View;
using RegistrarCourseManager.ViewModel.Popup;

namespace RegistrarCourseManager.ViewModel.Tabs
{
    class StudentSearchViewModel : ViewModelBase
    {
        public IStudentRepository studentRepository;
        public IGradesRepository gradesRepository;
        public ICourseRepository courseRepository;

        public ICommand AddStudentCommand { get; set; }
        public ICommand EditStudentCommand { get; set; }
        public ICommand EditRecordCommand { get; set; }
        public ICommand AddRecordCommand { get; set; }
        public ICommand DeleteRecordCommand { get; set; }
        public ICommand FilterChangedCommand { get; set; }
        public ICommand GenerateReportCommand { get; set; }

        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        private ObservableCollection<CourseGrade> gradeRecords = new ObservableCollection<CourseGrade>();

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
                UpdateSelectedStudentCourseResults();
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

        void submitEditRecord(object _)
        {
            MessageBox.Show("click submit");
        }

        private Task ShowPopup(PopupWindow popup)
        {
            var task = new TaskCompletionSource<object>();
            popup.Owner = Application.Current.MainWindow;
            popup.Closed += (s, a) => task.SetResult(null);
            popup.Show();
            popup.Focus();
            return task.Task;
        }

        async void EditRecord(object _)
        {
            var recordToEdit = selectedCourseResult.CourseGrade;

            PopupWindow popup = new PopupWindow();
            popup.DataContext = new PopupWindowViewModel(new EditCourseGradeViewModel(gradesRepository, recordToEdit, popup), "Edit Grade");
            // popup.Show();
            await ShowPopup(popup);

            UpdateSelectedStudentCourseResults();
        }

        async void AddRecord(object _)
        {
            if (SelectedStudent == null)
                return;

            PopupWindow popup = new PopupWindow();

            popup.DataContext = new PopupWindowViewModel(new EditCourseGradeViewModel(gradesRepository, SelectedStudent.StudentID, popup), "Add Grade");
            await ShowPopup(popup);

            UpdateSelectedStudentCourseResults();
        }

        void DeleteRecord(object _)
        {
            try
            {
                gradesRepository.DeleteCourseGrade(SelectedCourseResult.CourseGrade);
                UpdateSelectedStudentCourseResults();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
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

        ObservableCollection<StudentCourseResult> MakeCourseResults(ObservableCollection<CourseGrade> grades)
        {
            ObservableCollection<StudentCourseResult> courseResults = new ObservableCollection<StudentCourseResult>();

            foreach(var grade in grades) 
            {
                courseResults.Add(new StudentCourseResult(grade, GetCreditHours(grade)));
            }
            return courseResults;
        }

        int GetCreditHours(CourseGrade grade)
        {
            try
            {
                return courseRepository.GetCourse(grade).Hours;
            } catch (Exception e)
            {
                return 0;
            }

        }

        void UpdateSelectedStudentCourseResults()
        {
            try
            {
                var courseGrades = gradesRepository.GetCourseGrades(SelectedStudent);

                SelectedStudentCourseResults = MakeCourseResults(courseGrades);
                OnPropertyChanged("SelectedStudentCourseResults");
            } catch 
            {

            }
        }

        void SetupCommands()
        {
            GenerateReportCommand = new BaseCommand(GenerateReport);
            FilterChangedCommand = new BaseCommand(UpdateFilteredStudents);

            AddRecordCommand = new BaseCommand(AddRecord);
            EditRecordCommand = new BaseCommand(EditRecord);
            DeleteRecordCommand = new BaseCommand(DeleteRecord);

            EditStudentCommand = new BaseCommand(EditStudent);
            AddStudentCommand = new BaseCommand(AddStudent);
        }

        void SetupRepositories()
        {
            studentRepository = new TestingStudentRepository();
            gradesRepository = new TestingGradesRepository();
            courseRepository = new TestingCourseRepository();
        }

        public StudentSearchViewModel()
        {
            SetupCommands();
            SetupRepositories();

            students = studentRepository.GetStudents();
            UpdateFilteredStudents(null);
        }
    }
}
