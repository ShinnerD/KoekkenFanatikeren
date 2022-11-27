using DataManagement.Model;
using DataManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF_UserInterface
{
    /// <summary>
    /// /teori Test
    /// </summary>
    public partial class KundeModulForm : Form
    {
        public List<Kunde> KundeListe { get; set; }
        public Kunde ValgteKunde { get; set; }
        public List<Order> ValgteKundeOrders { get; set; }

        public KundeModulForm()
        {
            InitializeComponent();
            KundeListe = new KundeService().GetAllKunder();
            KundeListeGridView.AutoGenerateColumns = false;
            KundeListeGridView.DataSource = KundeListe;
            KundeListeGridView.Rows[0].Selected = true;
            UpdateCustomerInfo();
        }

        private void LockProgram()
        {
            Application.Restart();
        }

        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void UpdateCustomerInfo()
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

        private void KundeListeGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateCustomerInfo();
        }
    }
}
