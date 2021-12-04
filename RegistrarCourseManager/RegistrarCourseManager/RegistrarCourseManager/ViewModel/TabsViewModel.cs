using System.Windows;
using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.Model;
using RegistrarCourseManager.ViewModel.Tabs;

namespace RegistrarCourseManager.ViewModel
{
    class TabsViewModel : ViewModelBase
    {
        public string Welcome
        {
            get
            {
                return RepositorySingleton.Instance.authUsername;
            }
        }

        //private Account user;
        //public Account User
        //{
        //    get
        //    {
        //        return user;
        //    }
        //    set
        //    {
        //        user = value;
        //        OnPropertyChanged("User");
        //    }
        //}

        public ICommand MinimizeApplicationCommand { get; set; }
        public ICommand QuitApplicationCommand { get; set; }
        public ICommand OpenUploadCourseRecordsTabCommand { get; set; }
        public ICommand OpenStudentSearchTabCommand { get; set; }
        public ICommand OpenSettingsTabCommand { get; set; }

        private string pageText;
        public string PageText
        {
            get => pageText;
            set
            {
                pageText = value;
                OnPropertyChanged("PageText");
            }
        }
        
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

        void quitApp(object _)
        {
            Application.Current.Shutdown();
        }

        void minimizeApp(object _)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        public TabsViewModel(/*Account user*/)
        {
            //User = user;

            QuitApplicationCommand = new BaseCommand(quitApp);
            MinimizeApplicationCommand = new BaseCommand(minimizeApp);

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

            PageText = "Upload Records";

            OnPropertyChanged("CourseRecordUploadTabSelected");

            CurrentTabViewModel = new UploadRecordsViewModel();
        }

        void OpenStudentSearchTab(object _)
        {
            CourseRecordUploadTabSelected = false;
            StudentSearchTabSelected = true;
            SettingsTabSelected = false;

            PageText = "Student Search";

            OnPropertyChanged("StudentSearchTabSelected");

            CurrentTabViewModel = new StudentSearchViewModel();
        }

        void OpenSettingsTab(object _)
        {
            CourseRecordUploadTabSelected = false;
            StudentSearchTabSelected = false;
            SettingsTabSelected = true;

            PageText = "Settings";

            OnPropertyChanged("SettingsTabSelected");

            CurrentTabViewModel = new SettingsViewModel();
        }
    }
}
