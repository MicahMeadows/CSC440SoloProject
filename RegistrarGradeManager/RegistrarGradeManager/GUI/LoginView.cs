using System;
using System.Windows.Forms;
using MySql.Data;

namespace RegistrarGradeManager.GUI
{
    public partial class LoginView : UserControl
    {
        Form parentForm;

        public LoginView(Form parentForm)
        {
            this.parentForm = parentForm;

            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            bool loginResult = AttemptLogin();

            if(loginResult)
                parentForm.Controls.Remove(this);
        }

        private bool AttemptLogin()
        {
            Console.WriteLine($"user: {textBoxUsername.Text} pass: {textBoxPassword.Text} logged in.");

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || string.IsNullOrWhiteSpace(textBoxUsername.Text))
                return false;

            return true;
        }

    }
}
