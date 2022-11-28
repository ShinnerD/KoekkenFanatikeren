using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KF_UserInterface
{
    public partial class VareModulForm : Form
    {
        public List<Vare> VareListe { get; set; }
        public List<Vare> FiltreretVareListe { get; set; }
        public Vare ValgteVare { get; set; }
        public List<Varegruppe> VareGrupper { get; set; }

        public VareModulForm()
        {
            InitializeComponent();

            try
            {
                SetupVareListe();
                SetupVaregruppeDropDown();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Sets up the VareGruppe DrownDown list at the start of the Form.
        /// </summary>
        private void SetupVaregruppeDropDown()
        {
            VareGrupper = new DataManagement.Service.VareGruppeService().RetunererAlleVaregruppeService();
            Varegruppe alle = new Varegruppe();
            alle.ProductGroupName = "Alle";
            alle.ProductGroup_Id = 0;
            VareGrupper = VareGrupper.OrderBy(i => i.ProductGroupName).ToList();
            VareGrupper.Insert(0, alle);
            VareGruppeComboBox.DataSource = VareGrupper;
            VareGruppeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Sets up the List that populates the VareDataGridView.
        /// </summary>
        private void SetupVareListe()
        {
            VareListe = new DataManagement.Service.VareService().RetunererAlleVareService();
            VareListe = VareListe.OrderBy(i => i.ProductName).ToList();
            FiltreretVareListe = VareListe;
            VareListeDataGrid.AutoGenerateColumns = false;
            VareListeDataGrid.DataSource = FiltreretVareListe;
            VareListeDataGrid.Rows[0].Selected = true;
            SetProductDetailLabels();
        }

        /// <summary>
        /// Resets application back to password screen.
        /// </summary>
        private void LockProgram()
        {
            Application.Restart();
        }

        /// <summary>
        /// Sets the Labels on the right side of the Window to Match the Vare chosen in the DataGridView.
        /// </summary>
        private void SetProductDetailLabels()
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

        /// <summary>
        /// Performs a Search and filtering of the List that Populates the DatagridView.
        /// Filters based in the input in the search box, and takes the DropDown List selection into account.
        /// </summary>
        private void PerformTextSearchOnList()
        {
            if (SearchFieldTextBox.Text == "" || SearchFieldTextBox.Text == "Indtast varenavn, vare id eller varegruppe...")
            {
                FiltreretVareListe = PerformVaregruppeSearch(VareListe);
                VareListeDataGrid.DataSource = FiltreretVareListe;
            }
            else
            {
                FiltreretVareListe = VareListe.Where(i => i.ProductName.ToLower().Contains(SearchFieldTextBox.Text.ToLower())
                                                       || i.Product_ID.ToString().Contains(SearchFieldTextBox.Text.ToLower())
                                                       || i.VaregruppeNavn.ToLower().Contains(SearchFieldTextBox.Text.ToLower())).ToList();
                FiltreretVareListe = PerformVaregruppeSearch(FiltreretVareListe);
                VareListeDataGrid.DataSource = FiltreretVareListe;
            }
        }

        /// <summary>
        /// Takes the Given List and performs a filtering based in Product Group Name.
        /// Returns a List<Vare> as a result.
        /// </summary>
        /// <param name="startListe"></param>
        /// <returns></returns>
        private List<Vare> PerformVaregruppeSearch(List<Vare> startListe)
        {
            Varegruppe valgteVaregruppe = VareGruppeComboBox.SelectedItem as Varegruppe;
            if (valgteVaregruppe.ProductGroupName == "Alle")
            {
                return startListe;
            }
            else
            {
                return startListe.Where(i => i.VaregruppeNavn == valgteVaregruppe.ProductGroupName).ToList();
            }
        }

        //Click Events For Buttons.
        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VareListeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetProductDetailLabels();
        }

        private void SearchFieldTextBox_Click(object sender, EventArgs e)
        {
            if (SearchFieldTextBox.Text == "Indtast varenavn, vare id eller varegruppe...")
            {
                SearchFieldTextBox.Text = "";
            }
        }

        private void SearchFieldTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            PerformTextSearchOnList();
        }

        private void VareGruppeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PerformTextSearchOnList();
        }
    }
}