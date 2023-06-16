using System;
using System.Drawing;
using System.Windows.Forms;

namespace KF_UserInterface
{
    public partial class LoginForm : Form
    {
        //Used for Window Dragging
        private bool mouseDown;

        private Point lastLocation;

        //Constructor
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.Select();
        }

        //Exit Button Closes the Application.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimizes the Window to the tasbar.
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Login button click event
        private void LoginButton_Click(object sender, EventArgs e)
        {
            ValidateLogin(PasswordTextBox.Text);
        }

        //Dummy login code, hardcoded password for single user.
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

        //Changes the labeltext above the password box to indicate a wrong password was typed.
        private void WrongPasswordError()
        {
            PasswordLabel.Text = "Forkert kodeord";
            PasswordLabel.ForeColor = Color.DarkRed;
        }

        //Following three mouse events handle the ability to drag the window.
        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void HeaderLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void HeaderLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}