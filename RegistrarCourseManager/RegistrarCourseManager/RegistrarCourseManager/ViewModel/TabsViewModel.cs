using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.ViewModel.Tabs;

namespace RegistrarCourseManager.ViewModel
{
    class TabsViewModel : ViewModelBase
    {
        ICommand OpenUploadCourseRecordsTabCommand { get; set; }

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

            OpenUploadCourseRecordsTabCommand.Execute(null);
        }

        void OpenUploadCourseRecordsTab(object _)
        {
            CurrentTabViewModel = new UploadRecordsViewModel();
        }
    }
}
