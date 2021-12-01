using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrarCourseManager.ViewModel.Tabs
{
    class UploadRecordsViewModel : ViewModelBase
    {
        private string selectedItem;
        public string SelectedItem
        {
            get { return selectedItem; }
            set { 
                selectedItem = value;
                FilePath.Remove(selectedItem);
                OnPropertyChanged("FilePath");
                OnPropertyChanged("SelectedItem");
            }
        }

        private ObservableCollection<string> filePath;
        public ObservableCollection<string> FilePath
        {
            get { return filePath; }
            set { 
                filePath = value;
                OnPropertyChanged("FilePath");
            }
        }
        public UploadRecordsViewModel()
        {
            FilePath = new ObservableCollection<string>();
            FilePath.Add("test/1/path");
            FilePath.Add("test/2/path");
            FilePath.Add("test/3/path");
        }
    }
}
