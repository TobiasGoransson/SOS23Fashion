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
            SuspendLayout();
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
            // button1
            // 
            button1.Image = Properties.Resources.Skärmbild_2023_12_05_144420;
            button1.Location = new Point(357, 422);
            button1.Name = "button1";
            button1.Size = new Size(313, 431);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.EnLL5_EXMAABrTn1;
            ClientSize = new Size(1024, 1024);
            Controls.Add(button1);
            Controls.Add(mainLogInButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private Button mainLogInButton;
        private Button button1;
    }
}