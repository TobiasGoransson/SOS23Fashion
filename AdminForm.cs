using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSFashion
{
    public partial class AdminForm : Form
    {
        List<Item> items = new List<Item>();
        string itemsFilePath = "Items/Items.csv";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void roductlistLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public List<Item> GetItemList()
        {
            using (StreamReader reader = new StreamReader(itemsFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        string[] strings = line.Split(";");
                        string name = strings[0];
                        int price = Convert.ToInt32(strings[1]);
                        int amountStock = Convert.ToInt32(strings[2]);
                        string size = strings[3];
                        string color = strings[4];
                        int amountSold = Convert.ToInt32(strings[5]);


                        items.Add(new Item(name, price, amountStock, size, color, amountSold));
                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return items;
        }

        private void pantsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerNewUserPanel.BringToFront();
        }

        private void confirmRegisterNewUserButton_Click(object sender, EventArgs e)
        {

            string size;
            string ItemName = itemTextBox.Text;
            int Price = Convert.ToInt32(priceTextBox.Text);
            int Quantity = Convert.ToInt32(quantityTextBox.Text);   
            string Color = colorTextBox.Text;
            string Category = quantityTextBox.Text;
            if (OneSize()  == true)
            {
                size = "One Size";

            }
        }
        public bool OneSize()
        {
            
            if (oneSizeCheckBox.Checked)
            {
                smallCheckBox.Hide();
                mediumCheckBox.Hide();
                LargeCheckBox.Hide();

                return true;
            }
            return false;
        }
    }
}
