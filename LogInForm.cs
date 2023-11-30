namespace SOSFashion
{
    public partial class LogInForm : Form
    {
        UserManager userManager = new UserManager();
        public LogInForm()
        {
            InitializeComponent();
            LogInPanel.BringToFront();

        }

        public User RegisterNewUser()
        {
            newUserNameLable.Text = registerNewUserNameTextBox.Text;
            string UserName = registerNewUserNameTextBox.Text;
            string Password = registerNewPasswordTextBox.Text;
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
            chooseUserNamePasswordPanel.BringToFront();

        }

        private void cancelRegisterNewUserButton_Click(object sender, EventArgs e)
        {
            LogInPanel.BringToFront();
        }

        private void confirmRegisterNewUserButton_Click(object sender, EventArgs e)
        {
            User user = RegisterNewUser();
            userManager.RegisterNewUser(user);
            LogInPanel.BringToFront();

        }

        private void cancelRegisterUserButton_Click(object sender, EventArgs e)
        {
            LogInPanel.BringToFront();
        }

        private void registerUserPasswordButton_Click(object sender, EventArgs e)
        {
            if (CheckUserName() && CheckPassword())
            {
                registerNewUserPanel.BringToFront();
                newUserNameLable.Text = registerNewUserNameTextBox.Text;

            }
            else
            {
                chooseUserNamePasswordPanel.BringToFront();
            }
            newUserNameLable.Text = registerNewUserNameTextBox.Text;

        }
        private bool CheckPassword()
        {
            if (registerNewPasswordTextBox.Text != verifyNewPasswordTextBox.Text)
            {

                MessageBox.Show("Your Passwords doesnt match");
                return false;
            }
            return true;
        }
        public bool CheckUserName()
        {
            List<User> users = userManager.CreateUserList();
            foreach (User user in users)
            {
                if (user.UserName == registerNewUserNameTextBox.Text)
                {
                    MessageBox.Show("This User Name is not avalible");
                    return false;
                }

            }
            return true;
        }


    }
}