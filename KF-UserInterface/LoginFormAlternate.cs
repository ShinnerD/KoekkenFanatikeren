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
    public partial class LoginFormAlternate : Form
    {
        public LoginFormAlternate()
        {
            InitializeComponent();
            PasswordTextBox.Select();
        }

        //Dummy login code, hardcoded password for single user.
        private void ValidateLogin(string password)
        {
            if (password == "123")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                WrongPasswordError();
            }
        }

        //Changes the labeltext above the password box to indicate a wrong password was typed.
        private void WrongPasswordError()
        {
            PasswordLabel.Text = "Forkert password";
            PasswordLabel.ForeColor = Color.DarkRed;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ValidateLogin(PasswordTextBox.Text);
        }

        //Handles the "Enter" Key event in the password text field.
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateLogin(PasswordTextBox.Text);
            }
        }
    }
}
