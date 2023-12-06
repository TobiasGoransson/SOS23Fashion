using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSFashion
{
    public partial class ShopForm : Form
    {
        bool kundvagn = false;
        string size = string.Empty;
        string itemsFilePath = "Items/Items.csv";
        List<Item> itemsList = new List<Item>();
        List<Item> kundvagnList = new List<Item>();
        public ShopForm()
        {
            InitializeComponent();
            HidePanels();
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


                        itemsList.Add(new Item(name, price, amountStock, size, color, amountSold));
                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {

                    }
                }
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
                            kundvagnListBox.Items.Add(item.ItemName + " STL " + item.Size + item.Price + "kr");

                            UpdateTotalCostLabel();

                            kundvagnList.Add(item);
                            break;
                        }
                    }
                }
            }
            size = string.Empty;
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

        private void removeKundvagnButton_Click(object sender, EventArgs e)
        {
            if (kundvagnListBox.SelectedItem != null)
            {
                string listBoxToString = kundvagnListBox.SelectedItem.ToString();
                foreach (Item item in kundvagnList)
                {
                    string kundvagnItemToString = item.ItemName + " STL " + item.Size;
                    if (listBoxToString == kundvagnItemToString)
                    {
                        kundvagnList.Remove(item);
                        kundvagnListBox.Items.Remove(kundvagnListBox.SelectedItem);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Du måste välja en vara i kundvagen först!");
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
    }
}
