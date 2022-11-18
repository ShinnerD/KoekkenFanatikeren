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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            LockProgram();
        }

        private void LockProgram()
        {
            Application.Restart();
        }
    }
}
