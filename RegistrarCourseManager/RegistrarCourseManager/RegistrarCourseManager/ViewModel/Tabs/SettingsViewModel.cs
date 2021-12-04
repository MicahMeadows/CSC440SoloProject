using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RegistrarCourseManager.Commands;

namespace RegistrarCourseManager.ViewModel.Tabs
{
    class SettingsViewModel : ViewModelBase
    {
        private string connectionString;
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
                RepositorySingleton.Instance.connectionString = value;
                OnPropertyChanged("ConnectionString");
            }
        }


        public SettingsViewModel()
        {
            ConnectionString = "server = 127.0.0.1; database = csc440solo; uid = root;";
        }
    }
}
