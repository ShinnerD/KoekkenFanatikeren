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
    public partial class VareModulForm : Form
    {
        public VareModulForm()
        {
            InitializeComponent();
            VareGruppeComboBox.SelectedIndex = 0;
        }

        private void LockProgram()
        {
            Application.Restart();
        }

        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
