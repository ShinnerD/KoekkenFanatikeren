using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF_UserInterface
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.Select();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateLogin(PasswordTextBox.Text);
        }

        private void ValidateLogin(string password)
        {
            if (password == "123")
            {
                this.Close();
            }
            else
            {
                WrongPasswordError();
            }
        }

        private void WrongPasswordError()
        {
            PasswordLabel.Text = "Forkert kodeord";
            PasswordLabel.ForeColor = Color.DarkRed;
        }
    }
}
