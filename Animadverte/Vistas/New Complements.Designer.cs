namespace Animadverte
{
    partial class New_Complements
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
            ComputerTBox = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.ForeColor = SystemColors.ButtonFace;
            UserName.Location = new Point(12, 9);
            UserName.Name = "UserName";
            UserName.Size = new Size(628, 76);
            UserName.TabIndex = 14;
            UserName.Text = "New Complements";
            // 
            // UserNameTBox
            // 
            UserNameTBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTBox.Location = new Point(626, 108);
            UserNameTBox.Name = "UserNameTBox";
            UserNameTBox.Size = new Size(272, 54);
            UserNameTBox.TabIndex = 18;
            UserNameTBox.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(101, 42);
            label1.TabIndex = 17;
            label1.Text = "Item";
            // 
            // ComputerTBox
            // 
            ComputerTBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputerTBox.FormattingEnabled = true;
            ComputerTBox.Location = new Point(119, 107);
            ComputerTBox.Name = "ComputerTBox";
            ComputerTBox.Size = new Size(501, 55);
            ComputerTBox.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(204, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 54);
            textBox1.TabIndex = 21;
            textBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(186, 42);
            label2.TabIndex = 20;
            label2.Text = "Quantity";
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(823, 269);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(742, 269);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // New_Complements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(926, 383);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(ComputerTBox);
            Controls.Add(UserNameTBox);
            Controls.Add(label1);
            Controls.Add(UserName);
            Name = "New_Complements";
            Text = "New_Complements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private TextBox UserNameTBox;
        private Label label1;
        private ComboBox ComputerTBox;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}