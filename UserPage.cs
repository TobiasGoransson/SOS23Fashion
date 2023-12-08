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
    public partial class UserPage : Form
    {
        UserManager userManager = new UserManager();
        OrderManager orderManager = new OrderManager();
        public MainForm mainForm;
        User User { get; set; }

        public UserPage(User user, MainForm mainForm)
        {
            InitializeComponent();
            this.User = user;
            PopulateUserPage(user);
            this.mainForm = mainForm;
        }


        public void PopulateUserPage(User user)
        {
            UserNameLable.Text = user.UserName;
            firstNameLable.Text = user.FirstName;
            lastNameLable.Text = user.LastName;
            emailLable.Text = user.Email;
            streetLable.Text = user.Street;
            zipLable.Text = user.Zip;
            cityLable.Text = user.City;

            List<Order> orders = orderManager.GetOrders(user.UserName);
            foreach (Order order in orders)
            {
                int orderNo = order.OrderNo;
                orderNo.ToString();
                DateTime dateTime = order.Placedtime;
                dateTime.ToString();

                OrderHistory.Items.Add(orderNo + "\t" + dateTime);
            }

        }

        private void showPasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordLable.Text = User.Password;
        }

        private void showPasswordButton_MouseLeave(object sender, EventArgs e)
        {
            passwordLable.Text = "****";
        }

        private void leaveUserPageButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.mainLogInButton.Text = User.UserName;
            mainForm.logOutButton.Show();
            ShopForm shopForm = new ShopForm(mainForm);
            shopForm.Show();
            shopForm.logInButton.Text = User.UserName;
            shopForm.logOutButton.Show();
        }

        private void OrderHistory_MouseDown(object sender, MouseEventArgs e)
        {
            int index = OrderHistory.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                OrderHistory.SelectedIndex = index;
                List<Order> orders = orderManager.GetOrders(User.UserName);
                for (int i = 0; i < orders.Count; i++)
                {
                    if (index == i)
                    {
                        List<Item> items = orderManager.GetItems(orders[i].OrderNo);
                    }
                }
            }

        }


    }
}
