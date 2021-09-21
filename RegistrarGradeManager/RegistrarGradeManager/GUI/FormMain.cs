using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RegistrarGradeManager.GUI;
using Excel = Microsoft.Office.Interop.Excel;

namespace RegistrarGradeManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            var userLoginView = new LoginView(this);

            userLoginView.Width = this.Width;
            userLoginView.Height = this.Height;
            this.Controls.Add(userLoginView);
        }
    }
}
