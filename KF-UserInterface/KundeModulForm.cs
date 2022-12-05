using DataManagement.Model;
using DataManagement.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KF_UserInterface
{
    /// <summary>
    /// /teori Test
    /// </summary>
    public partial class KundeModulForm : Form
    {
        public List<Kunde> KundeListe { get; set; }
        public List<Kunde> FiltreretKundeListe { get; set; }
        public Kunde ValgteKunde { get; set; }
        public Kunde EditedCustomer { get; set; }
        public List<Order> ValgteKundeOrders { get; set; }

        //Constructor
        public KundeModulForm()
        {
            InitializeComponent();
            try
            {
                SetupKundeListe();
                UpdateCustomerInfo();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Sets up the Kunde-liste at the start of the Form.
        /// Populates the Left side DataGridView.
        /// </summary>
        private void SetupKundeListe()
        {
            KundeListe = new KundeService().GetAllKunder();
            FiltreretKundeListe = KundeListe;
            KundeListeGridView.AutoGenerateColumns = false;
            KundeListeGridView.DataSource = FiltreretKundeListe;
            KundeListeGridView.Rows[0].Selected = true;
        }

        /// <summary>
        /// Resets application back to password screen.
        /// </summary>
        private void LockProgram()
        {
            Application.Restart();
        }

        /// <summary>
        /// Sets the Labels on the right side of the Window to Match the Kunde chosen in the Left DataGridView.
        /// Also updates the Right Side DataGridView with the chosen Kunde Orders.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                //Set pagewide ValgteKunde property to the chosen customer in the row.
                ValgteKunde = KundeListeGridView.SelectedRows[0].DataBoundItem as Kunde;

                //Set labels on the right side of the page to match customer values.
                NameContentLabel.Text = ValgteKunde.FirstName + " " + ValgteKunde.LastName;
                TlfContentLabel.Text = ValgteKunde.PhoneNumber.ToString();
                EmailContentLabel.Text = ValgteKunde.Email;
                AdresseContentLabel.Text = ValgteKunde.Street + " " + ValgteKunde.City + " " + ValgteKunde.Zipcode;

                //Get the orders for the specified customer and set the datagridview to display these.
                ValgteKundeOrders = new OrderService().GetCustomerOrders(ValgteKunde.KundeID);
                KundeOrdreGridView.AutoGenerateColumns = false;
                KundeOrdreGridView.DataSource = ValgteKundeOrders;

                Cursor = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Performs a Search and filtering of the List that Populates the Left DatagridView.
        /// Filters based on the input in the search box. Searches Kunde FullName, PhoneNumber and Email.
        /// </summary>
        private void PerformCustomerSearch()
        {
            if (SearchFieldTextBox.Text == "" || SearchFieldTextBox.Text == "Indtast navn, tlf nr eller email...")
            {
                FiltreretKundeListe = KundeListe;
                KundeListeGridView.DataSource = FiltreretKundeListe;
            }
            else
            {
                FiltreretKundeListe = KundeListe.Where(i => i.FullName.ToLower().Contains(SearchFieldTextBox.Text.ToLower())
                                                      || i.PhoneNumber.ToString().Contains(SearchFieldTextBox.Text.ToLower())
                                                      || i.Email.ToLower().Contains(SearchFieldTextBox.Text.ToLower())).ToList();
                KundeListeGridView.DataSource = FiltreretKundeListe;
            }
        }

        /// <summary>
        /// Clears the textboxes that populate the customer edit panel.
        /// </summary>
        private void ClearCustomerEditTextBoxes()
        {
            FirstnameTextBox.Text = string.Empty;
            LastnameTextBox.Text = string.Empty;
            TelefonTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            StreetNameTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            ZipCodeTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Sets up the TextBoxes in the Edit Customer Panel to represent the values of EditedCustomer.
        /// </summary>
        private void EditChosenCustomer()
        {
            EditCustomerPanel.BringToFront();
            NyKundeButton.Visible = false;

            FirstnameTextBox.Text = EditedCustomer.FirstName;
            LastnameTextBox.Text = EditedCustomer.LastName;
            TelefonTextBox.Text = EditedCustomer.PhoneNumber.ToString();
            EmailTextBox.Text = EditedCustomer.Email;
            StreetNameTextBox.Text = EditedCustomer.Street;
            CityTextBox.Text = EditedCustomer.City;
            ZipCodeTextBox.Text = EditedCustomer.Zipcode.ToString();
        }

        /// <summary>
        /// Verifies that all textboxes are filled. Checks that ZipCode and Phonenumber can be parsed as ints.
        /// Shows error label warning on failure. Saves or Updates Customer on success and brings you back to the customer list.
        /// </summary>
        private void VerifyFieldsAndUpdateCustomer()
        {
            int phoneNumber;
            int zipCode;

            if (!AllTextBoxesFilled() ||
                !int.TryParse(TelefonTextBox.Text, out phoneNumber) ||
                !int.TryParse(ZipCodeTextBox.Text, out zipCode)
                )
            {
                ErrorLabel.Visible = true;
                ErrorLabelTimer.Enabled = true;
            }
            else
            {
                EditedCustomer.FirstName = FirstnameTextBox.Text;
                EditedCustomer.LastName = LastnameTextBox.Text;
                EditedCustomer.PhoneNumber = phoneNumber;
                EditedCustomer.Email = EmailTextBox.Text;
                EditedCustomer.Street = StreetNameTextBox.Text;
                EditedCustomer.City = CityTextBox.Text;
                EditedCustomer.Zipcode = zipCode;

                if (EditedCustomer.KundeID == 0)
                {
                    new KundeService().SaveNewKunde(EditedCustomer);
                    SetupKundeListe();
                    UpdateCustomerInfo();
                    MainPanel.BringToFront();
                    NyKundeButton.Visible = true;
                }
                else
                {
                    new KundeService().EditKunde(EditedCustomer);
                    SetupKundeListe();
                    UpdateCustomerInfo();
                    MainPanel.BringToFront();
                    NyKundeButton.Visible = true;
                }
            }
        }

        /// <summary>
        /// Verifies that all textboxes are filled in the editcustomer panel.
        /// </summary>
        /// <returns></returns>
        private bool AllTextBoxesFilled()
        {
            if (FirstnameTextBox.Text != string.Empty || LastnameTextBox.Text != string.Empty || TelefonTextBox.Text != string.Empty
                || EmailTextBox.Text != string.Empty || StreetNameTextBox.Text != string.Empty || CityTextBox.Text != string.Empty
                || ZipCodeTextBox.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Timer which runs and shows the error label for 1 tick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ErrorLabelTimer_Tick(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            ErrorLabelTimer.Enabled = false;
        }

        //Click Events for Buttons and Mouse.
        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KundeListeGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateCustomerInfo();
        }

        private void SearchFieldTextBox_Click(object sender, EventArgs e)
        {
            if (SearchFieldTextBox.Text == "Indtast navn, tlf nr eller email...")
            {
                SearchFieldTextBox.Text = "";
            }
        }

        private void SearchFieldTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            PerformCustomerSearch();
        }

        private void VisOrdreButton_Click(object sender, EventArgs e)
        {
            if (KundeOrdreGridView.SelectedRows.Count > 0)
            {
                Order valgtOrder = KundeOrdreGridView.SelectedRows[0].DataBoundItem as Order;
                VisOrdreForm ordreVindue = new VisOrdreForm(valgtOrder);
                ordreVindue.Show();
            }
        }

        private void NyKundeButton_Click(object sender, EventArgs e)
        {
            EditedCustomer = new Kunde();
            EditChosenCustomer();
            ClearCustomerEditTextBoxes();
        }

        private void CancelCustomerEditButton_Click(object sender, EventArgs e)
        {
            ClearCustomerEditTextBoxes();
            MainPanel.BringToFront();
            NyKundeButton.Visible = true;
        }

        private void RedigerKundeButton_Click(object sender, EventArgs e)
        {
            EditedCustomer = ValgteKunde;
            EditChosenCustomer();
        }

        private void SaveCustomerButton_Click(object sender, EventArgs e)
        {
            VerifyFieldsAndUpdateCustomer();
        }
    }
}