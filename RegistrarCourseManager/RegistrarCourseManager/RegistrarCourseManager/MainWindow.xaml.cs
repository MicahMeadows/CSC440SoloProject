using System.Windows;
using RegistrarCourseManager.ViewModel;

namespace RegistrarCourseManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized) {
                this.Left = e.GetPosition(this).X - (this.Width / 2);
                this.Top = 0;
                this.WindowState = WindowState.Normal;
            }
            this.DragMove();
        }
    }
}
