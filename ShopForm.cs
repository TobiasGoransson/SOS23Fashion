using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSFashion
{
    public partial class ShopForm : Form
    {
        UserManager UserManager = new UserManager();
        bool kundvagn = false;
        string size = string.Empty;
        string itemsFilePath = "Items/Items.csv";
        List<Item> itemsList = new List<Item>();
        List<Item> kundvagnList = new List<Item>();
        MainForm mainForm;
        public ShopForm(MainForm mainForm)
        {
            InitializeComponent();
            HidePanels();
            this.mainForm = mainForm;
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
                        string category = strings[6];


                        itemsList.Add(new Item(name, price, amountStock, size, color, amountSold, category));
                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        private void removeKundvagnButton_Click(object sender, EventArgs e)
        {
            if (kundvagnListBox.SelectedItem != null)
            {
                string listBoxToString = kundvagnListBox.SelectedItem.ToString();
                foreach (Item item in kundvagnList)
                {
                    string kundvagnItemToString = item.ItemName + " STL " + item.Size + " " + "Price: " + item.Price + "kr";
                    if (listBoxToString == kundvagnItemToString)
                    {
                        kundvagnList.Remove(item);
                        kundvagnListBox.Items.Remove(kundvagnListBox.SelectedItem);
                        UpdateTotalCostLabel();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Du måste välja en vara i kundvagen först!");
            }
        }
        private void AddToCart(string str)
        {
            string shoeName = str;
            if (size == string.Empty)
            {
                MessageBox.Show("Du måste välja en storlek först!");
            }
            else
            {
                foreach (Item item in itemsList)
                {
                    if (item.ItemName == shoeName)
                    {
                        if (item.Size == size)
                        {
                            kundvagnListBox.Items.Add(item.ItemName + " STL " + item.Size + " " + "Price: " + item.Price + "kr");
                            kundvagnList.Add(item);
                            UpdateTotalCostLabel();
                            break;
                        }
                    }
                }
            }
            size = string.Empty;
        }

        public void GetItem(string ItemName) 
        {
            foreach (Item item in itemsList)
            {
                if (item.ItemName == ItemName)
                {
                    if (item.Size == size)
                    {
                       LinkLabelLinkClickedEventArgs.text = "Price" + item.Price;
                        break;
                    }
                }
            }

        }

        private void UpdateTotalCostLabel()
        {
            int totalCost = CalculateTotalCost();

            totalcostlabel.Text = $"Total Cost: {totalCost} kr";
        }

        private int CalculateTotalCost()
        {
            int totalCost = 0;
            foreach (Item item in kundvagnList)
            {
                totalCost += item.Price;
            }
            return totalCost;
        }


        private void HidePanels()
        {
            capPanel.Hide();
            vestPanel.Hide();
            blazerPanel.Hide();
            pantsPanel.Hide();
            shirtPanel.Hide();
            dressPanel.Hide();
            hatPanel.Hide();
            coatPanel.Hide();
            shoePanel.Hide();
        }

        private void capLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            capPanel.Show();
        }

        private void vestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            vestPanel.Show();
        }

        private void blazerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            blazerPanel.Show();
        }

        private void pantsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            pantsPanel.Show();
        }

        private void shirtsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            shirtPanel.Show();
        }

        private void dressLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            dressPanel.Show();
        }

        private void hatsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            hatPanel.Show();
        }

        private void coatsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            coatPanel.Show();
        }

        private void shoesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePanels();
            shoePanel.Show();
        }

        private void SizeButton36_Click(object sender, EventArgs e)
        {
            SizeButton36.BackColor = Color.Olive;
            SizeButton37.BackColor = Color.White;
            SizeButton38.BackColor = Color.White;
            size = "S";
        }

        private void SizeButton37_Click(object sender, EventArgs e)
        {
            SizeButton37.BackColor = Color.Olive;
            SizeButton36.BackColor = Color.White;
            SizeButton38.BackColor = Color.White;
            size = "M";
        }

        private void SizeButton38_Click(object sender, EventArgs e)
        {
            SizeButton38.BackColor = Color.Olive;
            SizeButton37.BackColor = Color.White;
            SizeButton36.BackColor = Color.White;
            size = "L";
        }

        private void greyShoeAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Short-Heel Shoe";
            AddToCart(choice);
        }

        private void kundvagnButton_Click(object sender, EventArgs e)
        {
            if (kundvagn == false)
            {
                kundvagnListBox.Show();
                kundvagn = true;
            }
            else if (kundvagn == true)
            {
                kundvagnListBox.Hide();
                kundvagn = false;
            }
        }



        private void sGreyDressButton_Click(object sender, EventArgs e)
        {
            sGreyDressButton.BackColor = Color.Olive;
            mGreyDressButton.BackColor = Color.White;
            lGreyDressButton.BackColor = Color.White;
            size = "S";
        }

        private void mGreyDressButton_Click(object sender, EventArgs e)
        {
            mGreyDressButton.BackColor = Color.Olive;
            sGreyDressButton.BackColor = Color.White;
            lGreyDressButton.BackColor = Color.White;
            size = "M";
        }

        private void lGreyDressButton_Click(object sender, EventArgs e)
        {
            lGreyDressButton.BackColor = Color.Olive;
            mGreyDressButton.BackColor = Color.White;
            sGreyDressButton.BackColor = Color.White;
            size = "L";
        }

        private void greyDressAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Dress";
            AddToCart(choice);
        }

        private void sWhiteShirtButton_Click(object sender, EventArgs e)
        {
            sWhiteShirtButton.BackColor = Color.Olive;
            mWhiteShirtButton.BackColor = Color.White;
            lWhiteShirtButton.BackColor = Color.White;
            size = "S";
        }

        private void mWhiteShirtButton_Click(object sender, EventArgs e)
        {
            mWhiteShirtButton.BackColor = Color.Olive;
            sWhiteShirtButton.BackColor = Color.White;
            lWhiteShirtButton.BackColor = Color.White;
            size = "M";
        }

        private void LWhiteShirtButton_Click(object sender, EventArgs e)
        {
            lWhiteShirtButton.BackColor = Color.Olive;
            mWhiteShirtButton.BackColor = Color.White;
            sWhiteShirtButton.BackColor = Color.White;
            size = "L";
        }

        private void whiteShirtAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Shirt";
            AddToCart(choice);
        }

        private void sNavyPantsButton_Click(object sender, EventArgs e)
        {
            sNavyPantsButton.BackColor = Color.Olive;
            mNavyPantsButton.BackColor = Color.White;
            lNavyPantsButton.BackColor = Color.White;
            size = "S";
        }

        private void mNavyPantsButton_Click(object sender, EventArgs e)
        {
            mNavyPantsButton.BackColor = Color.Olive;
            sNavyPantsButton.BackColor = Color.White;
            lNavyPantsButton.BackColor = Color.White;
            size = "M";
        }

        private void lNavyPantsButton_Click(object sender, EventArgs e)
        {
            lNavyPantsButton.BackColor = Color.Olive;
            mNavyPantsButton.BackColor = Color.White;
            sNavyPantsButton.BackColor = Color.White;
            size = "L";
        }

        private void sGreyPantsButton_Click(object sender, EventArgs e)
        {
            sGreyPantsButton.BackColor = Color.Olive;
            mGreyPantsButton.BackColor = Color.White;
            lGreyPantsButton.BackColor = Color.White;
            size = "S";
        }

        private void mGreyPantsButton_Click(object sender, EventArgs e)
        {
            mGreyPantsButton.BackColor = Color.Olive;
            sGreyPantsButton.BackColor = Color.White;
            lGreyPantsButton.BackColor = Color.White;
            size = "M";
        }

        private void lGreyPantsButton_Click(object sender, EventArgs e)
        {
            lGreyPantsButton.BackColor = Color.Olive;
            mGreyPantsButton.BackColor = Color.White;
            sGreyPantsButton.BackColor = Color.White;
            size = "L";
        }

        private void navyPantsAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Navy Suit-Pants";
            AddToCart(choice);
        }

        private void greyPantsAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Grey Suit-Pants";
            AddToCart(choice);
        }

        private void sNavyBlazerButton_Click(object sender, EventArgs e)
        {
            sNavyBlazerButton.BackColor = Color.Olive;
            mNavyBlazerButton.BackColor = Color.White;
            lNavyBlazerButton.BackColor = Color.White;
            size = "S";
        }

        private void mNavyBlazerButton_Click(object sender, EventArgs e)
        {
            mNavyBlazerButton.BackColor = Color.Olive;
            sNavyBlazerButton.BackColor = Color.White;
            lNavyBlazerButton.BackColor = Color.White;
            size = "M";
        }

        private void lNavyBlazerButton_Click(object sender, EventArgs e)
        {
            lNavyBlazerButton.BackColor = Color.Olive;
            mNavyBlazerButton.BackColor = Color.White;
            sNavyBlazerButton.BackColor = Color.White;
            size = "L";
        }

        private void navyBlazerAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Navy Blazer";
            AddToCart(choice);
        }

        private void sGreyBlazerButton_Click(object sender, EventArgs e)
        {
            sGreyBlazerButton.BackColor = Color.Olive;
            mGreyBlazerButton.BackColor = Color.White;
            lGreyBlazerButton.BackColor = Color.White;
            size = "S";
        }

        private void mGreyBlazerButton_Click(object sender, EventArgs e)
        {
            mGreyBlazerButton.BackColor = Color.Olive;
            sGreyBlazerButton.BackColor = Color.White;
            lGreyBlazerButton.BackColor = Color.White;
            size = "M";
        }

        private void lGreyBlazerButton_Click(object sender, EventArgs e)
        {
            lGreyBlazerButton.BackColor = Color.Olive;
            mGreyBlazerButton.BackColor = Color.White;
            sGreyBlazerButton.BackColor = Color.White;
            size = "L";
        }

        private void greyBlazerAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Grey Blazer";
            AddToCart(choice);
        }

        private void sNavyVestButton_Click(object sender, EventArgs e)
        {
            sNavyVestButton.BackColor = Color.Olive;
            mNavyVestButton.BackColor = Color.White;
            lNavyVestButton.BackColor = Color.White;
            size = "S";
        }

        private void mNavyVestButton_Click(object sender, EventArgs e)
        {
            mNavyVestButton.BackColor = Color.Olive;
            sNavyVestButton.BackColor = Color.White;
            lNavyVestButton.BackColor = Color.White;
            size = "M";
        }

        private void lNavyVestButton_Click(object sender, EventArgs e)
        {
            lNavyVestButton.BackColor = Color.Olive;
            mNavyVestButton.BackColor = Color.White;
            sNavyVestButton.BackColor = Color.White;
            size = "L";
        }

        private void sGreyVestButton_Click(object sender, EventArgs e)
        {
            sGreyVestButton.BackColor = Color.Olive;
            mGreyVestButton.BackColor = Color.White;
            lGreyVestButton.BackColor = Color.White;
            size = "S";
        }

        private void mGreyVestButton_Click(object sender, EventArgs e)
        {
            mGreyVestButton.BackColor = Color.Olive;
            sGreyVestButton.BackColor = Color.White;
            lGreyVestButton.BackColor = Color.White;
            size = "M";
        }

        private void lGreyVestButton_Click(object sender, EventArgs e)
        {
            lNavyVestButton.BackColor = Color.Olive;
            mNavyVestButton.BackColor = Color.White;
            sNavyVestButton.BackColor = Color.White;
            size = "L";
        }

        private void navyVestAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Navy Vest";
            AddToCart(choice);
        }

        private void greyVestAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Grey Vest";
            AddToCart(choice);
        }

        private void brownCapAddButton_Click(object sender, EventArgs e)
        {
            size = "One size";
            string choice = "Brown Cap";
            AddToCart(choice);
        }

        private void blackCapAddButton_Click(object sender, EventArgs e)
        {
            size = "One size";
            string choice = "Black Cap";
            AddToCart(choice);
        }

        private void sNavyCoatButton_Click(object sender, EventArgs e)
        {
            sNavyCoatButton.BackColor = Color.Olive;
            mNavyCoatButton.BackColor = Color.White;
            lNavyCoatButton.BackColor = Color.White;
            size = "S";
        }

        private void mNavyCoatButton_Click(object sender, EventArgs e)
        {
            mNavyCoatButton.BackColor = Color.Olive;
            sNavyCoatButton.BackColor = Color.White;
            lNavyCoatButton.BackColor = Color.White;
            size = "M";
        }

        private void lNavyCoatButton_Click(object sender, EventArgs e)
        {
            lNavyCoatButton.BackColor = Color.Olive;
            mNavyCoatButton.BackColor = Color.White;
            sNavyCoatButton.BackColor = Color.White;
            size = "L";
        }

        private void sBlackFurCoatButton_Click(object sender, EventArgs e)
        {
            sBlackFurCoatButton.BackColor = Color.Olive;
            sBlackFurCoatButton.BackColor = Color.White;
            sBlackFurCoatButton.BackColor = Color.White;
            size = "S";
        }

        private void mBlackFurCoatButton_Click(object sender, EventArgs e)
        {
            mBlackFurCoatButton.BackColor = Color.Olive;
            sBlackFurCoatButton.BackColor = Color.White;
            lBlackFurCoatButton.BackColor = Color.White;
            size = "M";
        }

        private void lBlackFurCoatButton_Click(object sender, EventArgs e)
        {
            lBlackFurCoatButton.BackColor = Color.Olive;
            mBlackFurCoatButton.BackColor = Color.White;
            sBlackFurCoatButton.BackColor = Color.White;
            size = "L";
        }

        private void navyCoatAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Navy Coat";
            AddToCart(choice);
        }

        private void blackFurCoatAddButton_Click(object sender, EventArgs e)
        {
            string choice = "Black Fur Coat";
            AddToCart(choice);
        }

        private void blackHatAddButton_Click(object sender, EventArgs e)
        {
            size = "One size";
            string choice = "Black Hat";
            AddToCart(choice);
        }

        private void greyWomanCapAddButton_Click(object sender, EventArgs e)
        {
            size = "One size";
            string choice = "Women Cap";
            AddToCart(choice);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (logInButton.Text == "Log In")
            {
                LogInForm logInForm = new LogInForm(mainForm);
                logInForm.Show();
                this.Close();
            }
            else
            {
                List<User> users = UserManager.CreateUserList();

                foreach (User user in users)
                {
                    if (user.UserName == logInButton.Text)
                    {
                        this.Hide();
                        UserPage userPage = new UserPage(user, mainForm);
                        userPage.Show();
                    }
                }
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logOutButton.Hide();
            logInButton.Text = "Log In";
            MainForm mainForm = new MainForm();
            mainForm.mainLogInButton.Text = "Log In";
            mainForm.logOutButton.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}
