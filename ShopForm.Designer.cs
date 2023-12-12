namespace SOSFashion
{
    partial class ShopForm
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
            panel1 = new Panel();
            accessoriesLinkLabel = new LinkLabel();
            dressesLinkLabel = new LinkLabel();
            coatsLinkLabel = new LinkLabel();
            suitsLinkLabel = new LinkLabel();
            hatsLinkLabel = new LinkLabel();
            categoryLabel = new Label();
            KundvagnlistBox = new ListBox();
            removeKundvagnButton = new Button();
            totalcostlabel = new Label();
            logInButton = new Button();
            logOutButton = new Button();
            backButton = new Button();
            purchasebutton = new Button();
            categoryListBox = new ListBox();
            itemsPanel = new Panel();
            nameLabel = new Label();
            mainPictureBox = new PictureBox();
            colorLabel = new Label();
            sizeLabel = new Label();
            labelSize = new Label();
            priceLabel = new Label();
            addButton = new Button();
            labelColor = new Label();
            labelName = new Label();
            labelPrice = new Label();
            panel1.SuspendLayout();
            itemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(accessoriesLinkLabel);
            panel1.Controls.Add(dressesLinkLabel);
            panel1.Controls.Add(coatsLinkLabel);
            panel1.Controls.Add(suitsLinkLabel);
            panel1.Controls.Add(hatsLinkLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Location = new Point(17, 100);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 749);
            panel1.TabIndex = 3;
            // 
            // accessoriesLinkLabel
            // 
            accessoriesLinkLabel.AutoSize = true;
            accessoriesLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accessoriesLinkLabel.LinkColor = Color.Black;
            accessoriesLinkLabel.Location = new Point(19, 393);
            accessoriesLinkLabel.Margin = new Padding(4, 0, 4, 0);
            accessoriesLinkLabel.Name = "accessoriesLinkLabel";
            accessoriesLinkLabel.Size = new Size(135, 32);
            accessoriesLinkLabel.TabIndex = 15;
            accessoriesLinkLabel.TabStop = true;
            accessoriesLinkLabel.Text = "Accessories";
            accessoriesLinkLabel.LinkClicked += accessoriesLinkLabel_LinkClicked;
            // 
            // dressesLinkLabel
            // 
            dressesLinkLabel.AutoSize = true;
            dressesLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dressesLinkLabel.LinkColor = Color.Black;
            dressesLinkLabel.Location = new Point(19, 312);
            dressesLinkLabel.Margin = new Padding(4, 0, 4, 0);
            dressesLinkLabel.Name = "dressesLinkLabel";
            dressesLinkLabel.Size = new Size(95, 32);
            dressesLinkLabel.TabIndex = 16;
            dressesLinkLabel.TabStop = true;
            dressesLinkLabel.Text = "Dresses";
            dressesLinkLabel.LinkClicked += dressesLinkLabel_LinkClicked;
            // 
            // coatsLinkLabel
            // 
            coatsLinkLabel.AutoSize = true;
            coatsLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            coatsLinkLabel.LinkColor = Color.Black;
            coatsLinkLabel.Location = new Point(19, 242);
            coatsLinkLabel.Margin = new Padding(4, 0, 4, 0);
            coatsLinkLabel.Name = "coatsLinkLabel";
            coatsLinkLabel.Size = new Size(73, 32);
            coatsLinkLabel.TabIndex = 17;
            coatsLinkLabel.TabStop = true;
            coatsLinkLabel.Text = "Coats";
            coatsLinkLabel.LinkClicked += coatsLinkLabel_LinkClicked;
            // 
            // suitsLinkLabel
            // 
            suitsLinkLabel.AutoSize = true;
            suitsLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            suitsLinkLabel.LinkColor = Color.Black;
            suitsLinkLabel.Location = new Point(19, 157);
            suitsLinkLabel.Margin = new Padding(4, 0, 4, 0);
            suitsLinkLabel.Name = "suitsLinkLabel";
            suitsLinkLabel.Size = new Size(65, 32);
            suitsLinkLabel.TabIndex = 18;
            suitsLinkLabel.TabStop = true;
            suitsLinkLabel.Text = "Suits";
            suitsLinkLabel.LinkClicked += suitsLinkLabel_LinkClicked;
            // 
            // hatsLinkLabel
            // 
            hatsLinkLabel.AutoSize = true;
            hatsLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hatsLinkLabel.LinkColor = Color.Black;
            hatsLinkLabel.Location = new Point(19, 78);
            hatsLinkLabel.Margin = new Padding(4, 0, 4, 0);
            hatsLinkLabel.Name = "hatsLinkLabel";
            hatsLinkLabel.Size = new Size(61, 32);
            hatsLinkLabel.TabIndex = 14;
            hatsLinkLabel.TabStop = true;
            hatsLinkLabel.Text = "Hats";
            hatsLinkLabel.LinkClicked += hatsLinkLabel_LinkClicked;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(19, 3);
            categoryLabel.Margin = new Padding(4, 0, 4, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(160, 41);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Categories";
            // 
            // KundvagnlistBox
            // 
            KundvagnlistBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KundvagnlistBox.FormattingEnabled = true;
            KundvagnlistBox.ItemHeight = 32;
            KundvagnlistBox.Location = new Point(1109, 143);
            KundvagnlistBox.Margin = new Padding(4, 5, 4, 5);
            KundvagnlistBox.Name = "KundvagnlistBox";
            KundvagnlistBox.Size = new Size(320, 484);
            KundvagnlistBox.TabIndex = 5;
            // 
            // removeKundvagnButton
            // 
            removeKundvagnButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeKundvagnButton.Location = new Point(1272, 747);
            removeKundvagnButton.Margin = new Padding(4, 5, 4, 5);
            removeKundvagnButton.Name = "removeKundvagnButton";
            removeKundvagnButton.Size = new Size(214, 45);
            removeKundvagnButton.TabIndex = 6;
            removeKundvagnButton.Text = "Remove from cart";
            removeKundvagnButton.UseVisualStyleBackColor = true;
            removeKundvagnButton.Click += removeKundvagnButton_Click;
            // 
            // totalcostlabel
            // 
            totalcostlabel.AutoSize = true;
            totalcostlabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            totalcostlabel.Location = new Point(1206, 655);
            totalcostlabel.Name = "totalcostlabel";
            totalcostlabel.Size = new Size(139, 38);
            totalcostlabel.TabIndex = 7;
            totalcostlabel.Text = "Total cost:";
            // 
            // logInButton
            // 
            logInButton.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            logInButton.Location = new Point(560, 5);
            logInButton.Margin = new Padding(4, 5, 4, 5);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(264, 55);
            logInButton.TabIndex = 8;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.Location = new Point(560, 63);
            logOutButton.Margin = new Padding(4, 5, 4, 5);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(264, 55);
            logOutButton.TabIndex = 9;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Visible = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(273, 5);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(264, 55);
            backButton.TabIndex = 10;
            backButton.Text = "Go back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // purchasebutton
            // 
            purchasebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            purchasebutton.Location = new Point(1061, 747);
            purchasebutton.Name = "purchasebutton";
            purchasebutton.Size = new Size(204, 45);
            purchasebutton.TabIndex = 11;
            purchasebutton.Text = "Purchase";
            purchasebutton.UseVisualStyleBackColor = true;
            purchasebutton.Click += purchasebutton_Click;
            // 
            // categoryListBox
            // 
            categoryListBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            categoryListBox.FormattingEnabled = true;
            categoryListBox.ItemHeight = 28;
            categoryListBox.Location = new Point(214, 107);
            categoryListBox.Margin = new Padding(4, 5, 4, 5);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(201, 704);
            categoryListBox.TabIndex = 12;
            categoryListBox.SelectedIndexChanged += categoryListBox_SelectedIndexChanged;
            // 
            // itemsPanel
            // 
            itemsPanel.BorderStyle = BorderStyle.FixedSingle;
            itemsPanel.Controls.Add(nameLabel);
            itemsPanel.Controls.Add(mainPictureBox);
            itemsPanel.Controls.Add(colorLabel);
            itemsPanel.Controls.Add(sizeLabel);
            itemsPanel.Controls.Add(labelSize);
            itemsPanel.Controls.Add(priceLabel);
            itemsPanel.Controls.Add(addButton);
            itemsPanel.Controls.Add(labelColor);
            itemsPanel.Controls.Add(labelName);
            itemsPanel.Controls.Add(labelPrice);
            itemsPanel.Location = new Point(440, 143);
            itemsPanel.Margin = new Padding(4, 5, 4, 5);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(652, 600);
            itemsPanel.TabIndex = 13;
            itemsPanel.Visible = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(229, 417);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(83, 32);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Name:";
            // 
            // mainPictureBox
            // 
            mainPictureBox.Location = new Point(24, 5);
            mainPictureBox.Margin = new Padding(4, 5, 4, 5);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(604, 343);
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPictureBox.TabIndex = 5;
            mainPictureBox.TabStop = false;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorLabel.Location = new Point(229, 480);
            colorLabel.Margin = new Padding(4, 0, 4, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(83, 32);
            colorLabel.TabIndex = 12;
            colorLabel.Text = "Color: ";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sizeLabel.Location = new Point(229, 352);
            sizeLabel.Margin = new Padding(4, 0, 4, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(109, 32);
            sizeLabel.TabIndex = 15;
            sizeLabel.Text = "One Size";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSize.Location = new Point(114, 352);
            labelSize.Margin = new Padding(4, 0, 4, 0);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(69, 32);
            labelSize.TabIndex = 14;
            labelSize.Text = "Size: ";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(229, 540);
            priceLabel.Margin = new Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(70, 32);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Price:";
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(360, 538);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(143, 37);
            addButton.TabIndex = 10;
            addButton.Text = "Add to cart";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelColor.Location = new Point(100, 480);
            labelColor.Margin = new Padding(4, 0, 4, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(83, 32);
            labelColor.TabIndex = 9;
            labelColor.Text = "Color: ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(94, 417);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(90, 32);
            labelName.TabIndex = 8;
            labelName.Text = "Name: ";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(111, 540);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(70, 32);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price:";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 935);
            Controls.Add(itemsPanel);
            Controls.Add(categoryListBox);
            Controls.Add(purchasebutton);
            Controls.Add(backButton);
            Controls.Add(logOutButton);
            Controls.Add(logInButton);
            Controls.Add(totalcostlabel);
            Controls.Add(removeKundvagnButton);
            Controls.Add(KundvagnlistBox);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            itemsPanel.ResumeLayout(false);
            itemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button kundvagnButton;
        private ListBox KundvagnlistBox;
        private Button removeKundvagnButton;
        private Label totalcostlabel;
        public Button logInButton;
        public Button logOutButton;
        private Button backButton;
        private Button purchasebutton;
        private ListBox categoryListBox;
        private Panel itemsPanel;
        private Label nameLabel;
        private PictureBox mainPictureBox;
        private Label colorLabel;
        private Label sizeLabel;
        private Label labelSize;
        private Label priceLabel;
        private Button addButton;
        private Label labelColor;
        private Label labelName;
        private Label labelPrice;
        private LinkLabel hatsLinkLabel;
        private Label categoryLabel;
        private LinkLabel capLinkLabel;
        private LinkLabel accessoriesLinkLabel;
        private LinkLabel dressesLinkLabel;
        private LinkLabel coatsLinkLabel;
        private LinkLabel suitsLinkLabel;
    }
}