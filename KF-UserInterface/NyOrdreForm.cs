using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Windows.Forms;

namespace KF_UserInterface
{
    public partial class NyOrdreForm : Form
    {
        public List<Vare> VareListe { get; set; }
        public List<Vare> FiltreretVareListe { get; set; }
        public List<Varegruppe> VareGrupper { get; set; }

        public List<Employee> Employees { get; set; }

        public Order WorkingOrder { get; set; }
        public Kunde Customer { get; set; }

        public Vare ValgteVare { get; set; }
        public KitchenColor ChosenColor { get; set; }
        public Material ChosenMaterial { get; set; }
        public Grip ChosenGrip { get; set; }

        //Constructor
        public NyOrdreForm(Kunde customer)
        {
            InitializeComponent();

            try
            {
                Customer = customer;
                HeaderLabel.Text = "Ny Ordrer for " + Customer.FullName;
                SetupVareListe();
                SetupVaregruppeDropDown();
                SetupNewOrder();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Sets up a new Order in the Code Behind and fills in the properties we know already.
        /// </summary>
        private void SetupNewOrder()
        {
            WorkingOrder = new Order();
            WorkingOrder.OrderProducts = new List<Vare>();
            WorkingOrder.Kunde = Customer;
            WorkingOrder.CustomerId = Customer.KundeID;
            WorkingOrder.CreatedDate = DateTime.Now;
            WorkingOrder.DateOfSending = DateTime.Now;

            OrdreIndholdDataGrid.AutoGenerateColumns = false;

            FinalOrdreIndholdDataGrid.AutoGenerateColumns = false;

            Employees = new DataManagement.Service.EmployeeService().GetEmployees();
            EmployeeComboBox.DataSource = Employees;
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
            ColorChoiceContentLabel.Text = "Vælg en farve";
            MaterialChoiceContentLabel.Text = "Vælg et materiale";
            GripChoiceContentLabel.Text = "Vælg et greb";
            ProductCountChoiceTextBox.Text = "1";

            ChosenColor = null;
            ChosenGrip = null;
            ChosenMaterial = null;

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
        /// Adds the Vare to the Working Order Product List.
        /// </summary>
        private void AddVareToOrder()
        {
            Vare newAddVare = new Vare();
            newAddVare.Product_ID = ValgteVare.Product_ID;
            newAddVare.ProductName = ValgteVare.ProductName;
            newAddVare.ProductGroup_ID = ValgteVare.ProductGroup_ID;
            newAddVare.Price = ValgteVare.Price;
            newAddVare.Description = ValgteVare.Description;
            newAddVare.Length = ValgteVare.Length;
            newAddVare.Height = ValgteVare.Height;
            newAddVare.Width = ValgteVare.Width;
            newAddVare.Varegruppe = ValgteVare.Varegruppe;

            newAddVare.ChosenColor = ChosenColor;
            newAddVare.ChosenGrip = ChosenGrip;
            newAddVare.ChosenMaterial = ChosenMaterial;
            newAddVare.Count = int.Parse(ProductCountChoiceTextBox.Text);

            if (!WorkingOrder.OrderProducts.Contains(newAddVare))
            {
                WorkingOrder.OrderProducts.Add(newAddVare);
            }

            OrdreIndholdDataGrid.DataSource = null;
            OrdreIndholdDataGrid.DataSource = WorkingOrder.OrderProducts;
        }

        /// <summary>
        /// Checks that choices are valid for color, material, grip and product count.
        /// </summary>
        /// <returns></returns>
        private bool ValidateVareChoices()
        {
            if (ChosenColor == null || ChosenGrip == null || ChosenMaterial == null || ProductCountChoiceTextBox.Text == string.Empty
                || !int.TryParse(ProductCountChoiceTextBox.Text, out int productCount))
            {
                return false;
            }
            else { return true; }
        }

        /// <summary>
        /// Finalizes the Order by Filling the remaining properties from the adress text boxes
        /// and employee drop down list. Saves the order to the database via the OrderService Class.
        /// </summary>
        private void SaveOrder()
        {
            WorkingOrder.Employee = EmployeeComboBox.SelectedItem as Employee;
            WorkingOrder.EmployeeId = WorkingOrder.Employee.EmployeeID;
            WorkingOrder.To_FirstName = FirstnameTextBox.Text;
            WorkingOrder.To_LastName = LastnameTextBox.Text;
            WorkingOrder.To_PhoneNumber = int.Parse(TelefonTextBox.Text);
            WorkingOrder.To_Street = StreetNameTextBox.Text;
            WorkingOrder.To_City = CityTextBox.Text;
            WorkingOrder.To_ZipCode = int.Parse(ZipCodeTextBox.Text);

            new DataManagement.Service.OrderService().SaveOrder(WorkingOrder);
            this.Close();
        }

        /// <summary>
        /// Goes to the final panel for filling in delivery adress if different from customer adress.
        /// </summary>
        private void GoToFinalOrderPanel()
        {
            FinalOrderPanel.BringToFront();
            ProgressOrderButton.Text = "Gem Ordre";
            RemoveOrderVareButton.Visible = false;
            TotalPriceContentLabel.Text = WorkingOrder.GetTotalPrice().ToString();
            FinalOrdreIndholdDataGrid.DataSource = WorkingOrder.OrderProducts;

            FirstnameTextBox.Text = Customer.FirstName;
            LastnameTextBox.Text = Customer.LastName;
            TelefonTextBox.Text = Customer.PhoneNumber.ToString();
            EmailTextBox.Text = Customer.Email;
            StreetNameTextBox.Text = Customer.Street;
            CityTextBox.Text = Customer.City;
            ZipCodeTextBox.Text = Customer.Zipcode.ToString();
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

        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
            if (FarverListView.SelectedItems.Count > 0)
            {
                ChosenColor = ValgteVare.AvailableColors.FirstOrDefault(i => i.Color_Name == FarverListView.SelectedItems[0].Text);
                ColorChoiceContentLabel.Text = ChosenColor.Color_Name;
            }
        }

        private void ChooseMaterialButton_Click(object sender, EventArgs e)
        {
            if (MaterialerListView.SelectedItems.Count > 0)
            {
                ChosenMaterial = ValgteVare.AvailableMaterials.FirstOrDefault(i => i.MaterialName == MaterialerListView.SelectedItems[0].Text);
                MaterialChoiceContentLabel.Text = ChosenMaterial.MaterialName;
            }
        }

        private void ChooseGripButton_Click(object sender, EventArgs e)
        {
            if (GrebListView.SelectedItems.Count > 0)
            {
                ChosenGrip = ValgteVare.AvailableGrips.FirstOrDefault(i => i.Grip_Name == GrebListView.SelectedItems[0].Text);
                GripChoiceContentLabel.Text = ChosenGrip.Grip_Name;
            }
        }

        private void ProductCountChoiceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NyVareButton_Click(object sender, EventArgs e)
        {
            if (ValidateVareChoices())
            {
                AddVareToOrder();
            }
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            if (CancelOrderButton.Text == "Anuller")
            {
                this.Close();
            }
            if (CancelOrderButton.Text == "Tilbage")
            {
                MainPanel.BringToFront();
                CancelOrderButton.Text = "Anuller";
                RemoveOrderVareButton.Visible = true;
            }
        }

        private void RemoveOrderVareButton_Click(object sender, EventArgs e)
        {
            if (OrdreIndholdDataGrid.SelectedRows.Count > 0)
            {
                Vare deletedVare = OrdreIndholdDataGrid.SelectedRows[0].DataBoundItem as Vare;
                WorkingOrder.OrderProducts.Remove(deletedVare);
                OrdreIndholdDataGrid.DataSource = null;
                OrdreIndholdDataGrid.DataSource = WorkingOrder.OrderProducts;
            }
        }

        private void ProgressOrderButton_Click(object sender, EventArgs e)
        {
            if (ProgressOrderButton.Text == "Gem Ordre" && WorkingOrder.OrderProducts.Count > 0 && EmployeeComboBox.SelectedIndex != -1
                && int.TryParse(TelefonTextBox.Text, out int result) && int.TryParse(ZipCodeTextBox.Text, out int zipResult)
                && FirstnameTextBox.Text != string.Empty && LastnameTextBox.Text != string.Empty && TelefonTextBox.Text != string.Empty 
                && StreetNameTextBox.Text != string.Empty && CityTextBox.Text != string.Empty && ZipCodeTextBox.Text != string.Empty)
            {
                SaveOrder();
            }
            if (ProgressOrderButton.Text == "Videre")
            {
                GoToFinalOrderPanel();
            }
        }

    }
}