using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class MainForm : Form
    {
        User User { get; set; }
        UserManager userManager = new UserManager();
        public MainForm()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile("Pics/EnLL5-EXMAABrTn.jpg");
            button1.Image = Image.FromFile("Pics/Assortment.png");
        }


        public void mainLogInButton_Click(object sender, EventArgs e)
        {
            if (mainLogInButton.Text == "Log In")
            {
                this.Hide();
                LogInForm logInForm = new LogInForm();
                logInForm.Show();
            }
            else
            {
                List<User> users = userManager.CreateUserList();

                foreach (User user in users)
                {
                    if (user.UserName == mainLogInButton.Text)
                    {
                        this.Hide();
                        UserPage userPage = new UserPage(user);
                        userPage.Show();
                    }
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logOutButton.Hide();
            mainLogInButton.Text = "Log In";
        }
    }
}
