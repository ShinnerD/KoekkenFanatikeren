using DataManagement.Model;
using DataManagement.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KF_UserInterface
{
    /// <summary>
    /// /teori Test
    /// </summary>
    public partial class SalgsStatistikForm : Form
    {
        public List<Order> AllKundeOrders { get; set; }
        public List<Order> FilteredKundeOrders { get; set; }
        public OrderService orderService = new OrderService();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalListValue { get; set; }

        //Constructor
        public SalgsStatistikForm()
        {
            InitializeComponent();
            try
            {
                SetupOrdreListe();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Initial Setip of the window.
        /// </summary>
        private void SetupOrdreListe()
        {
            AllKundeOrders = orderService.GetAllOrders();
            FilteredKundeOrders = AllKundeOrders;
            KundeOrdreGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Filters the orders from AllKundeOrders according to the dateTime pickers into FilteredKundeOrders
        /// and shows them in the dataGridView.
        /// </summary>
        private void FilterAndShowOrders()
        {
            StartDate = FromDateTimePicker.Value;
            EndDate = ToDateTimePicker.Value;

            FilteredKundeOrders = orderService.SortByDateDescending(orderService.FilterByDate(AllKundeOrders, StartDate, EndDate));
            KundeOrdreGridView.DataSource = null;
            KundeOrdreGridView.DataSource = FilteredKundeOrders;

            TotalListValue = CalculateTotalPriceOfList();
            TotalPriceContentLabel.Text = TotalListValue.ToString();
        }

        /// <summary>
        /// Calculates the sum price of all orders in the list.
        /// </summary>
        /// <returns></returns>
        private int CalculateTotalPriceOfList()
        {
            int result = 0;
            foreach (Order order in FilteredKundeOrders)
            {
                result += order.TotalPrice;
            }
            return result;
        }

        /// <summary>
        /// Writes the Current List Shown to a Text File in the Main Program Directory.
        /// </summary>
        private void WriteOrderListToTextFile()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("|===============================================================================|").AppendLine();
            stringBuilder.Append("|SALGSSTISTIK\t\tFra: ").Append(StartDate.ToString("dd-MM-yyyy")).Append("\t\tTil: ");
            stringBuilder.Append(EndDate.ToString("dd-MM-yyyy")).Append("\t\t\t|").AppendLine();
            stringBuilder.Append("|===============================================================================|").AppendLine();
            stringBuilder.Append("|Ordre Nr.\t|Kunde\t\t\t|Dato\t\t|Antal Vare\t|Værdi\t|").AppendLine();
            stringBuilder.Append("|===============================================================================|").AppendLine();

            foreach (Order order in FilteredKundeOrders)
            {
                stringBuilder.Append("|").Append(order.Id).Append("\t\t").Append("|");

                if (order.KundeName.Length <= 7)
                {
                    stringBuilder.Append(order.KundeName).Append("\t\t\t");
                }
                if (order.KundeName.Length >= 8 && order.KundeName.Length < 15)
                {
                    stringBuilder.Append(order.KundeName).Append("\t\t");
                }
                if (order.KundeName.Length >= 15 && order.KundeName.Length < 20)
                {
                    stringBuilder.Append(order.KundeName).Append("\t");
                }
                if (order.KundeName.Length >= 20)
                {
                    stringBuilder.Append(order.KundeName.Substring(0, 20)).Append("...\t");
                }

                stringBuilder.Append("|").Append(order.DateOfSending.ToString("dd-MM-yyyy")).Append("\t");
                stringBuilder.Append("|").Append(order.ProductCount).Append("\t\t|").Append(order.TotalPrice).Append("\t|").AppendLine();
            }

            stringBuilder.Append("|===============================================================================|").AppendLine();
            stringBuilder.Append("|Total Værdi i periode: ").Append(TotalListValue).Append("\t\t\t\t\t\t\t|").AppendLine();
            stringBuilder.Append("|===============================================================================|");

            File.WriteAllText("./OrdreListe " + StartDate.ToString("dd-MM-yy") + " til " + EndDate.ToString("dd-MM-yy") + ".txt", stringBuilder.ToString());
            MessageBox.Show("Indholdet i nuværende Ordre Liste er skrevet til text fil");
        }

        //Click Events for Buttons and Mouse.
        private void LukModulButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteToTextButton_Click(object sender, EventArgs e)
        {
            WriteOrderListToTextFile();
        }

        private void SearchDatesButton_Click(object sender, EventArgs e)
        {
            FilterAndShowOrders();
        }
    }
}