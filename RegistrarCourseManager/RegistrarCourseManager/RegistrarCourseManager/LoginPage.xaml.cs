using System.Windows;
using System.Windows.Controls;

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

        private void TextBox_Click(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string textBoxText = textBox.Text;

            if(textBoxText.ToLower() == "username" || textBoxText.ToLower() == "password")
            {
                textBox.Text = "";
            }
        }
        private void PasswordTextBox_Leave(object sender, RoutedEventArgs e)
        {
            TextBox passwordTextBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Password";
            }
        }
        private void UsernameTextBox_Leave(object sender, RoutedEventArgs e)
        {
            TextBox usernameTextBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                usernameTextBox.Text = "Username";
            }
        }
    }
}
