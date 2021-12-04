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
            get
            {
                if(SelectedStudent != null)
                {
                    SelectedStudent.OverallGPA = CalculateGPA(selectedStudentCourseResults);
                    OnPropertyChanged("SelectedStudent.OverallGPA");
                }
                return selectedStudentCourseResults;
            }
            set
            {
                selectedStudentCourseResults = value;
                OnPropertyChanged("SelectedStudentCourseResults");
            }
        }


        private ObservableCollection<Student> filteredStudents;
        public ObservableCollection<Student> FilteredStudents
        {
            get {
                return filteredStudents;
            }
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
            OnPropertyChanged("FilteredStudents");
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
            if (SelectedStudent == null)
                return;

            PopupWindow popup = new PopupWindow();

            popup.DataContext = new PopupWindowViewModel(new EditCourseGradeView(popup, gradesRepository, SelectedCourseResult.CourseGrade), "Edit Grade");
            await ShowPopup(popup);

            SelectedStudent.OverallGPA = CalculateGPA(SelectedStudentCourseResults);
            UpdateSelectedStudentCourseResults();
            UpdateFilteredStudents(null);
            // UpdateGPA();

        }

        //void UpdateGPA()
        //{
        //    UpdateFilteredStudents(null);
        //}

        async void AddRecord(object _)
        {
            if (SelectedStudent == null)
                return;

            PopupWindow popup = new PopupWindow();

            popup.DataContext = new PopupWindowViewModel(new EditCourseGradeView(popup, gradesRepository, null, SelectedStudent.StudentID), "Add Grade");
            await ShowPopup(popup);

            SelectedStudent.OverallGPA = CalculateGPA(SelectedStudentCourseResults);
            UpdateSelectedStudentCourseResults();
            UpdateFilteredStudents(null);
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
            UpdateFilteredStudents(null);
        }

        void EditStudent(object _)
        {
            UpdateSelectedStudentCourseResults();
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

        double CalculateGPA(ObservableCollection<StudentCourseResult> courseResults)
        {
            double pointsEarned = 0;
            double creditsAttempted = 0;
            foreach(var result in courseResults)
            {
                pointsEarned += result.Hours * GradeToInt(result.Grade);
                creditsAttempted += result.Hours;
            }

            if (creditsAttempted == 0)
                return 0;
            return Math.Round(pointsEarned / creditsAttempted, 2);
        }

        int GradeToInt(string grade)
        {
            switch (grade.ToLower()) 
            {
                case "a":
                    return 4;
                case "b":
                    return 3;
                case "c":
                    return 2;
                case "d":
                    return 1;
                case "f":
                    return 0;
                default:
                    return 0;
            }
        }

        void UpdateSelectedStudentCourseResults()
        {
            try
            {
                var courseGrades = gradesRepository.GetCourseGrades(SelectedStudent.StudentID);

                SelectedStudentCourseResults = MakeCourseResults(courseGrades);

                OnPropertyChanged("SelectedStudentCourseResults");
            } catch 
            {
                // MessageBox.Show("Failed to update results");
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
            studentRepository = RepositorySingleton.Instance.studentRepository;
            gradesRepository = RepositorySingleton.Instance.gradesRepository;
            courseRepository = RepositorySingleton.Instance.courseRepository;
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
