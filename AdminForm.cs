using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using CheckBox = System.Windows.Forms.CheckBox;

namespace SOSFashion
{
    public partial class AdminForm : Form
    {


        UserManager UserManager = new UserManager();
        OrderManager orderManager = new OrderManager();
        ItemManager ItemManager = new ItemManager();
        List<Item> items = new List<Item>();
        string itemsFilePath = "Items/Items.csv";
        private List<CheckBox> checkBoxes;
        public AdminForm()
        {
            InitializeComponent();
            checkBoxes = new List<CheckBox> { hatCheckBox, coatsCheckBox, dressesCheckBox, suitsCheckBox, accessoriesCheckBox };
            mainPanel.Visible = false;
            registerNewItemPanel.Visible = false;
            editItemPanel.Visible = false;
            removeButton.Visible = false;
            editItemButton.Visible = false;
            stockUpButton.Visible = false;
            stockUpPanel.Visible = false;


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
                if (pictureBox1 != null)
                {
                    SaveImage2();
                }

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
        public async void RegisterItem(string ItemName, double Price, int Quantity, string Color, string Category)
        {
            string Size;

            if (OneSize() == true)
            {
                Size = "One Size";

                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                PopulateStockUpNewItem(ItemName, Price, Quantity, Size, Color, Category);
                stockUpPanel.Visible = true;

            }
            if (smallCheckBox.Checked)
            {
                oneSizeCheckBox.Checked = false;
                Size = "S";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                PopulateStockUpNewItem(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);

            }
            if (mediumCheckBox.Checked)
            {
                oneSizeCheckBox.Checked = false;
                Size = "M";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                PopulateStockUpNewItem(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);

            }
            if (LargeCheckBox.Checked)
            {
                oneSizeCheckBox.Checked = false;
                Size = "L";
                Item item = new Item(ItemName, Price, Quantity, Size, Color, Category);
                PopulateStockUpNewItem(ItemName, Price, Quantity, Size, Color, Category);
                ItemManager.RegisterNewItem(item);

            }
        }
        public void PopulateStockUpNewItem(string ItemName, double Price, int Quantity, string Size, string Color, string Category)
        {
            stockUpItemNameTextBox.Text = ItemName;
            stockUpPricetextBox.Text = Price.ToString();
            stockUpSizetextBox.Text = Size;
            stockUpColortextBox.Text = Color;
            stockUpCategorytextBox.Text = Category;
            stockUpQuantitytextBox.Text = Quantity.ToString();
        }
        public bool OneSize()
        {

            if (oneSizeCheckBox.Checked)
            {
                smallCheckBox.Checked = false;
                mediumCheckBox.Checked = false;
                LargeCheckBox.Checked = false;
                smallCheckBox.Visible = false;
                mediumCheckBox.Visible = false;
                LargeCheckBox.Visible = false;

                return true;
            }
            if (oneSizeCheckBox.Checked == false)
            {
                smallCheckBox.Visible = true;
                mediumCheckBox.Visible = true;
                LargeCheckBox.Visible = true;

            }
            return false;
        }

        private void registerNewItemkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            removeButton.Visible = false;
            editItemButton.Visible = false;
            mainPanel.Visible = false;
            stockUpButton.Visible = false;
            registerNewItemPanel.Visible = true;
            registerNewItemPanel.BringToFront();
        }

        private void oneSizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OneSize();
        }

