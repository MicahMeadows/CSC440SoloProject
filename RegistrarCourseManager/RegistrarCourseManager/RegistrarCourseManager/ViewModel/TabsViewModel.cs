using System.Windows;
using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.ViewModel.Tabs;

namespace RegistrarCourseManager.ViewModel
{
    class TabsViewModel : ViewModelBase
    {

        public string uploadRecordsImagePath = @"RegistrarCourseManager\Images\plus-circle.png";
        public string studentSearchImagePath = @"RegistrarCourseManager\Images\plus-circle.png";
        public string settingsImagePath = @"RegistrarCourseManager\Images\plus-circle.png";

        public ICommand OpenUploadCourseRecordsTabCommand { get; set; }
        public ICommand OpenStudentSearchTabCommand { get; set; }
        public ICommand OpenSettingsTabCommand { get; set; }

        private bool courseRecordUploadTabSelected;
        public bool CourseRecordUploadTabSelected
        {
            get { return courseRecordUploadTabSelected; }
            set
            {
                courseRecordUploadTabSelected = value;
                OnPropertyChanged("CourseRecordUploadTabSelected");
            }
        }
        private bool studentSearchTabSelected;
        public bool StudentSearchTabSelected
        {
            get { return studentSearchTabSelected; }
            set 
            {
                studentSearchTabSelected = value;
                OnPropertyChanged("StudentSearchTabSelected");
            }
        }
        
        private bool settingsTabSelected;
        public bool SettingsTabSelected
        {
            get { return settingsTabSelected; }
            set
            {
                settingsTabSelected = value;
                OnPropertyChanged("SettingsTabSelected");
            }
        }


        private ViewModelBase currentTabViewModel;
        public ViewModelBase CurrentTabViewModel
        {
            get
            {
                return currentTabViewModel;
            }
            set
            {
                currentTabViewModel = value;
                OnPropertyChanged("CurrentTabViewModel");
            }
        }

        public TabsViewModel()
        {
            OpenUploadCourseRecordsTabCommand = new BaseCommand(OpenUploadCourseRecordsTab);
            OpenStudentSearchTabCommand = new BaseCommand(OpenStudentSearchTab);
            OpenSettingsTabCommand = new BaseCommand(OpenSettingsTab);

            OpenUploadCourseRecordsTabCommand.Execute(null);
        }

        void OpenUploadCourseRecordsTab(object _)
        {
            CourseRecordUploadTabSelected = true;
            StudentSearchTabSelected = false;
            SettingsTabSelected = false;
            OnPropertyChanged("CourseRecordUploadTabSelected");

            CurrentTabViewModel = new UploadRecordsViewModel();
        }

        void OpenStudentSearchTab(object _)
        {
            CourseRecordUploadTabSelected = false;
            StudentSearchTabSelected = true;
            SettingsTabSelected = false;
            OnPropertyChanged("StudentSearchTabSelected");

            CurrentTabViewModel = new StudentSearchViewModel();
        }

        void OpenSettingsTab(object _)
        {
            CourseRecordUploadTabSelected = false;
            StudentSearchTabSelected = false;
            SettingsTabSelected = true;
            OnPropertyChanged("SettingsTabSelected");

            CurrentTabViewModel = new SettingsViewModel();
        }
    }
}
