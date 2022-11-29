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
        public List<Order> ValgteKundeOrders { get; set; }

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
    }
}