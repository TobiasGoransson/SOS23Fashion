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
            logOutAdminLable = new LinkLabel();
            label31 = new Label();
            registerNewItemkLabel = new LinkLabel();
            costumorLabel = new LinkLabel();
            placedOrdersLabel = new LinkLabel();
            productlistLable = new LinkLabel();
            mainPanel = new Panel();
            registerNewItemPanel = new Panel();
            accessoriesCheckBox = new CheckBox();
            suitsCheckBox = new CheckBox();
            coatsCheckBox = new CheckBox();
            dressesCheckBox = new CheckBox();
            hatCheckBox = new CheckBox();
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
            itemNamelable = new Label();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            registerNewItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // adminListBox1
            // 
            adminListBox1.FormattingEnabled = true;
            adminListBox1.ItemHeight = 15;
            adminListBox1.Location = new Point(0, 3);
            adminListBox1.Name = "adminListBox1";
            adminListBox1.Size = new Size(550, 349);
            adminListBox1.TabIndex = 0;
            adminListBox1.SelectedIndexChanged += adminListBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(logOutAdminLable);
            panel1.Controls.Add(label31);
            panel1.Controls.Add(registerNewItemkLabel);
            panel1.Controls.Add(costumorLabel);
            panel1.Controls.Add(placedOrdersLabel);
            panel1.Controls.Add(productlistLable);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 451);
            panel1.TabIndex = 4;
            // 
            // logOutAdminLable
            // 
            logOutAdminLable.AutoSize = true;
            logOutAdminLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logOutAdminLable.LinkColor = Color.Black;
            logOutAdminLable.Location = new Point(3, 213);
            logOutAdminLable.Name = "logOutAdminLable";
            logOutAdminLable.Size = new Size(113, 21);
            logOutAdminLable.TabIndex = 6;
            logOutAdminLable.TabStop = true;
            logOutAdminLable.Text = "Log out Admin";
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
            // registerNewItemkLabel
            // 
            registerNewItemkLabel.AutoSize = true;
            registerNewItemkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerNewItemkLabel.LinkColor = Color.Black;
            registerNewItemkLabel.Location = new Point(3, 148);
            registerNewItemkLabel.Name = "registerNewItemkLabel";
            registerNewItemkLabel.Size = new Size(138, 21);
            registerNewItemkLabel.TabIndex = 5;
            registerNewItemkLabel.TabStop = true;
            registerNewItemkLabel.Text = "Register New Item";
            registerNewItemkLabel.LinkClicked += registerNewItemkLabel_LinkClicked;
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
            costumorLabel.LinkClicked += costumorLabel_LinkClicked;
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
            placedOrdersLabel.LinkClicked += placedOrdersLabel_LinkClicked;
            // 
            // productlistLable
            // 
            productlistLable.AutoSize = true;
            productlistLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productlistLable.LinkColor = Color.Black;
            productlistLable.Location = new Point(3, 53);
            productlistLable.Name = "productlistLable";
            productlistLable.Size = new Size(88, 21);
            productlistLable.TabIndex = 0;
            productlistLable.TabStop = true;
            productlistLable.Text = "Product list";
            productlistLable.LinkClicked += productlistLable_LinkClicked;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(adminListBox1);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(550, 350);
            mainPanel.TabIndex = 6;
            // 
            // registerNewItemPanel
            // 
            registerNewItemPanel.BackColor = Color.Transparent;
            registerNewItemPanel.Controls.Add(mainPanel);
            registerNewItemPanel.Controls.Add(accessoriesCheckBox);
            registerNewItemPanel.Controls.Add(suitsCheckBox);
            registerNewItemPanel.Controls.Add(coatsCheckBox);
            registerNewItemPanel.Controls.Add(dressesCheckBox);
            registerNewItemPanel.Controls.Add(hatCheckBox);
            registerNewItemPanel.Controls.Add(categoryLable);
            registerNewItemPanel.Controls.Add(LargeCheckBox);
            registerNewItemPanel.Controls.Add(smallCheckBox);
            registerNewItemPanel.Controls.Add(mediumCheckBox);
            registerNewItemPanel.Controls.Add(oneSizeCheckBox);
            registerNewItemPanel.Controls.Add(itemTextBox);
            registerNewItemPanel.Controls.Add(cancelRegisterNewUserButton);
            registerNewItemPanel.Controls.Add(confirmRegisterNewUserButton);
            registerNewItemPanel.Controls.Add(colorTextBox);
            registerNewItemPanel.Controls.Add(colorLable);
            registerNewItemPanel.Controls.Add(sizeLable);
            registerNewItemPanel.Controls.Add(priceTextBox);
            registerNewItemPanel.Controls.Add(itemPriceLable);
            registerNewItemPanel.Controls.Add(itemNamelable);
            registerNewItemPanel.Location = new Point(164, 12);
            registerNewItemPanel.Name = "registerNewItemPanel";
            registerNewItemPanel.Size = new Size(547, 350);
            registerNewItemPanel.TabIndex = 3;
            // 
            // accessoriesCheckBox
            // 
            accessoriesCheckBox.AutoSize = true;
            accessoriesCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            accessoriesCheckBox.Location = new Point(111, 235);
            accessoriesCheckBox.Name = "accessoriesCheckBox";
            accessoriesCheckBox.Size = new Size(117, 25);
            accessoriesCheckBox.TabIndex = 25;
            accessoriesCheckBox.Text = "Accessories";
            accessoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // suitsCheckBox
            // 
            suitsCheckBox.AutoSize = true;
            suitsCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            suitsCheckBox.Location = new Point(222, 215);
            suitsCheckBox.Name = "suitsCheckBox";
            suitsCheckBox.Size = new Size(68, 25);
            suitsCheckBox.TabIndex = 24;
            suitsCheckBox.Text = "Suits";
            suitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // coatsCheckBox
            // 
            coatsCheckBox.AutoSize = true;
            coatsCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            coatsCheckBox.Location = new Point(222, 195);
            coatsCheckBox.Name = "coatsCheckBox";
            coatsCheckBox.Size = new Size(70, 25);
            coatsCheckBox.TabIndex = 23;
            coatsCheckBox.Text = "Coats";
            coatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // dressesCheckBox
            // 
            dressesCheckBox.AutoSize = true;
            dressesCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dressesCheckBox.Location = new Point(111, 215);
            dressesCheckBox.Name = "dressesCheckBox";
            dressesCheckBox.Size = new Size(87, 25);
            dressesCheckBox.TabIndex = 22;
            dressesCheckBox.Text = "Dresses";
            dressesCheckBox.UseVisualStyleBackColor = true;
            // 
            // hatCheckBox
            // 
            hatCheckBox.AutoSize = true;
            hatCheckBox.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            hatCheckBox.Location = new Point(111, 194);
            hatCheckBox.Name = "hatCheckBox";
            hatCheckBox.Size = new Size(59, 25);
            hatCheckBox.TabIndex = 21;
            hatCheckBox.Text = "Hat";
            hatCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryLable
            // 
            categoryLable.BackColor = SystemColors.Control;
            categoryLable.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLable.Location = new Point(20, 194);
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
            LargeCheckBox.Location = new Point(222, 106);
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
            smallCheckBox.Location = new Point(222, 86);
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
            mediumCheckBox.Location = new Point(111, 106);
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
            oneSizeCheckBox.Location = new Point(111, 85);
            oneSizeCheckBox.Name = "oneSizeCheckBox";
            oneSizeCheckBox.Size = new Size(96, 25);
            oneSizeCheckBox.TabIndex = 16;
            oneSizeCheckBox.Text = "One Size";
            oneSizeCheckBox.UseVisualStyleBackColor = true;
            oneSizeCheckBox.CheckedChanged += oneSizeCheckBox_CheckedChanged;
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
            colorTextBox.Location = new Point(138, 149);
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
            colorLable.Location = new Point(20, 149);
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
            sizeLable.Location = new Point(20, 86);
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
            ClientSize = new Size(1501, 803);
            Controls.Add(registerNewItemPanel);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            registerNewItemPanel.ResumeLayout(false);
            registerNewItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox adminListBox1;
        private Panel panel1;
        private Label label31;
        private LinkLabel registerNewItemkLabel;
        private LinkLabel costumorLabel;
        private LinkLabel placedOrdersLabel;
        private LinkLabel productlistLable;
        private Panel mainPanel;
        private Panel registerNewItemPanel;
        private Button cancelRegisterNewUserButton;
        private Button confirmRegisterNewUserButton;
        private TextBox colorTextBox;
        private Label colorLable;
        private Label sizeLable;
        private TextBox priceTextBox;
        private Label itemPriceLable;
        private Label itemNamelable;
        private CheckBox LargeCheckBox;
        private CheckBox smallCheckBox;
        private CheckBox mediumCheckBox;
        private CheckBox oneSizeCheckBox;
        private TextBox itemTextBox;
        private Label categoryLable;
        private LinkLabel logOutAdminLable;
        private CheckBox accessoriesCheckBox;
        private CheckBox suitsCheckBox;
        private CheckBox coatsCheckBox;
        private CheckBox dressesCheckBox;
        private CheckBox hatCheckBox;
    }
}