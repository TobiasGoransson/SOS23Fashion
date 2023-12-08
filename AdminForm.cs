using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace SOSFashion
{
    public partial class AdminForm : Form
    {
        ItemManager ItemManager = new ItemManager();
        List<Item> items = new List<Item>();
        string itemsFilePath = "Items/Items.csv";
        private List<CheckBox> checkBoxes;
        public AdminForm()
        {
            InitializeComponent();
            checkBoxes = new List<CheckBox> { hatCheckBox, coatsCheckBox, dressesCheckBox, suitsCheckBox, accessoriesCheckBox };
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = sender as CheckBox;

            if (currentCheckBox.Checked)
            {
                foreach (var checkBox in checkBoxes)
                {
                    if (checkBox != currentCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        public string CheckCategory()
        {
            if (hatCheckBox.Checked) { return "Hat"; }
            else if (coatsCheckBox.Checked) { return "Coats"; }
            else if (dressesCheckBox.Checked) { return "Dresses"; }
            else if (suitsCheckBox.Checked) { return "Suits"; }
            else if (accessoriesCheckBox.Checked) { return "Accessories"; }
            return null;
        }
        private void confirmRegisterNewUserButton_Click(object sender, EventArgs e)
        {

            string Category = CheckCategory();
            string Size;
            string ItemName = itemTextBox.Text;
            double Price = Convert.ToInt32(priceTextBox.Text);
            int Quantity = 0;
            string Color = colorTextBox.Text;


            if (OneSize() == true)
            {
                Size = "One Size";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
            }
            if (smallCheckBox.Checked)
            {
                Size = "S";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
            }
            if (mediumCheckBox.Checked)
            {
                Size = "M";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
            }
            if (LargeCheckBox.Checked)
            {
                Size = "L";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
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
            if (oneSizeCheckBox.Checked == false)
            {
                smallCheckBox.Show();
                mediumCheckBox.Show();
                LargeCheckBox.Show();

            }
            return false;
        }

        private void registerNewItemkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerNewItemPanel.Show();
        }

        private void oneSizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OneSize();
        }
    }
}
