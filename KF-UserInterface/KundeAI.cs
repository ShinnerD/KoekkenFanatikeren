using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF_UserInterface
{
    public partial class KundeAI : Form
    {
        public List<Vare> VareListe { get; set; }
        public List<Vare> FiltreretVareListe { get; set; }
        public Vare ValgteVare { get; set; }

        public KundeAI()
        {
            InitializeComponent();
            SetupStartState();
            LandingPanel.BringToFront();
        }

        /// <summary>
        /// Sætter labels og tekst i højre side af resultatpanelet til at være lig detaljer fra valgte vare i datagridview.
        /// </summary>
        private void SetProductDetailLabels()
        {
            ValgteVare = VareListeDataGrid.SelectedRows[0].DataBoundItem as Vare;

            NameContentLabel.Text = ValgteVare.ProductName;
            VareIdContentLabel.Text = ValgteVare.ProductGroup_ID.ToString();
            VareGruppeContentLabel.Text = ValgteVare.VaregruppeNavn;
            PrisContentLabel.Text = ValgteVare.Price.ToString();

            FarverListView.Items.Clear();
            foreach (KitchenColor color in ValgteVare.AvailableColors)
            {
                FarverListView.Items.Add(color.Color_Name);
            }

            MaterialerListView.Items.Clear();
            foreach (Material material in ValgteVare.AvailableMaterials)
            {
                MaterialerListView.Items.Add(material.MaterialName);
            }

            GrebListView.Items.Clear();
            foreach (Grip grip in ValgteVare.AvailableGrips)
            {
                GrebListView.Items.Add(grip.Grip_Name);
            }

            VareBeskrivelseTxtBox.Text = ValgteVare.Description;
        }

        /// <summary>
        /// Sætter vinduets opstartsstatus.
        /// </summary>
        private void SetupStartState()
        {
            LandingPanel.BringToFront();
            StartOverBtn.Visible = false;
            VareListe = new DataManagement.Service.VareService().RetunererAlleVareService();
            VareListe = VareListe.OrderBy(i => i.ProductName).ToList();
            FiltreretVareListe = VareListe;
            VareListeDataGrid.AutoGenerateColumns = false;
            VareListeDataGrid.DataSource = FiltreretVareListe;
            VareListeDataGrid.Rows[0].Selected = true;
        }

        //Start Button Click
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Question1Panel.BringToFront();
        }

        //Vareliste Click Event
        private void VareListeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetProductDetailLabels();
        }


        //Question 1 panel buttons
        private void SparerundeBtn_Click(object sender, EventArgs e)
        {
            FiltreretVareListe = VareListe.Where(i => i.Price <= 5000).ToList();
            Question2Panel.BringToFront();
            StartOverBtn.Visible = true;
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            FiltreretVareListe = VareListe.Where(i => i.Price > 5000 && i.Price <= 10000).ToList();
            Question2Panel.BringToFront();
            StartOverBtn.Visible = true;
        }

        private void EksklusivtBtn_Click(object sender, EventArgs e)
        {
            FiltreretVareListe = VareListe.Where(i => i.Price > 10000).ToList();
            Question2Panel.BringToFront();
            StartOverBtn.Visible = true;
        }


        //Question 2 panel clicks.
        private void LightBtn_Click(object sender, EventArgs e)
        {
            List<string> lightColors = new List<string>();
            lightColors.Add("White");
            lightColors.Add("Yellow");
            lightColors.Add("Fuchsia");
            lightColors.Add("Red");
            lightColors.Add("Silver");
            lightColors.Add("Gray");
            lightColors.Add("Olive");

            FiltreretVareListe = FiltreretVareListe.Where(i => i.AvailableColors.Any(o => lightColors.Contains(o.Color_Name))).ToList();
            Question3Panel.BringToFront();
        }

        private void DarkBtn_Click(object sender, EventArgs e)
        {
            List<string> darkColors = new List<string>();
            darkColors.Add("Purple");
            darkColors.Add("Maroon");
            darkColors.Add("Aqua");
            darkColors.Add("Lime");
            darkColors.Add("Teal");
            darkColors.Add("Green");
            darkColors.Add("Blue");
            darkColors.Add("Navy");
            darkColors.Add("Black");

            FiltreretVareListe = FiltreretVareListe.Where(i => i.AvailableColors.Any(o => darkColors.Contains(o.Color_Name))).ToList();
            Question3Panel.BringToFront();
        }

        //Question 3 panel Clicks
        private void LowBtn_Click(object sender, EventArgs e)
        {
            FiltreretVareListe = FiltreretVareListe.Where(i => i.SizeCategory == "small").ToList();
            Question4Panel.BringToFront();
        }

        private void MediumBtn_Click(object sender, EventArgs e)
        {
            FiltreretVareListe = FiltreretVareListe.Where(i => i.SizeCategory == "medium").ToList();
            Question4Panel.BringToFront();
        }

        private void HighBtn_Click(object sender, EventArgs e)
        {
            FiltreretVareListe = FiltreretVareListe.Where(i => i.SizeCategory == "large").ToList();
            Question4Panel.BringToFront();
        }

        //Question 4 panel clicks
        private void TræBtn_Click(object sender, EventArgs e)
        {
            List<string> treeMaterials = new List<string>();
            treeMaterials.Add("Massivt Træ");
            treeMaterials.Add("Finér");

            FiltreretVareListe = FiltreretVareListe.Where(i => i.AvailableMaterials.Any(o => treeMaterials.Contains(o.MaterialName))).ToList();
            SeeResults();
        }

        private void LaminatBtn_Click(object sender, EventArgs e)
        {
            List<string> laminatMaterials = new List<string>();
            laminatMaterials.Add("Laminat");
            laminatMaterials.Add("Microlaminat");

            FiltreretVareListe = FiltreretVareListe.Where(i => i.AvailableMaterials.Any(o => laminatMaterials.Contains(o.MaterialName))).ToList();
            SeeResults();
        }


        private void MelaminBtn_Click(object sender, EventArgs e)
        {
            List<string> melaminMaterials = new List<string>();
            melaminMaterials.Add("Melamin");

            FiltreretVareListe = FiltreretVareListe.Where(i => i.AvailableMaterials.Any(o => melaminMaterials.Contains(o.MaterialName))).ToList();
            SeeResults();
        }

        private void OtherBtn_Click(object sender, EventArgs e)
        {
            List<string> otherMaterials = new List<string>();
            otherMaterials.Add("Malede Låger");
            otherMaterials.Add("Folie Låger");

            FiltreretVareListe = FiltreretVareListe.Where(i => i.AvailableMaterials.Any(o => otherMaterials.Contains(o.MaterialName))).ToList();
            SeeResults();
        }

        private void SeeResults()
        {
            VareListeDataGrid.DataSource = FiltreretVareListe;
            ResultPanel.BringToFront();
        }

        private void StartOverBtn_Click(object sender, EventArgs e)
        {
            Question1Panel.BringToFront();
            StartOverBtn.Visible = false;
            FiltreretVareListe = VareListe;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            FiltreretVareListe = VareListe;
            StartOverBtn.Visible = false;
            LandingPanel.BringToFront();
        }
    }
}
