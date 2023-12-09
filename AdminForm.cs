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
        public bool CheckVariebles(string Category, string ItemName, string Color)
        {
            if (string.IsNullOrWhiteSpace(ItemName))
            {
                MessageBox.Show("Item Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            else if (string.IsNullOrWhiteSpace(Color))
            {
                MessageBox.Show("Color cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(Category))
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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
            double Price;
            int Quantity = 0;
            string Color = colorTextBox.Text;
            bool allBoxesChecked = false;

           
            allBoxesChecked = CheckVariebles(Category, ItemName, Color);
            try
            {
                Price = Convert.ToInt32(priceTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Price. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (allBoxesChecked)
            {

                if (OneSize() || smallCheckBox.Checked || mediumCheckBox.Checked || LargeCheckBox.Checked)
                {
                    RegisterItem(ItemName, Price, Quantity, Color, Category);
                    allBoxesChecked = true;
                }
                else
                {
                    MessageBox.Show("Please select a size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }               
        }
        public void RegisterItem(string ItemName, double Price, int Quantity, string Color, string Category)
        {
            string Size;

            if (OneSize() == true)
            {
                Size = "One Size";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
            }
            if (smallCheckBox.Checked)
            {
                oneSizeCheckBox.Checked = false;
                Size = "S";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
            }
            if (mediumCheckBox.Checked)
            {
                oneSizeCheckBox.Checked = false;
                Size = "M";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
            }
            if (LargeCheckBox.Checked)
            {
                oneSizeCheckBox.Checked = false;
                Size = "L";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);
            }
        }
        public bool OneSize()
        {

            if (oneSizeCheckBox.Checked)
            {
                smallCheckBox.Checked = false;
                mediumCheckBox.Checked = false;
                LargeCheckBox.Checked = false;
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
