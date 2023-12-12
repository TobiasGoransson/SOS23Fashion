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
            txtPhone = new TextBox();
            label4 = new Label();
            textEmail = new TextBox();
            label5 = new Label();
            txtZipCode = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
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
            label1.Location = new Point(285, 17);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 69);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(88, 67);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(134, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(397, 67);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(134, 23);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 69);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Last name";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(397, 128);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(134, 23);
            txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 130);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(88, 128);
            textEmail.Margin = new Padding(3, 2, 3, 2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(134, 23);
            textEmail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 128);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(397, 183);
            txtZipCode.Margin = new Padding(3, 2, 3, 2);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(134, 23);
            txtZipCode.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 185);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 10;
            label6.Text = "Zipcode";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(88, 183);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(134, 23);
            txtAddress.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 185);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 12;
            label7.Text = "Adress";
            // 
            // comboBoxShipping
            // 
            comboBoxShipping.FormattingEnabled = true;
            comboBoxShipping.Location = new Point(88, 239);
            comboBoxShipping.Margin = new Padding(3, 2, 3, 2);
            comboBoxShipping.Name = "comboBoxShipping";
            comboBoxShipping.Size = new Size(133, 23);
            comboBoxShipping.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 245);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 15;
            label8.Text = "Shipping";
            // 
            // comboBoxPayment
            // 
            comboBoxPayment.FormattingEnabled = true;
            comboBoxPayment.Location = new Point(397, 239);
            comboBoxPayment.Margin = new Padding(3, 2, 3, 2);
            comboBoxPayment.Name = "comboBoxPayment";
            comboBoxPayment.Size = new Size(133, 23);
            comboBoxPayment.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(324, 245);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 17;
            label9.Text = "Payment";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(231, 283);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 32);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalCostLabel.Location = new Point(397, 291);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(101, 24);
            totalCostLabel.TabIndex = 19;
            totalCostLabel.Text = "Total cost:";
            // 
            // userButton
            // 
            userButton.Location = new Point(531, 9);
            userButton.Margin = new Padding(3, 2, 3, 2);
            userButton.Name = "userButton";
            userButton.Size = new Size(157, 32);
            userButton.TabIndex = 20;
            userButton.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(textEmail);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtPhone;
        private Label label4;
        private TextBox textEmail;
        private Label label5;
        private TextBox txtZipCode;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private ComboBox comboBoxShipping;
        private Label label8;
        private ComboBox comboBoxPayment;
        private Label label9;
        private Button btnConfirm;
        private Label totalCostLabel;
        public Button userButton;
    }
}