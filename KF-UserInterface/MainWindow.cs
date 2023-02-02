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

        private void KundeModulButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            KundeModulForm kundeModul = new KundeModulForm();
            Cursor = Cursors.Default;
            this.Hide();
            kundeModul.ShowDialog();
            this.Show();
        }

        private void VareModulButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            VareModulForm vareModul = new VareModulForm();
            Cursor = Cursors.Default;
            this.Hide();
            vareModul.ShowDialog();
            this.Show();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            KundeAI kundeAIform = new KundeAI();
            Cursor = Cursors.Default;
            this.Hide();
            kundeAIform.ShowDialog();
            this.Show();
        }

        private void SalesStatisticsButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SalgsStatistikForm salgsStatistikForm = new SalgsStatistikForm();
            Cursor = Cursors.Default;
            this.Hide();
            salgsStatistikForm.ShowDialog();
            this.Show();
        }
    }
}
