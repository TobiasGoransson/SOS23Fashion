﻿namespace SOSFashion
{
    partial class Form1
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            registerNewUserPanel = new Panel();
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
            registerUserNameTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            registerLastNameTextBox = new TextBox();
            registerPasswordTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            LogInPanel.SuspendLayout();
            registerNewUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogInPanel
            // 
            LogInPanel.BackColor = Color.Transparent;
            LogInPanel.Controls.Add(registerNewUserButton);
            LogInPanel.Controls.Add(logInButton);
            LogInPanel.Controls.Add(textBox2);
            LogInPanel.Controls.Add(textBox1);
            LogInPanel.Controls.Add(label3);
            LogInPanel.Controls.Add(label2);
            LogInPanel.Location = new Point(300, 150);
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
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(123, 56);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 30);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(123, 11);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 30);
            textBox1.TabIndex = 1;
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
            registerNewUserPanel.Controls.Add(registerUserNameTextBox);
            registerNewUserPanel.Controls.Add(label6);
            registerNewUserPanel.Controls.Add(label7);
            registerNewUserPanel.Controls.Add(registerLastNameTextBox);
            registerNewUserPanel.Controls.Add(registerPasswordTextBox);
            registerNewUserPanel.Controls.Add(label4);
            registerNewUserPanel.Controls.Add(label5);
            registerNewUserPanel.Location = new Point(300, 150);
            registerNewUserPanel.Name = "registerNewUserPanel";
            registerNewUserPanel.Size = new Size(310, 351);
            registerNewUserPanel.TabIndex = 2;
            // 
            // cancelRegisterNewUserButton
            // 
            cancelRegisterNewUserButton.BackColor = SystemColors.Control;
            cancelRegisterNewUserButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancelRegisterNewUserButton.Location = new Point(12, 303);
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
            confirmRegisterNewUserButton.Location = new Point(158, 303);
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
            registerCityTextBox.Location = new Point(135, 255);
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
            label11.Location = new Point(17, 255);
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
            registerZipTextBox.Location = new Point(135, 220);
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
            label10.Location = new Point(17, 220);
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
            registerStreetTextBox.Location = new Point(135, 185);
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
            label9.Location = new Point(17, 185);
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
            registerEmailTextBox.Location = new Point(135, 150);
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
            label8.Location = new Point(17, 150);
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
            registerFirstNameTextBox.Location = new Point(135, 80);
            registerFirstNameTextBox.Multiline = true;
            registerFirstNameTextBox.Name = "registerFirstNameTextBox";
            registerFirstNameTextBox.PlaceholderText = "Name";
            registerFirstNameTextBox.Size = new Size(152, 30);
            registerFirstNameTextBox.TabIndex = 7;
            // 
            // registerUserNameTextBox
            // 
            registerUserNameTextBox.BackColor = SystemColors.Control;
            registerUserNameTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerUserNameTextBox.Location = new Point(135, 10);
            registerUserNameTextBox.Multiline = true;
            registerUserNameTextBox.Name = "registerUserNameTextBox";
            registerUserNameTextBox.PlaceholderText = "User Name";
            registerUserNameTextBox.Size = new Size(152, 30);
            registerUserNameTextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 45);
            label6.Name = "label6";
            label6.Size = new Size(110, 30);
            label6.TabIndex = 9;
            label6.Text = "Password";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 80);
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
            registerLastNameTextBox.Location = new Point(135, 115);
            registerLastNameTextBox.Multiline = true;
            registerLastNameTextBox.Name = "registerLastNameTextBox";
            registerLastNameTextBox.PlaceholderText = "Sirname";
            registerLastNameTextBox.Size = new Size(152, 30);
            registerLastNameTextBox.TabIndex = 8;
            // 
            // registerPasswordTextBox
            // 
            registerPasswordTextBox.BackColor = SystemColors.Control;
            registerPasswordTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerPasswordTextBox.Location = new Point(135, 45);
            registerPasswordTextBox.Multiline = true;
            registerPasswordTextBox.Name = "registerPasswordTextBox";
            registerPasswordTextBox.PlaceholderText = "****";
            registerPasswordTextBox.Size = new Size(152, 30);
            registerPasswordTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 115);
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
            label5.Location = new Point(17, 10);
            label5.Name = "label5";
            label5.Size = new Size(110, 30);
            label5.TabIndex = 4;
            label5.Text = "User Name";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AV_PB4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(989, 558);
            Controls.Add(label1);
            Controls.Add(registerNewUserPanel);
            Controls.Add(LogInPanel);
            Name = "Form1";
            Text = "Form1";
            LogInPanel.ResumeLayout(false);
            LogInPanel.PerformLayout();
            registerNewUserPanel.ResumeLayout(false);
            registerNewUserPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LogInPanel;
        private Button registerNewUserButton;
        private Button logInButton;
        private TextBox textBox2;
        private TextBox textBox1;
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
        private Label label6;
        private Label label7;
        private TextBox registerLastNameTextBox;
        private TextBox registerPasswordTextBox;
        private Label label4;
        private Label label5;
    }
}