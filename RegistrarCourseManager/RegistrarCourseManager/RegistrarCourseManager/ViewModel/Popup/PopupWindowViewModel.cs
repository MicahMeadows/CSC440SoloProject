using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.ViewModel.Popup
{
    class PopupWindowViewModel : ViewModelBase
    {

        private ViewModelBase popupViewModel;
        public ViewModelBase PopupViewModel
        {
            get => popupViewModel;
            set
            {
                PopupViewModel = value;
                OnPropertyChanged("PopupViewMode");
            }
        }

        private string iconSource;
        public string IconSource
        {
            get => iconSource;
            set
            {
                iconSource = value;
                OnPropertyChanged("IconSource");
            }
        }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public PopupWindowViewModel()
        {
            IconSource = "/RegistrarCourseManager;component/Images/file-plus.png";
            Title = "popup";
        }
    }
}
