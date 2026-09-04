namespace Animadverte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            UserName = new Label();
            UserImageButton = new PictureBox();
            SettingsButton = new PictureBox();
            AddTableButton = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)UserImageButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddTableButton).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.ForeColor = SystemColors.ButtonFace;
            UserName.Location = new Point(98, 12);
            UserName.Name = "UserName";
            UserName.Size = new Size(381, 76);
            UserName.TabIndex = 6;
            UserName.Text = "User Name";
            // 
            // UserImageButton
            // 
            UserImageButton.AccessibleRole = AccessibleRole.TitleBar;
            UserImageButton.Image = (Image)resources.GetObject("UserImageButton.Image");
            UserImageButton.Location = new Point(12, 12);
            UserImageButton.Name = "UserImageButton";
            UserImageButton.Size = new Size(80, 80);
            UserImageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            UserImageButton.TabIndex = 7;
            UserImageButton.TabStop = false;
            // 
            // SettingsButton
            // 
            SettingsButton.AccessibleRole = AccessibleRole.TitleBar;
            SettingsButton.Image = (Image)resources.GetObject("SettingsButton.Image");
            SettingsButton.Location = new Point(12, 504);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(80, 80);
            SettingsButton.SizeMode = PictureBoxSizeMode.StretchImage;
            SettingsButton.TabIndex = 8;
            SettingsButton.TabStop = false;
            // 
            // AddTableButton
            // 
            AddTableButton.AccessibleRole = AccessibleRole.TitleBar;
            AddTableButton.Image = (Image)resources.GetObject("AddTableButton.Image");
            AddTableButton.Location = new Point(1072, 504);
            AddTableButton.Name = "AddTableButton";
            AddTableButton.Size = new Size(80, 80);
            AddTableButton.SizeMode = PictureBoxSizeMode.StretchImage;
            AddTableButton.TabIndex = 9;
            AddTableButton.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(98, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 412);
            panel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1164, 596);
            Controls.Add(panel1);
            Controls.Add(AddTableButton);
            Controls.Add(SettingsButton);
            Controls.Add(UserImageButton);
            Controls.Add(UserName);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)UserImageButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddTableButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private PictureBox UserImageButton;
        private PictureBox SettingsButton;
        private PictureBox AddTableButton;
        private Panel panel1;
    }
}
