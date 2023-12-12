using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSFashion
{
    public partial class Checkout : Form
    {

        OrderManager orderManager = new OrderManager();
        List<Item> kundvagnList = new List<Item>();
        public Checkout()
        {
            InitializeComponent();
            LoadShippingPaymentOptions();
            CalculateTotalCost();

        }

        private void LoadShippingPaymentOptions()
        {

            comboBoxShipping.Items.Add("Standard Shipping");
            comboBoxShipping.Items.Add("Express Shipping");

            comboBoxPayment.Items.Add("Credit Card");
            comboBoxPayment.Items.Add("PayPal");
        }

        private void CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (Item item in kundvagnList)
            {
                totalCost += item.Price;
            }
            totalCostLabel.Text = $"Total Cost: {totalCost} kr";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtFirstName.Text;
            string name2 = txtLastName.Text;
            string address = txtAddress.Text;
            string email = textEmail.Text;
            string zipCode = txtZipCode.Text;
            string phone = txtPhone.Text;


        }
    }
}
