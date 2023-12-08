namespace SOSFashion
{
    partial class AdminForm
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
            adminListBox1 = new ListBox();
            panel1 = new Panel();
            label31 = new Label();
            pantsLinkLabel = new LinkLabel();
            costumorLabel = new LinkLabel();
            placedOrdersLabel = new LinkLabel();
            roductlistLable = new LinkLabel();
            mainPanel = new Panel();
            registerNewUserPanel = new Panel();
            categoryTextBox = new TextBox();
            categoryLable = new Label();
            LargeCheckBox = new CheckBox();
            smallCheckBox = new CheckBox();
            mediumCheckBox = new CheckBox();
            oneSizeCheckBox = new CheckBox();
            itemTextBox = new TextBox();
            cancelRegisterNewUserButton = new Button();
            confirmRegisterNewUserButton = new Button();
            colorTextBox = new TextBox();
            colorLable = new Label();
            sizeLable = new Label();
            priceTextBox = new TextBox();
            itemPriceLable = new Label();
            quantityTextBox = new TextBox();
            quantityLable = new Label();
            itemNamelable = new Label();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            registerNewUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // adminListBox1
            // 
            adminListBox1.FormattingEnabled = true;
            adminListBox1.ItemHeight = 15;
            adminListBox1.Location = new Point(0, 0);
            adminListBox1.Name = "adminListBox1";
            adminListBox1.Size = new Size(380, 349);
            adminListBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label31);
            panel1.Controls.Add(pantsLinkLabel);
            panel1.Controls.Add(costumorLabel);
            panel1.Controls.Add(placedOrdersLabel);
            panel1.Controls.Add(roductlistLable);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 451);
            panel1.TabIndex = 4;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(24, 16);
            label31.Name = "label31";
            label31.Size = new Size(59, 25);
            label31.TabIndex = 3;
            label31.Text = "Meny";
            // 
            // pantsLinkLabel
            // 
            pantsLinkLabel.AutoSize = true;
            pantsLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pantsLinkLabel.LinkColor = Color.Black;
            pantsLinkLabel.Location = new Point(3, 148);
            pantsLinkLabel.Name = "pantsLinkLabel";
            pantsLinkLabel.Size = new Size(138, 21);
            pantsLinkLabel.TabIndex = 5;
            pantsLinkLabel.TabStop = true;
            pantsLinkLabel.Text = "Register New Item";
            pantsLinkLabel.LinkClicked += pantsLinkLabel_LinkClicked;
            // 
            // costumorLabel
            // 
            costumorLabel.AutoSize = true;
            costumorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            costumorLabel.LinkColor = Color.Black;
            costumorLabel.Location = new Point(3, 116);
            costumorLabel.Name = "costumorLabel";
            costumorLabel.Size = new Size(85, 21);
            costumorLabel.TabIndex = 4;
            costumorLabel.TabStop = true;
            costumorLabel.Text = "Costumers";
            // 
            // placedOrdersLabel
            // 
            placedOrdersLabel.AutoSize = true;
            placedOrdersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            placedOrdersLabel.LinkColor = Color.Black;
            placedOrdersLabel.Location = new Point(3, 86);
            placedOrdersLabel.Name = "placedOrdersLabel";
            placedOrdersLabel.Size = new Size(104, 21);
            placedOrdersLabel.TabIndex = 3;
            placedOrdersLabel.TabStop = true;
            placedOrdersLabel.Text = "Placed orders";
            // 
            // roductlistLable
            // 
            roductlistLable.AutoSize = true;
            roductlistLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roductlistLable.LinkColor = Color.Black;
            roductlistLable.Location = new Point(3, 53);
            roductlistLable.Name = "roductlistLable";
            roductlistLable.Size = new Size(88, 21);
            roductlistLable.TabIndex = 0;
            roductlistLable.TabStop = true;
            roductlistLable.Text = "Product list";
            roductlistLable.LinkClicked += roductlistLable_LinkClicked;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(adminListBox1);
            mainPanel.Location = new Point(568, 32);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(380, 350);
            mainPanel.TabIndex = 6;
            // 
            // registerNewUserPanel
            // 
            registerNewUserPanel.BackColor = Color.Transparent;
            registerNewUserPanel.Controls.Add(categoryTextBox);
            registerNewUserPanel.Controls.Add(categoryLable);
            registerNewUserPanel.Controls.Add(LargeCheckBox);
            registerNewUserPanel.Controls.Add(smallCheckBox);
            registerNewUserPanel.Controls.Add(mediumCheckBox);
            registerNewUserPanel.Controls.Add(oneSizeCheckBox);
            registerNewUserPanel.Controls.Add(itemTextBox);
            registerNewUserPanel.Controls.Add(cancelRegisterNewUserButton);
            registerNewUserPanel.Controls.Add(confirmRegisterNewUserButton);
            registerNewUserPanel.Controls.Add(colorTextBox);
            registerNewUserPanel.Controls.Add(colorLable);
            registerNewUserPanel.Controls.Add(sizeLable);
            registerNewUserPanel.Controls.Add(priceTextBox);
            registerNewUserPanel.Controls.Add(itemPriceLable);
            registerNewUserPanel.Controls.Add(quantityTextBox);
            registerNewUserPanel.Controls.Add(quantityLable);
            registerNewUserPanel.Controls.Add(itemNamelable);
            registerNewUserPanel.Location = new Point(164, 32);
            registerNewUserPanel.Name = "registerNewUserPanel";
            registerNewUserPanel.Size = new Size(380, 350);
            registerNewUserPanel.TabIndex = 3;
            // 
            // categoryTextBox
            // 
            categoryTextBox.BackColor = SystemColors.Control;
            categoryTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categoryTextBox.Location = new Point(138, 251);
            categoryTextBox.Multiline = true;
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.PlaceholderText = "Accerssories";
            categoryTextBox.Size = new Size(152, 30);
            categoryTextBox.TabIndex = 21;
            // 
            // categoryLable
            // 
            categoryLable.BackColor = SystemColors.Control;
            categoryLable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLable.Location = new Point(20, 251);
            categoryLable.Name = "categoryLable";
            categoryLable.Size = new Size(110, 30);
            categoryLable.TabIndex = 20;
            categoryLable.Text = "Category";
            categoryLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LargeCheckBox
            // 
            LargeCheckBox.AutoSize = true;
            LargeCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LargeCheckBox.Location = new Point(138, 187);
            LargeCheckBox.Name = "LargeCheckBox";
            LargeCheckBox.Size = new Size(74, 25);
            LargeCheckBox.TabIndex = 19;
            LargeCheckBox.Text = "Large";
            LargeCheckBox.UseVisualStyleBackColor = true;
            // 
            // smallCheckBox
            // 
            smallCheckBox.AutoSize = true;
            smallCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            smallCheckBox.Location = new Point(138, 141);
            smallCheckBox.Name = "smallCheckBox";
            smallCheckBox.Size = new Size(74, 25);
            smallCheckBox.TabIndex = 18;
            smallCheckBox.Text = "Small";
            smallCheckBox.UseVisualStyleBackColor = true;
            // 
            // mediumCheckBox
            // 
            mediumCheckBox.AutoSize = true;
            mediumCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mediumCheckBox.Location = new Point(138, 164);
            mediumCheckBox.Name = "mediumCheckBox";
            mediumCheckBox.Size = new Size(92, 25);
            mediumCheckBox.TabIndex = 17;
            mediumCheckBox.Text = "Medium";
            mediumCheckBox.UseVisualStyleBackColor = true;
            // 
            // oneSizeCheckBox
            // 
            oneSizeCheckBox.AutoSize = true;
            oneSizeCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            oneSizeCheckBox.Location = new Point(138, 116);
            oneSizeCheckBox.Name = "oneSizeCheckBox";
            oneSizeCheckBox.Size = new Size(96, 25);
            oneSizeCheckBox.TabIndex = 16;
            oneSizeCheckBox.Text = "One Size";
            oneSizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemTextBox
            // 
            itemTextBox.BackColor = SystemColors.Control;
            itemTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            itemTextBox.Location = new Point(138, 15);
            itemTextBox.Multiline = true;
            itemTextBox.Name = "itemTextBox";
            itemTextBox.PlaceholderText = "item";
            itemTextBox.Size = new Size(152, 30);
            itemTextBox.TabIndex = 15;
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
            // 
            // confirmRegisterNewUserButton
            // 
            confirmRegisterNewUserButton.BackColor = SystemColors.Control;
            confirmRegisterNewUserButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmRegisterNewUserButton.Location = new Point(158, 290);
            confirmRegisterNewUserButton.Name = "confirmRegisterNewUserButton";
            confirmRegisterNewUserButton.Size = new Size(140, 35);
            confirmRegisterNewUserButton.TabIndex = 13;
            confirmRegisterNewUserButton.Text = "Register new Item";
            confirmRegisterNewUserButton.UseVisualStyleBackColor = false;
            confirmRegisterNewUserButton.Click += confirmRegisterNewUserButton_Click;
            // 
            // colorTextBox
            // 
            colorTextBox.BackColor = SystemColors.Control;
            colorTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            colorTextBox.Location = new Point(138, 215);
            colorTextBox.Multiline = true;
            colorTextBox.Name = "colorTextBox";
            colorTextBox.PlaceholderText = "Black";
            colorTextBox.Size = new Size(152, 30);
            colorTextBox.TabIndex = 10;
            // 
            // colorLable
            // 
            colorLable.BackColor = SystemColors.Control;
            colorLable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            colorLable.Location = new Point(20, 215);
            colorLable.Name = "colorLable";
            colorLable.Size = new Size(110, 30);
            colorLable.TabIndex = 14;
            colorLable.Text = "Color";
            colorLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sizeLable
            // 
            sizeLable.BackColor = SystemColors.Control;
            sizeLable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sizeLable.Location = new Point(20, 120);
            sizeLable.Name = "sizeLable";
            sizeLable.Size = new Size(110, 30);
            sizeLable.TabIndex = 12;
            sizeLable.Text = "Size";
            sizeLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = SystemColors.Control;
            priceTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextBox.Location = new Point(138, 45);
            priceTextBox.Multiline = true;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PlaceholderText = "123,45";
            priceTextBox.Size = new Size(152, 30);
            priceTextBox.TabIndex = 7;
            // 
            // itemPriceLable
            // 
            itemPriceLable.BackColor = SystemColors.Control;
            itemPriceLable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            itemPriceLable.Location = new Point(20, 45);
            itemPriceLable.Name = "itemPriceLable";
            itemPriceLable.Size = new Size(110, 30);
            itemPriceLable.TabIndex = 8;
            itemPriceLable.Text = "Price";
            itemPriceLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quantityTextBox
            // 
            quantityTextBox.BackColor = SystemColors.Control;
            quantityTextBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTextBox.Location = new Point(138, 80);
            quantityTextBox.Multiline = true;
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PlaceholderText = "0";
            quantityTextBox.Size = new Size(152, 30);
            quantityTextBox.TabIndex = 8;
            // 
            // quantityLable
            // 
            quantityLable.BackColor = SystemColors.Control;
            quantityLable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLable.Location = new Point(20, 80);
            quantityLable.Name = "quantityLable";
            quantityLable.Size = new Size(110, 30);
            quantityLable.TabIndex = 5;
            quantityLable.Text = "Quantity";
            quantityLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // itemNamelable
            // 
            itemNamelable.BackColor = SystemColors.Control;
            itemNamelable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            itemNamelable.Location = new Point(22, 15);
            itemNamelable.Name = "itemNamelable";
            itemNamelable.Size = new Size(110, 30);
            itemNamelable.TabIndex = 4;
            itemNamelable.Text = "Item Name";
            itemNamelable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 462);
            Controls.Add(registerNewUserPanel);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            registerNewUserPanel.ResumeLayout(false);
            registerNewUserPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox adminListBox1;
        private Panel panel1;
        private Label label31;
        private LinkLabel pantsLinkLabel;
        private LinkLabel costumorLabel;
        private LinkLabel placedOrdersLabel;
        private LinkLabel roductlistLable;
        private Panel mainPanel;
        private Panel registerNewUserPanel;
        private Button cancelRegisterNewUserButton;
        private Button confirmRegisterNewUserButton;
        private TextBox colorTextBox;
        private Label colorLable;
        private Label sizeLable;
        private TextBox priceTextBox;
        private Label itemPriceLable;
        private TextBox quantityTextBox;
        private Label quantityLable;
        private Label itemNamelable;
        private CheckBox LargeCheckBox;
        private CheckBox smallCheckBox;
        private CheckBox mediumCheckBox;
        private CheckBox oneSizeCheckBox;
        private TextBox itemTextBox;
        private TextBox categoryTextBox;
        private Label categoryLable;
    }
}