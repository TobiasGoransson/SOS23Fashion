namespace SOSFashion
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            textemail = new TextBox();
            label5 = new Label();
            txtZipCode = new TextBox();
            label6 = new Label();
            txtstreet = new TextBox();
            label7 = new Label();
            comboBoxShipping = new ComboBox();
            label8 = new Label();
            comboBoxPayment = new ComboBox();
            label9 = new Label();
            btnConfirm = new Button();
            totalCostLabel = new Label();
            userButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 26);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 88);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(144, 99);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(153, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(497, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(153, 27);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 102);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Last name";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(497, 181);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(153, 27);
            txtCity.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 184);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 7;
            label4.Text = "City";
            // 
            // textemail
            // 
            textemail.Location = new Point(144, 181);
            textemail.Name = "textemail";
            textemail.Size = new Size(153, 27);
            textemail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 181);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(497, 254);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(153, 27);
            txtZipCode.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 257);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 10;
            label6.Text = "Zipcode";
            // 
            // txtstreet
            // 
            txtstreet.Location = new Point(144, 254);
            txtstreet.Name = "txtstreet";
            txtstreet.Size = new Size(153, 27);
            txtstreet.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 254);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 12;
            label7.Text = "Street";
            // 
            // comboBoxShipping
            // 
            comboBoxShipping.FormattingEnabled = true;
            comboBoxShipping.Location = new Point(144, 329);
            comboBoxShipping.Name = "comboBoxShipping";
            comboBoxShipping.Size = new Size(151, 28);
            comboBoxShipping.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 329);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 15;
            label8.Text = "Shipping";
            // 
            // comboBoxPayment
            // 
            comboBoxPayment.FormattingEnabled = true;
            comboBoxPayment.Location = new Point(497, 329);
            comboBoxPayment.Name = "comboBoxPayment";
            comboBoxPayment.Size = new Size(151, 28);
            comboBoxPayment.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(424, 337);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 17;
            label9.Text = "Payment";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(318, 383);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(139, 43);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalCostLabel.Location = new Point(580, 58);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(123, 29);
            totalCostLabel.TabIndex = 19;
            totalCostLabel.Text = "Total cost:";
            // 
            // userButton
            // 
            userButton.Location = new Point(580, 12);
            userButton.Name = "userButton";
            userButton.Size = new Size(179, 43);
            userButton.TabIndex = 20;
            userButton.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(userButton);
            Controls.Add(totalCostLabel);
            Controls.Add(btnConfirm);
            Controls.Add(label9);
            Controls.Add(comboBoxPayment);
            Controls.Add(label8);
            Controls.Add(comboBoxShipping);
            Controls.Add(label7);
            Controls.Add(txtZipCode);
            Controls.Add(label6);
            Controls.Add(txtstreet);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(textemail);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Checkout";
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox textEmail;
        private Label label5;
        private TextBox txtZipCode;
        private Label label6;
        private TextBox txtstreet;
        private Label label7;
        private ComboBox comboBoxShipping;
        private Label label8;
        private ComboBox comboBoxPayment;
        private Label label9;
        private Button btnConfirm;
        private Label totalCostLabel;
        public Button userButton;
        private TextBox textemail;
    }
}