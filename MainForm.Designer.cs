namespace SOSFashion
{
    partial class MainForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AssortmentPanel = new Panel();
            label1 = new Label();
            mainLogInButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            AssortmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.d09f4a7e4a332c15adbf9796767476051;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dsc04748_1920x10801;
            pictureBox2.Location = new Point(0, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(355, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // AssortmentPanel
            // 
            AssortmentPanel.BackColor = Color.Transparent;
            AssortmentPanel.Controls.Add(label1);
            AssortmentPanel.Controls.Add(pictureBox1);
            AssortmentPanel.Controls.Add(pictureBox2);
            AssortmentPanel.Location = new Point(332, 471);
            AssortmentPanel.Name = "AssortmentPanel";
            AssortmentPanel.Size = new Size(355, 506);
            AssortmentPanel.TabIndex = 2;
            AssortmentPanel.Click += AssortmentPanel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Modern No. 20", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 238);
            label1.Name = "label1";
            label1.Size = new Size(170, 34);
            label1.TabIndex = 2;
            label1.Text = "Assortment";
            // 
            // mainLogInButton
            // 
            mainLogInButton.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mainLogInButton.Location = new Point(920, 12);
            mainLogInButton.Name = "mainLogInButton";
            mainLogInButton.Size = new Size(92, 33);
            mainLogInButton.TabIndex = 3;
            mainLogInButton.Text = "Log In";
            mainLogInButton.UseVisualStyleBackColor = true;
            mainLogInButton.Click += mainLogInButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.EnLL5_EXMAABrTn1;
            ClientSize = new Size(1024, 1024);
            Controls.Add(mainLogInButton);
            Controls.Add(AssortmentPanel);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            AssortmentPanel.ResumeLayout(false);
            AssortmentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel AssortmentPanel;
        private Label label1;
        private Button mainLogInButton;
    }
}