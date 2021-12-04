using System.Windows;
using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.Model;
using RegistrarCourseManager.Model.Repositories;

namespace RegistrarCourseManager.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        private IAccountRepository accountRepository;
        private MainViewModel mainViewModel;

        public ICommand LoginCommand { get; set; }

        private string username;

        public string Username
        {
            get
            {
                return username;
            } 
        set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }


        public LoginViewModel(MainViewModel mainViewModel)
        {
            this.accountRepository = RepositorySingleton.Instance.accountRepository;
            this.mainViewModel = mainViewModel;
            LoginCommand = new BaseCommand(Login);
        }

        void Login(object _)
        {
            if (accountRepository.Authenticate(new Account(Username, Password))){
                mainViewModel.OpenTabsViewCommand.Execute(null);
            } else
            {
                MessageBox.Show($"Invalid login user:{Username} pass:{Password}");
            }
        }
    }
}