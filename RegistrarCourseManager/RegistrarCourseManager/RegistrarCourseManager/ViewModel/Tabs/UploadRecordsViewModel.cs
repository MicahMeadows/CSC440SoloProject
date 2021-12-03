using RegistrarCourseManager.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RegistrarCourseManager.ViewModel.Tabs
{
    class UploadRecordsViewModel : ViewModelBase
    {
        public ICommand BrowseFilesCommand { get; set; }
        public ICommand UploadFilesCommand { get; set; }

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

        void browseFiles(object _)
        {
            MessageBox.Show("browse files click");
        }
        void uploadFiles(object _)
        {
            MessageBox.Show("upload files click");
        }

        public UploadRecordsViewModel()
        {
            BrowseFilesCommand = new BaseCommand(browseFiles);
            UploadFilesCommand = new BaseCommand(uploadFiles);

            FilePath = new ObservableCollection<string>();
            FilePath.Add("test/1/path");
            FilePath.Add("test/2/path");
            FilePath.Add("test/3/path");
        }
    }
}
