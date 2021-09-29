using System.Windows;
using System.Windows.Controls;
using System;

namespace RegistrarCourseManager
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void LoginSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationLanding applicationLandingPage = new ApplicationLanding();

            this.NavigationService.Navigate(applicationLandingPage);
        }
    }
}
