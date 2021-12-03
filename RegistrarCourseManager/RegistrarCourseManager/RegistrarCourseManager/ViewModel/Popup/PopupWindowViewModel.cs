using RegistrarCourseManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                popupViewModel = value;
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

        public PopupWindowViewModel(ViewModelBase popupContentViewModel, string title)
        {
            IconSource = "/RegistrarCourseManager;component/Images/file-plus.png";
            Title = title;
            PopupViewModel = popupContentViewModel;
        }
    }
}
