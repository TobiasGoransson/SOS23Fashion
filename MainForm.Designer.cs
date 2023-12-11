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
            mainLogInButton = new Button();
            button1 = new Button();
            logOutButton = new Button();
            SuspendLayout();
            // 
            // mainLogInButton
            // 
            mainLogInButton.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mainLogInButton.Location = new Point(798, 15);
            mainLogInButton.Margin = new Padding(3, 4, 3, 4);
            mainLogInButton.Name = "mainLogInButton";
            mainLogInButton.Size = new Size(182, 44);
            mainLogInButton.TabIndex = 3;
            mainLogInButton.Text = "Log In";
            mainLogInButton.UseVisualStyleBackColor = true;
            mainLogInButton.Click += mainLogInButton_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Skärmbild_2023_12_05_144420;
            button1.Location = new Point(346, 467);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(358, 470);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.Location = new Point(798, 67);
            logOutButton.Margin = new Padding(3, 4, 3, 4);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(182, 44);
            logOutButton.TabIndex = 5;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Visible = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.EnLL5_EXMAABrTn;
            ClientSize = new Size(1023, 1026);
            Controls.Add(logOutButton);
            Controls.Add(button1);
            Controls.Add(mainLogInButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        public Button mainLogInButton;
        private Button button1;
        public Button logOutButton;
    }
}