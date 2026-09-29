namespace Animadverte
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            AddTableButton = new PictureBox();
            SettingsButton = new PictureBox();
            UserImageButton = new PictureBox();
            UserName = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AddTableButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserImageButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(98, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 412);
            panel1.TabIndex = 15;
            // 
            // AddTableButton
            // 
            AddTableButton.AccessibleRole = AccessibleRole.TitleBar;
            AddTableButton.Image = (Image)resources.GetObject("AddTableButton.Image");
            AddTableButton.Location = new Point(1072, 504);
            AddTableButton.Name = "AddTableButton";
            AddTableButton.Size = new Size(80, 80);
            AddTableButton.SizeMode = PictureBoxSizeMode.StretchImage;
            AddTableButton.TabIndex = 14;
            AddTableButton.TabStop = false;
            AddTableButton.Click += AddTableButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.AccessibleRole = AccessibleRole.TitleBar;
            SettingsButton.Image = (Image)resources.GetObject("SettingsButton.Image");
            SettingsButton.Location = new Point(12, 504);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(80, 80);
            SettingsButton.SizeMode = PictureBoxSizeMode.StretchImage;
            SettingsButton.TabIndex = 13;
            SettingsButton.TabStop = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // UserImageButton
            // 
            UserImageButton.AccessibleRole = AccessibleRole.TitleBar;
            UserImageButton.Image = (Image)resources.GetObject("UserImageButton.Image");
            UserImageButton.Location = new Point(12, 12);
            UserImageButton.Name = "UserImageButton";
            UserImageButton.Size = new Size(80, 80);
            UserImageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            UserImageButton.TabIndex = 12;
            UserImageButton.TabStop = false;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.ForeColor = SystemColors.ButtonFace;
            UserName.Location = new Point(98, 12);
            UserName.Name = "UserName";
            UserName.Size = new Size(381, 76);
            UserName.TabIndex = 11;
            UserName.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.TitleBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(986, 504);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.TitleBar;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(900, 504);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1164, 596);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(AddTableButton);
            Controls.Add(SettingsButton);
            Controls.Add(UserImageButton);
            Controls.Add(UserName);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)AddTableButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserImageButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox AddTableButton;
        private PictureBox SettingsButton;
        private PictureBox UserImageButton;
        private Label UserName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}