using RegistrarCourseManager.Commands;
using System.Windows.Input;

namespace RegistrarCourseManager.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public ICommand OpenLoginViewCommand { get; set; }
        public ICommand OpenTabsViewCommand { get; set; }

        private ViewModelBase currentScreenViewModel;
        public ViewModelBase CurrentScreenViewModel
        {
            get
            {
                return currentScreenViewModel;
            }
            set
            {
                currentScreenViewModel = value;
                OnPropertyChanged("CurrentScreenViewModel");
            }
        }

        public MainViewModel()
        {
            OpenLoginViewCommand = new BaseCommand(OpenLoginView);
            OpenTabsViewCommand = new BaseCommand(OpenTabsView);

            OpenLoginViewCommand.Execute(null);
        }

        private void OpenLoginView(object _)
        {
            CurrentScreenViewModel = new LoginViewModel(this);
        }
        private void OpenTabsView(object _)
        {
            CurrentScreenViewModel = new TabsViewModel();
        }


    }
}
