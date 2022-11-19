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
    public partial class KundeModulForm : Form
    {
        public KundeModulForm()
        {
            InitializeComponent();
        }

        private void LockProgram()
        {
            Application.Restart();
        }

        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KundeModulForm_Load(object sender, EventArgs e)
        {

        }
    }
}
