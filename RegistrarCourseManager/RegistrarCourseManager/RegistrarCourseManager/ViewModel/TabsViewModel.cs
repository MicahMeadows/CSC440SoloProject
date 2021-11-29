using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.ViewModel.Tabs;

namespace RegistrarCourseManager.ViewModel
{
    class TabsViewModel : ViewModelBase
    {
        ICommand OpenUploadCourseRecordsTabCommand { get; set; }
        ICommand OpenStudentSearchTabCommand { get; set; }
        ICommand OpenSettingsTabCommand { get; set; }

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
            // OpenStudentSearchTabCommand.Execute(null);
            // OpenSettingsTabCommand.Execute(null);

        }

        void OpenUploadCourseRecordsTab(object _)
        {
            CurrentTabViewModel = new UploadRecordsViewModel();
        }

        void OpenStudentSearchTab(object _)
        {
            CurrentTabViewModel = new StudentSearchViewModel();
        }

        void OpenSettingsTab(object _)
        {
            CurrentTabViewModel = new SettingsViewModel();
        }
    }
}
