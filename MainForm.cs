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
        public MainForm()
        {
            InitializeComponent();
        }

        private void AssortmentPanel_Click(object sender, EventArgs e)
        {

        }

        private void mainLogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }
    }
}
