using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using RegistrarCourseManager.Windows;

namespace RegistrarCourseManager.Pages
{
    /// <summary>
    /// Interaction logic for UploadRecordsPage.xaml
    /// </summary>
    public partial class UploadRecordsPage : Page
    {
        public UploadRecordsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PopupWindow popup = new PopupWindow();
            popup.ShowDialog();
        }
    }
}