        private void productlistLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminListBox1.Items.Clear();
            registerNewItemPanel.Visible = false;
            removeButton.Visible = true;
            editItemButton.Visible = true;
            stockUpButton.Visible = true;
            mainPanel.Visible = true;
            mainPanel.BringToFront();
            PopulateListBoxItem();
        }
        public void PopulateListBoxItem()
        {
            List<Item> items = ItemManager.GetItemList();
            foreach (Item item in items)
            {

                double price = item.Price; price.ToString();
                int quantity = item.Quantity; quantity.ToString();
                int soldtotal = item.SoldTotal; soldtotal.ToString();

                adminListBox1.Items.Add(item.ItemName + "\t" + price + "\t" + quantity + "\t" + item.Size + "\t" + item.Color + "\t" + soldtotal + "\t" + item.Category);
            }
        }
        private void placedOrdersLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminListBox1.Items.Clear();
            registerNewItemPanel.Visible = false;
            removeButton.Visible = false;
            editItemButton.Visible = false;
            stockUpButton.Visible = false;
            mainPanel.Visible = true;
            mainPanel.BringToFront();
            List<Order> orders = orderManager.GetOrders("AllOrders");
            foreach (Order order in orders)
            {
                int orderNo = order.OrderNo;
                orderNo.ToString();
                DateTime dateTime = order.Placedtime;
                dateTime.ToString();

                adminListBox1.Items.Add(orderNo + "\t" + dateTime + "\t" + order.Username);
            }
        }

        private void costumorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            registerNewItemPanel.Visible = false;
            mainPanel.Visible = true;
            removeButton.Visible = true;
            editItemButton.Visible = false;
            stockUpButton.Visible = false;
            mainPanel.BringToFront();
            PopulateListBoxUser();
        }
        public void PopulateListBoxUser()
        {
            List<User> users = UserManager.CreateUserList();
            adminListBox1.Items.Clear();
            adminListBox1.Refresh();
            foreach (User user in users)
            {
                adminListBox1.Items.Add(user.UserName + "\t" + user.Password + "\t" + user.FirstName + "\t" + user.LastName + "\t" + user.Email + "\t" + user.Street + "\t" + user.Zip + "\t" + user.City);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (adminListBox1.SelectedIndex != -1)
            {
                List<User> users = UserManager.CreateUserList();
                for (int i = 0; i < users.Count; i++)
                {
                    string user = users[i].UserName + "\t" + users[i].Password + "\t" + users[i].FirstName + "\t" + users[i].LastName + "\t" + users[i].Email + "\t" + users[i].Street + "\t" + users[i].Zip + "\t" + users[i].City;
                    if (adminListBox1.SelectedItem.ToString() == user)
                    {
                        UserManager.RemoveUser(i);
                        adminListBox1.Items.Clear();
                        PopulateListBoxUser();
                    }
                }

                List<Item> items = ItemManager.GetItemList();
                for (int i = 0; i < items.Count; i++)
                {
                    double price = items[i].Price; price.ToString();
                    int quantity = items[i].Quantity; quantity.ToString();
                    int soldtotal = items[i].SoldTotal; soldtotal.ToString();
                    string item = items[i].ItemName + "\t" + price + "\t" + quantity + "\t" + items[i].Size + "\t" + items[i].Color + "\t" + soldtotal + "\t" + items[i].Category;

                    if (adminListBox1.SelectedItem.ToString() == item)
                    {
                        ItemManager.RemoveItem(i);
                        adminListBox1.Items.Clear();
                        PopulateListBoxItem();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingen rad markerad.", "Meddelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PopulateEditItem(int index)
        {
            List<Item> items = ItemManager.GetItemList();
            for (int i = 0; i < items.Count; i++)
            {
                if (index == i)
                {
                    editItemNameTextBox.Text = items[i].ItemName;
                    editPriceTextBox.Text = items[i].Price.ToString();
                    editSizetextBox.Text = items[i].Size;
                    editIColorTextBox.Text = items[i].Color;
                    editCategoryTextBox.Text = items[i].Category;
                    quantityTextBox.Text = items[i].Quantity.ToString();
                    break;

                }
            }
        }

        private void editItemEditPanelButton_Click(object sender, EventArgs e)
        {

            string Size = editSizetextBox.Text;
            string ItemName = editItemNameTextBox.Text;
            double Price = double.Parse(editPriceTextBox.Text);
            int Quantity = int.Parse(quantityTextBox.Text);
            string Color = editIColorTextBox.Text;

            List<Item> items = ItemManager.GetItemList();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName == ItemName && items[i].Size == Size)
                {
                    items[i].Price = Price;
                    items[i].Quantity = Quantity;
                    items[i].Color = Color;

                    ItemManager.RemoveFilePath();
                    foreach (Item item in items)
                    {
                        ItemManager.RegisterNewItem(item);
                    }
                }
            }
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (adminListBox1.SelectedIndex != -1)
            {
                List<Item> items = ItemManager.GetItemList();
                for (int i = 0; i < items.Count; i++)
                {
                    double price = items[i].Price; price.ToString();
                    int quantity = items[i].Quantity; quantity.ToString();
                    int soldtotal = items[i].SoldTotal; soldtotal.ToString();
                    string item = items[i].ItemName + "\t" + price + "\t" + quantity + "\t" + items[i].Size + "\t" + items[i].Color + "\t" + soldtotal + "\t" + items[i].Category;

                    if (adminListBox1.SelectedItem.ToString() == item)
                    {
                        mainPanel.Visible = false;
                        removeButton.Visible = false;
                        editItemButton.Visible = false;
                        stockUpButton.Visible = false;
                        editItemPanel.Visible = true;
                        editItemPanel.BringToFront();
                        PopulateEditItem(i);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingen rad markerad.", "Meddelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void PopulateStockUp(int index)
        {
            List<Item> items = ItemManager.GetItemList();
            for (int i = 0; i < items.Count; i++)
            {
                if (index == i)
                {
                    stockUpItemNameTextBox.Text = items[i].ItemName;
                    stockUpPricetextBox.Text = items[i].Price.ToString();
                    stockUpSizetextBox.Text = items[i].Size;
                    stockUpColortextBox.Text = items[i].Color;
                    stockUpCategorytextBox.Text = items[i].Category;
                    stockUpQuantitytextBox.Text = items[i].Quantity.ToString();
                    break;

                }
            }
        }

        private void stockUpButton_Click(object sender, EventArgs e)
        {
            if (adminListBox1.SelectedIndex != -1)
            {
                List<Item> items = ItemManager.GetItemList();
                for (int i = 0; i < items.Count; i++)
                {
                    double price = items[i].Price; price.ToString();
                    int quantity = items[i].Quantity; quantity.ToString();
                    int soldtotal = items[i].SoldTotal; soldtotal.ToString();
                    string item = items[i].ItemName + "\t" + price + "\t" + quantity + "\t" + items[i].Size + "\t" + items[i].Color + "\t" + soldtotal + "\t" + items[i].Category;

                    if (adminListBox1.SelectedItem.ToString() == item)
                    {
                        mainPanel.Visible = false;
                        removeButton.Visible = false;
                        editItemButton.Visible = false;
                        stockUpButton.Visible = false;

                        PopulateStockUp(i);
                        stockUpPanel.Visible = true;
                        stockUpPanel.BringToFront();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingen rad markerad.", "Meddelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stockUpButtonStockupPanel_Click(object sender, EventArgs e)
        {
            string ItemName = stockUpItemNameTextBox.Text;
            double Price = double.Parse(stockUpPricetextBox.Text);
            string Size = stockUpSizetextBox.Text;
            string Color = stockUpColortextBox.Text;
            string Category = stockUpCategorytextBox.Text;
            int Quantity = int.Parse(stockUpQuantitytextBox.Text);
            int incomming = int.Parse(incommingQuantity.Text);
            int newQuantity = Quantity + incomming;
            List<Item> items = ItemManager.GetItemList();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName == ItemName && items[i].Size == Size)
                {
                    items[i].Quantity = newQuantity;
                    ItemManager.RemoveFilePath();
                    foreach (Item item in items)
                    {
                        ItemManager.RegisterNewItem(item);
                    }
                    break;
                }
            }

            incommingQuantity.Text = "";
            stockUpPanel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            editItemPanel.Visible = false;
            mainPanel.Visible = true;
            mainPanel.BringToFront();
            removeButton.Visible = true;
            editItemButton.Visible = true;
            stockUpButton.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stockUpPanel.Visible = false;
            mainPanel.Visible = true;
            mainPanel.BringToFront();
            removeButton.Visible = true;
            editItemButton.Visible = true;
            stockUpButton.Visible = true;
        }
        private void DisplayImage(string imagePath)
        {
            try
            {

                Image image = Image.FromFile(imagePath);
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                DisplayImage(imagePath);
            }
        }

        private void imageLable_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                DisplayImage(imagePath);
              
            }
        }

        private void SaveImage2()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save Image",
                Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|BMP Image|*.bmp|GIF Image|*.gif",
                DefaultExt = "png",
                AddExtension = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                SaveImage(savePath);
            }
        }

        private void SaveImage(string savePath)
        {
            try
            {
                // Check if there is an image loaded
                if (pictureBox1.Image != null)
                {
                    // Save the image to the specified path
                    pictureBox1.Image.Save(savePath);

                    MessageBox.Show($"Image saved to: {savePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No image loaded to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
