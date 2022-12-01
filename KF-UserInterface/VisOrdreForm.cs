using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Windows.Forms;

namespace KF_UserInterface
{
    public partial class VisOrdreForm : Form
    {
        public Order VisteOrder { get; set; }
        public Vare ValgteVare { get; set; }

        public VisOrdreForm(Order order)
        {
            InitializeComponent();

            try
            {
                VisteOrder = order;
                SetupOrderVareListe();
                SetupCustomerInfo();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SetupCustomerInfo()
        {
            OrdreIdContentLabel.Text = VisteOrder.Id.ToString();
            KundeContentLabel.Text = VisteOrder.To_FirstName + " " + VisteOrder.To_LastName;
            TlfContentLabel.Text = VisteOrder.To_PhoneNumber.ToString();
            AdresseContentLabel.Text = VisteOrder.To_Street + ", " + VisteOrder.To_City + ", " + VisteOrder.To_ZipCode.ToString();
            OrdreCommentTextBox.Text = VisteOrder.Order_Comment;
            EmployeeContentLabel.Text = VisteOrder.AnsvarligEmployeeName;
            TotalPrisContentLabel.Text = VisteOrder.GetTotalPrice().ToString();
        }

        /// <summary>
        /// Sets up the List that populates the VareDataGridView.
        /// </summary>
        private void SetupOrderVareListe()
        {
            VareListeDataGrid.AutoGenerateColumns = false;
            VareListeDataGrid.DataSource = VisteOrder.OrderProducts;
        }

        private void SetOrderProductDetailLabels()
        {
            ValgteVare = VareListeDataGrid.SelectedRows[0].DataBoundItem as Vare;

            NameContentLabel.Text = ValgteVare.ProductName;
            VareIdContentLabel.Text = ValgteVare.ProductGroup_ID.ToString();
            VareGruppeContentLabel.Text = ValgteVare.VaregruppeNavn;
            VarePrisContentLabel.Text = ValgteVare.Price.ToString();
            FarveContentLabel.Text = ValgteVare.ChosenColorString;
            GrebContentLabel.Text = ValgteVare.ChosenGripString;
            MaterialeContentLabel.Text = ValgteVare.ChosenMaterialString;

            VareBeskrivelseTxtBox.Text = ValgteVare.Description;
        }

        //Click Events For Buttons.
        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VareListeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetOrderProductDetailLabels();
        }

    }
}