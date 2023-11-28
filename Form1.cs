namespace SOSFashion
{
    public partial class Form1 : Form
    {
        UserManager userManager = new UserManager();
        public Form1()
        {
            InitializeComponent();
        }

        public User RegisterNewUser()
        {
            string UserName = registerUserNameTextBox.Text;
            string Password = registerPasswordTextBox.Text;
            string FirstName = registerFirstNameTextBox.Text;
            string LastName = registerLastNameTextBox.Text;
            string Email = registerEmailTextBox.Text;
            string Street = registerStreetTextBox.Text;
            string Zip = registerZipTextBox.Text;
            string City = registerCityTextBox.Text;


            User user = new User(UserName, Password, FirstName, LastName, Email, Street, Zip, City);
            return user;

        }

        private void registerNewUserButton_Click(object sender, EventArgs e)
        {
            registerNewUserPanel.BringToFront();

        }

        private void cancelRegisterNewUserButton_Click(object sender, EventArgs e)
        {
            LogInPanel.BringToFront();
        }

        private void confirmRegisterNewUserButton_Click(object sender, EventArgs e)
        {
            User user = RegisterNewUser();
            userManager.RegisterNewUser(user);
        }
    }
}