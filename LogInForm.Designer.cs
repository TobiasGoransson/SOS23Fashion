namespace SOSFashion
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogInPanel = new Panel();
            registerNewUserButton = new Button();
            logInButton = new Button();
            passwordTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            chooseUserNamePasswordPanel = new Panel();
            registerNewUserNameTextBox = new TextBox();
            verifyNewPasswordTextBox = new TextBox();
            label14 = new Label();
            cancelRegisterUserButton = new Button();
            registerUserPasswordButton = new Button();
            registerNewPasswordTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label1 = new Label();
            registerNewUserPanel = new Panel();
            newUserNameLable = new Label();
            cancelRegisterNewUserButton = new Button();
            confirmRegisterNewUserButton = new Button();
            registerCityTextBox = new TextBox();
            label11 = new Label();
            registerZipTextBox = new TextBox();
            label10 = new Label();
            registerStreetTextBox = new TextBox();
            label9 = new Label();
            registerEmailTextBox = new TextBox();
            label8 = new Label();
            registerFirstNameTextBox = new TextBox();
            label7 = new Label();
            registerLastNameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            LogInPanel.SuspendLayout();
            chooseUserNamePasswordPanel.SuspendLayout();
            registerNewUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogInPanel
            // 
            LogInPanel.BackColor = Color.Transparent;
            LogInPanel.Controls.Add(registerNewUserButton);
            LogInPanel.Controls.Add(logInButton);
            LogInPanel.Controls.Add(passwordTextBox);
            LogInPanel.Controls.Add(UserNameTextBox);
            LogInPanel.Controls.Add(label3);
            LogInPanel.Controls.Add(label2);
            LogInPanel.Location = new Point(297, 150);
            LogInPanel.Name = "LogInPanel";
            LogInPanel.Size = new Size(310, 351);
            LogInPanel.TabIndex = 0;
            // 
            // registerNewUserButton
            // 
            registerNewUserButton.BackColor = SystemColors.Control;
            registerNewUserButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerNewUserButton.Location = new Point(81, 170);
            registerNewUserButton.Name = "registerNewUserButton";
            registerNewUserButton.Size = new Size(140, 35);
            registerNewUserButton.TabIndex = 4;
            registerNewUserButton.Text = "Register new user";
            registerNewUserButton.UseVisualStyleBackColor = false;
            registerNewUserButton.Click += registerNewUserButton_Click;
            // 
            // logInButton
            // 
            logInButton.BackColor = SystemColors.Control;
            logInButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.Location = new Point(81, 111);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(140, 35);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Control;
            passwordTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(123, 56);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(152, 30);
            passwordTextBox.TabIndex = 2;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = SystemColors.Control;
            UserNameTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTextBox.Location = new Point(123, 11);
            UserNameTextBox.Multiline = true;
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(152, 30);
            UserNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 56);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 1;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 11);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chooseUserNamePasswordPanel
            // 
            chooseUserNamePasswordPanel.BackColor = Color.Transparent;
            chooseUserNamePasswordPanel.Controls.Add(registerNewUserNameTextBox);
            chooseUserNamePasswordPanel.Controls.Add(verifyNewPasswordTextBox);
            chooseUserNamePasswordPanel.Controls.Add(label14);
            chooseUserNamePasswordPanel.Controls.Add(cancelRegisterUserButton);
            chooseUserNamePasswordPanel.Controls.Add(registerUserPasswordButton);
            chooseUserNamePasswordPanel.Controls.Add(registerNewPasswordTextBox);
            chooseUserNamePasswordPanel.Controls.Add(label12);
            chooseUserNamePasswordPanel.Controls.Add(label13);
            chooseUserNamePasswordPanel.Location = new Point(300, 150);
            chooseUserNamePasswordPanel.Name = "chooseUserNamePasswordPanel";
            chooseUserNamePasswordPanel.Size = new Size(310, 351);
            chooseUserNamePasswordPanel.TabIndex = 5;
            // 
            // registerNewUserNameTextBox
            // 
            registerNewUserNameTextBox.BackColor = SystemColors.Control;
            registerNewUserNameTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerNewUserNameTextBox.Location = new Point(127, 11);
            registerNewUserNameTextBox.Multiline = true;
            registerNewUserNameTextBox.Name = "registerNewUserNameTextBox";
            registerNewUserNameTextBox.PlaceholderText = "Name";
            registerNewUserNameTextBox.Size = new Size(152, 30);
            registerNewUserNameTextBox.TabIndex = 20;
            // 
            // verifyNewPasswordTextBox
            // 
            verifyNewPasswordTextBox.BackColor = SystemColors.Control;
            verifyNewPasswordTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            verifyNewPasswordTextBox.Location = new Point(127, 117);
            verifyNewPasswordTextBox.Multiline = true;
            verifyNewPasswordTextBox.Name = "verifyNewPasswordTextBox";
            verifyNewPasswordTextBox.PlaceholderText = "****";
            verifyNewPasswordTextBox.Size = new Size(152, 30);
            verifyNewPasswordTextBox.TabIndex = 6;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(18, 92);
            label14.Name = "label14";
            label14.Size = new Size(103, 53);
            label14.TabIndex = 5;
            label14.Text = "Verify Password";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cancelRegisterUserButton
            // 
            cancelRegisterUserButton.BackColor = SystemColors.Control;
            cancelRegisterUserButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancelRegisterUserButton.Location = new Point(10, 288);
            cancelRegisterUserButton.Name = "cancelRegisterUserButton";
            cancelRegisterUserButton.Size = new Size(140, 35);
            cancelRegisterUserButton.TabIndex = 4;
            cancelRegisterUserButton.Text = "Cancel";
            cancelRegisterUserButton.UseVisualStyleBackColor = false;
            cancelRegisterUserButton.Click += cancelRegisterUserButton_Click;
            // 
            // registerUserPasswordButton
            // 
            registerUserPasswordButton.BackColor = SystemColors.Control;
            registerUserPasswordButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerUserPasswordButton.Location = new Point(156, 288);
            registerUserPasswordButton.Name = "registerUserPasswordButton";
            registerUserPasswordButton.Size = new Size(140, 35);
            registerUserPasswordButton.TabIndex = 3;
            registerUserPasswordButton.Text = "Register User";
            registerUserPasswordButton.UseVisualStyleBackColor = false;
            registerUserPasswordButton.Click += registerUserPasswordButton_Click;
            // 
            // registerNewPasswordTextBox
            // 
            registerNewPasswordTextBox.BackColor = SystemColors.Control;
            registerNewPasswordTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerNewPasswordTextBox.Location = new Point(127, 56);
            registerNewPasswordTextBox.Multiline = true;
            registerNewPasswordTextBox.Name = "registerNewPasswordTextBox";
            registerNewPasswordTextBox.PlaceholderText = "****";
            registerNewPasswordTextBox.Size = new Size(152, 30);
            registerNewPasswordTextBox.TabIndex = 2;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(18, 56);
            label12.Name = "label12";
            label12.Size = new Size(103, 30);
            label12.TabIndex = 1;
            label12.Text = "Password";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(18, 11);
            label13.Name = "label13";
            label13.Size = new Size(103, 30);
            label13.TabIndex = 0;
            label13.Text = "User Name";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(291, 85);
            label1.Name = "label1";
            label1.Size = new Size(330, 50);
            label1.TabIndex = 1;
            label1.Text = "SOS23 Fashion";
            // 
            // registerNewUserPanel
            // 
            registerNewUserPanel.BackColor = Color.Transparent;
            registerNewUserPanel.Controls.Add(newUserNameLable);
            registerNewUserPanel.Controls.Add(cancelRegisterNewUserButton);
            registerNewUserPanel.Controls.Add(confirmRegisterNewUserButton);
            registerNewUserPanel.Controls.Add(registerCityTextBox);
            registerNewUserPanel.Controls.Add(label11);
            registerNewUserPanel.Controls.Add(registerZipTextBox);
            registerNewUserPanel.Controls.Add(label10);
            registerNewUserPanel.Controls.Add(registerStreetTextBox);
            registerNewUserPanel.Controls.Add(label9);
            registerNewUserPanel.Controls.Add(registerEmailTextBox);
            registerNewUserPanel.Controls.Add(label8);
            registerNewUserPanel.Controls.Add(registerFirstNameTextBox);
            registerNewUserPanel.Controls.Add(label7);
            registerNewUserPanel.Controls.Add(registerLastNameTextBox);
            registerNewUserPanel.Controls.Add(label4);
            registerNewUserPanel.Controls.Add(label5);
            registerNewUserPanel.Location = new Point(297, 150);
            registerNewUserPanel.Name = "registerNewUserPanel";
            registerNewUserPanel.Size = new Size(310, 351);
            registerNewUserPanel.TabIndex = 2;
            // 
            // newUserNameLable
            // 
            newUserNameLable.BackColor = SystemColors.Control;
            newUserNameLable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            newUserNameLable.Location = new Point(138, 11);
            newUserNameLable.Name = "newUserNameLable";
            newUserNameLable.Size = new Size(152, 30);
            newUserNameLable.TabIndex = 19;
            newUserNameLable.Text = "User Name";
            newUserNameLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cancelRegisterNewUserButton
            // 
            cancelRegisterNewUserButton.BackColor = SystemColors.Control;
            cancelRegisterNewUserButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancelRegisterNewUserButton.Location = new Point(12, 290);
            cancelRegisterNewUserButton.Name = "cancelRegisterNewUserButton";
            cancelRegisterNewUserButton.Size = new Size(140, 35);
            cancelRegisterNewUserButton.TabIndex = 14;
            cancelRegisterNewUserButton.Text = "Cancel";
            cancelRegisterNewUserButton.UseVisualStyleBackColor = false;
            cancelRegisterNewUserButton.Click += cancelRegisterNewUserButton_Click;
            // 
            // confirmRegisterNewUserButton
            // 
            confirmRegisterNewUserButton.BackColor = SystemColors.Control;
            confirmRegisterNewUserButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmRegisterNewUserButton.Location = new Point(158, 290);
            confirmRegisterNewUserButton.Name = "confirmRegisterNewUserButton";
            confirmRegisterNewUserButton.Size = new Size(140, 35);
            confirmRegisterNewUserButton.TabIndex = 13;
            confirmRegisterNewUserButton.Text = "Register new user";
            confirmRegisterNewUserButton.UseVisualStyleBackColor = false;
            confirmRegisterNewUserButton.Click += confirmRegisterNewUserButton_Click;
            // 
            // registerCityTextBox
            // 
            registerCityTextBox.BackColor = SystemColors.Control;
            registerCityTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerCityTextBox.Location = new Point(138, 220);
            registerCityTextBox.Multiline = true;
            registerCityTextBox.Name = "registerCityTextBox";
            registerCityTextBox.PlaceholderText = "City";
            registerCityTextBox.Size = new Size(152, 30);
            registerCityTextBox.TabIndex = 12;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(20, 220);
            label11.Name = "label11";
            label11.Size = new Size(110, 30);
            label11.TabIndex = 18;
            label11.Text = "City";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerZipTextBox
            // 
            registerZipTextBox.BackColor = SystemColors.Control;
            registerZipTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerZipTextBox.Location = new Point(138, 185);
            registerZipTextBox.Multiline = true;
            registerZipTextBox.Name = "registerZipTextBox";
            registerZipTextBox.PlaceholderText = "nnn nn";
            registerZipTextBox.Size = new Size(152, 30);
            registerZipTextBox.TabIndex = 11;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(20, 185);
            label10.Name = "label10";
            label10.Size = new Size(110, 30);
            label10.TabIndex = 16;
            label10.Text = "Zip";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerStreetTextBox
            // 
            registerStreetTextBox.BackColor = SystemColors.Control;
            registerStreetTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerStreetTextBox.Location = new Point(138, 150);
            registerStreetTextBox.Multiline = true;
            registerStreetTextBox.Name = "registerStreetTextBox";
            registerStreetTextBox.PlaceholderText = "Street nn";
            registerStreetTextBox.Size = new Size(152, 30);
            registerStreetTextBox.TabIndex = 10;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(20, 150);
            label9.Name = "label9";
            label9.Size = new Size(110, 30);
            label9.TabIndex = 14;
            label9.Text = "Street";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerEmailTextBox
            // 
            registerEmailTextBox.BackColor = SystemColors.Control;
            registerEmailTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerEmailTextBox.Location = new Point(138, 115);
            registerEmailTextBox.Multiline = true;
            registerEmailTextBox.Name = "registerEmailTextBox";
            registerEmailTextBox.PlaceholderText = "name@mail.com";
            registerEmailTextBox.Size = new Size(152, 30);
            registerEmailTextBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 115);
            label8.Name = "label8";
            label8.Size = new Size(110, 30);
            label8.TabIndex = 12;
            label8.Text = "Email";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerFirstNameTextBox
            // 
            registerFirstNameTextBox.BackColor = SystemColors.Control;
            registerFirstNameTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerFirstNameTextBox.Location = new Point(138, 45);
            registerFirstNameTextBox.Multiline = true;
            registerFirstNameTextBox.Name = "registerFirstNameTextBox";
            registerFirstNameTextBox.PlaceholderText = "Name";
            registerFirstNameTextBox.Size = new Size(152, 30);
            registerFirstNameTextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(20, 45);
            label7.Name = "label7";
            label7.Size = new Size(110, 30);
            label7.TabIndex = 8;
            label7.Text = "First Name";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerLastNameTextBox
            // 
            registerLastNameTextBox.BackColor = SystemColors.Control;
            registerLastNameTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerLastNameTextBox.Location = new Point(138, 80);
            registerLastNameTextBox.Multiline = true;
            registerLastNameTextBox.Name = "registerLastNameTextBox";
            registerLastNameTextBox.PlaceholderText = "Sirname";
            registerLastNameTextBox.Size = new Size(152, 30);
            registerLastNameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 80);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 10);
            label5.Name = "label5";
            label5.Size = new Size(110, 30);
            label5.TabIndex = 4;
            label5.Text = "User Name";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(989, 558);
            Controls.Add(label1);
            Controls.Add(LogInPanel);
            Controls.Add(registerNewUserPanel);
            Controls.Add(chooseUserNamePasswordPanel);
            Name = "LogInForm";
            Text = "LogInForm";
            LogInPanel.ResumeLayout(false);
            LogInPanel.PerformLayout();
            chooseUserNamePasswordPanel.ResumeLayout(false);
            chooseUserNamePasswordPanel.PerformLayout();
            registerNewUserPanel.ResumeLayout(false);
            registerNewUserPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LogInPanel;
        private Button registerNewUserButton;
        private Button logInButton;
        private TextBox passwordTextBox;
        private TextBox UserNameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel registerNewUserPanel;
        private Button cancelRegisterNewUserButton;
        private Button confirmRegisterNewUserButton;
        private TextBox registerCityTextBox;
        private Label label11;
        private TextBox registerZipTextBox;
        private Label label10;
        private TextBox registerStreetTextBox;
        private Label label9;
        private TextBox registerEmailTextBox;
        private Label label8;
        private TextBox registerFirstNameTextBox;
        private TextBox registerUserNameTextBox;
        private Label label7;
        private TextBox registerLastNameTextBox;
        private TextBox registerPasswordTextBox;
        private Label label4;
        private Label label5;
        private Panel chooseUserNamePasswordPanel;
        private TextBox verifyNewPasswordTextBox;
        private Label label14;
        private Button cancelRegisterUserButton;
        private Button registerUserPasswordButton;
        private TextBox registerNewPasswordTextBox;
        private Label label12;
        private Label label13;
        private Label newUserNameLable;
        private TextBox registerNewUserNameTextBox;
    }
}