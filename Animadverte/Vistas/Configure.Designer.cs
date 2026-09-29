namespace Animadverte
{
    partial class Configure
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
            Title = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.ButtonFace;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(380, 76);
            Title.TabIndex = 9;
            Title.Text = "Configure";
            // 
            // Configure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1210, 588);
            Controls.Add(Title);
            ForeColor = SystemColors.ButtonFace;
            Name = "Configure";
            Text = "Configure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
    }
}