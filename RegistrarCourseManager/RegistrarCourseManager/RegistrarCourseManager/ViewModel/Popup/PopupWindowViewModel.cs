using RegistrarCourseManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RegistrarCourseManager.ViewModel.Popup
{
    class PopupWindowViewModel : ViewModelBase
    {

        private UserControl popupView;
        public UserControl PopupView
        {
            get => popupView;
            set
            {
                popupView = value;
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

        public PopupWindowViewModel(UserControl view, string title)
        {
            IconSource = "/RegistrarCourseManager;component/Images/file-plus.png";
            Title = title;
            popupView = view;
        }
        //public PopupWindowViewModel(ViewModelBase popupContentViewModel, string title)
        //{
        //    IconSource = "/RegistrarCourseManager;component/Images/file-plus.png";
        //    Title = title;
        //    // PopupViewModel = popupContentViewModel;
        //}
    }
}
