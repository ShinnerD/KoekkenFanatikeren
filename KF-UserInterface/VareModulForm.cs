using DataManagement.Model;
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
        public List<Vare> VareListe { get; set; }
        public Vare ValgteVare { get; set; }

        public VareModulForm()
        {
            InitializeComponent();
            VareGruppeComboBox.SelectedIndex = 0;
            VareListe = new DataManagement.Service.VareService().RetunererAlleVareService();
            VareListeDataGrid.AutoGenerateColumns = false;
            VareListeDataGrid.DataSource = VareListe;
        }

        private void LockProgram()
        {
            Application.Restart();
        }

        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VareListeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ValgteVare = VareListeDataGrid.SelectedRows[0].DataBoundItem as Vare;

            NameContentLabel.Text = ValgteVare.ProductName;
            VareIdContentLabel.Text = ValgteVare.ProductGroup_ID.ToString();
            VareGruppeContentLabel.Text = ValgteVare.VaregruppeNavn;
            PrisContentLabel.Text = ValgteVare.Price.ToString();

            FarverListView.Items.Clear();
            FarverListView.Items.Add(ValgteVare.Colour);

            MaterialerListView.Items.Clear();
            MaterialerListView.Items.Add(ValgteVare.Material);

            GrebListView.Items.Clear();
            GrebListView.Items.Add(ValgteVare.Grip);

            VareBeskrivelseTxtBox.Text = "";
        }
    }
}
