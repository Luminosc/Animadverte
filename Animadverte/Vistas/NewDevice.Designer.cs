namespace Animadverte
{
    partial class NewDevice
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
            UserName = new Label();
            UserNameTBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.ForeColor = SystemColors.ButtonFace;
            UserName.Location = new Point(12, 9);
            UserName.Name = "UserName";
            UserName.Size = new Size(437, 76);
            UserName.TabIndex = 12;
            UserName.Text = "New Devices";
            // 
            // UserNameTBox
            // 
            UserNameTBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTBox.Location = new Point(375, 100);
            UserNameTBox.Name = "UserNameTBox";
            UserNameTBox.Size = new Size(272, 54);
            UserNameTBox.TabIndex = 16;
            UserNameTBox.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(9, 109);
            label1.Name = "label1";
            label1.Size = new Size(360, 42);
            label1.TabIndex = 15;
            label1.Text = "Number Of Devices";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(491, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(572, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NewDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(665, 245);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UserNameTBox);
            Controls.Add(label1);
            Controls.Add(UserName);
            ForeColor = SystemColors.ButtonFace;
            Name = "NewDevice";
            Text = "NewDevice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private TextBox UserNameTBox;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}