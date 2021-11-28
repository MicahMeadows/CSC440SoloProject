using System.Windows.Input;
using RegistrarCourseManager.Commands;

namespace RegistrarCourseManager.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        private MainViewModel mainViewModel;

        public ICommand LoginCommand { get; set; }

        public LoginViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            LoginCommand = new BaseCommand(Login);
        }

        void Login(object _)
        {
            mainViewModel.OpenTabsViewCommand.Execute(null);
        }
    }
}