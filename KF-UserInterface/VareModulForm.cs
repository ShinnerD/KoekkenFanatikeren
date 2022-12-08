using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KF_UserInterface
{
    public partial class VareModulForm : Form
    {
        public List<Vare> VareListe { get; set; }
        public List<Vare> FiltreretVareListe { get; set; }

        public List<Varegruppe> VareGrupper { get; set; }
        public List<Varegruppe> EditVaregrupper { get; set; }

        public Vare ValgteVare { get; set; }
        public Vare EditedVare { get; set; }

        public List<KitchenColor> AllColors { get; set; }
        public List<KitchenColor> ChosenColors { get; set; }
        public List<Material> AllMaterials { get; set; }
        public List<Material> ChosenMaterials { get; set; }
        public List<Grip> AllGrips { get; set; }
        public List<Grip> ChosenGrips { get; set; }

        //Constructor
        public VareModulForm()
        {
            InitializeComponent();

            try
            {
                SetupVareListe();
                SetupVaregruppeDropDown();
                SetupEditPanel();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Sets up the Edit Panel and its components. (Comboboxes and ListViews).
        /// </summary>
        private void SetupEditPanel()
        {
            DataManagement.Service.VareService vareService = new DataManagement.Service.VareService();

            AllColors = vareService.GetAllColors();
            AllMaterials = vareService.GetAllMaterials();
            AllGrips = vareService.GetAllGrips();

            VareGruppeEditComboBox.DataSource = new DataManagement.Service.VareGruppeService().RetunererAlleVaregruppeService();

            ColorEditComboBox.DataSource = AllColors;
            AddMaterialComboBox.DataSource = AllMaterials;
            AddGripComboBox.DataSource = AllGrips;
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
            HeightContentLabel.Text = ValgteVare.Height.ToString();
            WidthContentLabel.Text = ValgteVare.Width.ToString();
            DepthContentLabel.Text = ValgteVare.Length.ToString();

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

        /// <summary>
        /// Sets the Textboxes and Listviews in the Editpanel to reflect the values of the selected Vare.
        /// </summary>
        private void EditExistingVare()
        {
            if (VareListeDataGrid.SelectedRows.Count > 0)
            {
                EditedVare = ValgteVare;
                VareNavnTextBox.Text = EditedVare.ProductName;
                PriceTextBox.Text = EditedVare.Price.ToString();
                EditDescriptionTextBox.Text = EditedVare.Description;
                EditHeightTextBox.Text = EditedVare.Height.ToString();
                EditWidthTextBox.Text = EditedVare.Width.ToString();
                EditDepthTextBox.Text = EditedVare.Length.ToString();

                VareGruppeEditComboBox.SelectedIndex = VareGruppeEditComboBox.FindString(EditedVare.VaregruppeNavn);

                ChosenColors = new List<KitchenColor>();
                ChosenMaterials = new List<Material>();
                ChosenGrips = new List<Grip>();

                foreach (KitchenColor color in EditedVare.AvailableColors)
                {
                    EditColorListView.Items.Add(color.Color_Name);
                    ChosenColors.Add(color);
                }
                foreach (Material material in EditedVare.AvailableMaterials)
                {
                    EditMaterialListView.Items.Add(material.MaterialName);
                    ChosenMaterials.Add(material);
                }
                foreach (Grip grip in EditedVare.AvailableGrips)
                {
                    EditGripListView.Items.Add(grip.Grip_Name);
                    ChosenGrips.Add(grip);
                }
                VareEditPanel.BringToFront();
            }
        }

        /// <summary>
        /// Creates a new Vare to be edited in the editpanel.
        /// </summary>
        private void StartNewVareCreation()
        {
            EditedVare = new Vare();
            ChosenColors = new List<KitchenColor>();
            ChosenGrips = new List<Grip>();
            ChosenMaterials = new List<Material>();
            VareEditPanel.BringToFront();
        }

        /// <summary>
        /// Clears the Textboxes and Listviews in the Edit Panel.
        /// </summary>
        private void ClearEditPanelFields()
        {
            VareNavnTextBox.Clear();
            PriceTextBox.Clear();
            EditDescriptionTextBox.Clear();
            EditColorListView.Clear();
            EditGripListView.Clear();
            EditMaterialListView.Clear();
            EditHeightTextBox.Clear();
            EditWidthTextBox.Clear();
            EditDepthTextBox.Clear();
        }

        /// <summary>
        /// Saves the Info currently entered into the EditPanel if it passes validation.
        /// If the Vare is new a new vare is created in the database. If the vare already
        /// exists in the database its properties are edited.
        /// </summary>
        private void SaveVareInfo()
        {
            if (ValidateInputs())
            {
                var valgteVaregruppe = VareGruppeEditComboBox.SelectedItem as Varegruppe;

                EditedVare.ProductName = VareNavnTextBox.Text;
                EditedVare.Price = int.Parse(PriceTextBox.Text);
                EditedVare.Description = EditDescriptionTextBox.Text;

                EditedVare.ProductGroup_ID = valgteVaregruppe.ProductGroup_Id;
                EditedVare.Varegruppe = valgteVaregruppe;

                EditedVare.AvailableColors = ChosenColors;
                EditedVare.AvailableMaterials = ChosenMaterials;
                EditedVare.AvailableGrips = ChosenGrips;

                EditedVare.Height = decimal.Parse(EditHeightTextBox.Text);
                EditedVare.Width = decimal.Parse(EditWidthTextBox.Text);
                EditedVare.Length = decimal.Parse(EditDepthTextBox.Text);

                if (EditedVare.Product_ID != 0)
                {
                    new DataManagement.Service.VareService().EditVare(EditedVare);
                    SetupVareListe();
                    ClearEditPanelFields();
                    MainPanel.BringToFront();
                }
                else
                {
                    new DataManagement.Service.VareService().SaveNewVare(EditedVare);
                    SetupVareListe();
                    ClearEditPanelFields();
                    MainPanel.BringToFront();
                }
            }
            else
            {
                ErrorLabel.Visible = true;
                ErrorLabelTimer.Enabled = true;
            }
        }

        /// <summary>
        /// Validates that all fields have input in the Edit Panel. Checks that ints can parse as ints and decimals as decimals.
        /// </summary>
        /// <returns></returns>
        private bool ValidateInputs()
        {
            if (VareNavnTextBox.Text == string.Empty || PriceTextBox.Text == string.Empty || EditDescriptionTextBox.Text == string.Empty
                || EditColorListView.Items.Count == 0 || EditMaterialListView.Items.Count == 0 || EditGripListView.Items.Count == 0
                || EditHeightTextBox.Text == string.Empty || EditWidthTextBox.Text == string.Empty || EditDepthTextBox.Text == string.Empty)
            {
                return false;
            }
            if (!int.TryParse(PriceTextBox.Text, out int priceResult) || !decimal.TryParse(EditHeightTextBox.Text, out decimal heightResult)
                || !decimal.TryParse(EditWidthTextBox.Text, out decimal widthResult) || !decimal.TryParse(EditDepthTextBox.Text, out decimal depthResult))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Is set to tick when there is a failure to validate inputs in the edit panel. Shows an error message for 3000ms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ErrorLabelTimer_Tick(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            ErrorLabelTimer.Enabled = false;
        }

        /// <summary>
        /// Writes the products in the given product list to a textfile in the main program directory.
        /// </summary>
        /// <param name="vareListe"></param>
        private void WriteProductsToTextFile(List<Vare> vareListe)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("|=======================================================================|").AppendLine();
            stringBuilder.Append("|\t\t\tVareliste Udskrift\t\t\t        |").AppendLine();
            stringBuilder.Append("|\t\t\t\t\t\t\t\t        |").AppendLine();
            stringBuilder.Append("|=======================================================================|").AppendLine();
            stringBuilder.Append("|ID\tVarenavn\t\tVareGruppe\t\tPris\t\t|").AppendLine();
            stringBuilder.Append("|=======================================================================|").AppendLine();

            foreach (Vare vare in vareListe)
            {
                stringBuilder.Append("|").Append(vare.Product_ID.ToString()).Append("\t");

                if (vare.ProductName.Length <= 7)
                {
                    stringBuilder.Append(vare.ProductName).Append("\t\t\t");
                }
                if (vare.ProductName.Length >= 8 && vare.ProductName.Length <= 15)
                {
                    stringBuilder.Append(vare.ProductName).Append("\t\t");
                }
                if (vare.ProductName.Length >= 16)
                {
                    stringBuilder.Append(vare.ProductName).Append("\t");
                }
                if (vare.ProductName.Length >= 24)
                {
                    stringBuilder.Append(vare.ProductName.Substring(0, 20)).Append("...\t");
                }
                if (vare.VaregruppeNavn.Length <= 7)
                {
                    stringBuilder.Append(vare.VaregruppeNavn).Append("\t\t\t");
                }
                if (vare.VaregruppeNavn.Length >= 8)
                {
                    stringBuilder.Append(vare.VaregruppeNavn).Append("\t\t");
                }

                stringBuilder.Append(vare.Price.ToString()).Append("\t\t|").AppendLine();
            }
            stringBuilder.Append("|=======================================================================|").AppendLine();
            stringBuilder.Append("Total antal vare: ").Append(vareListe.Count.ToString());
            File.WriteAllText("./VareListe " + DateTime.Now.ToString("dd-MM-yy") + ".txt", stringBuilder.ToString());
            MessageBox.Show("Indholdet i nuværende vareliste er skrevet til text fil");
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

        private void RedigerVareButton_Click(object sender, EventArgs e)
        {
            EditExistingVare();
        }

        private void NyVareButton_Click(object sender, EventArgs e)
        {
            StartNewVareCreation();
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            ClearEditPanelFields();
            MainPanel.BringToFront();
        }

        private void AddColorButton_Click(object sender, EventArgs e)
        {
            KitchenColor selectedColor = ColorEditComboBox.SelectedItem as KitchenColor;
            if (!ChosenColors.Contains(selectedColor))
            {
                ChosenColors.Add(selectedColor);
                EditColorListView.Items.Add(selectedColor.Color_Name);
            }
        }

        private void RemoveColorButton_Click(object sender, EventArgs e)
        {
            if (EditColorListView.SelectedItems.Count > 0)
            {
                ChosenColors.Remove(ChosenColors.FirstOrDefault(i => i.Color_Name == EditColorListView.SelectedItems[0].Text));
                EditColorListView.Items.Remove(EditColorListView.SelectedItems[0]);
            }
        }

        private void AddMaterialButton_Click(object sender, EventArgs e)
        {
            Material selectedMaterial = AddMaterialComboBox.SelectedItem as Material;
            if (!ChosenMaterials.Contains(selectedMaterial))
            {
                ChosenMaterials.Add(selectedMaterial);
                EditMaterialListView.Items.Add(selectedMaterial.MaterialName);
            }
        }

        private void RemoveMaterialButton_Click(object sender, EventArgs e)
        {
            if (EditMaterialListView.SelectedItems.Count > 0)
            {
                ChosenMaterials.Remove(ChosenMaterials.FirstOrDefault(i => i.MaterialName == EditMaterialListView.SelectedItems[0].Text));
                EditMaterialListView.Items.Remove(EditMaterialListView.SelectedItems[0]);
            }
        }

        private void RemoveGripButton_Click(object sender, EventArgs e)
        {
            if (EditGripListView.SelectedItems.Count > 0)
            {
                ChosenGrips.Remove(ChosenGrips.FirstOrDefault(i => i.Grip_Name == EditGripListView.SelectedItems[0].Text));
                EditGripListView.Items.Remove(EditGripListView.SelectedItems[0]);
            }
        }

        private void AddGripButton_Click(object sender, EventArgs e)
        {
            Grip selectedGrip = AddGripComboBox.SelectedItem as Grip;
            if (!ChosenGrips.Contains(selectedGrip))
            {
                ChosenGrips.Add(selectedGrip);
                EditGripListView.Items.Add(selectedGrip.Grip_Name);
            }
        }

        private void SaveVareButton_Click(object sender, EventArgs e)
        {
            SaveVareInfo();
        }

        private void UdskrivTilTxtButton_Click(object sender, EventArgs e)
        {
            WriteProductsToTextFile(FiltreretVareListe);
        }

    }
}