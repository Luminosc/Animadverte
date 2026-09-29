namespace Animadverte.Vistas
{
    partial class Device
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
            button2 = new Button();
            button1 = new Button();
            UserNameTBox = new TextBox();
            label1 = new Label();
            UserName = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ComputerTBox = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(572, 417);
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
            button1.Location = new Point(491, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // UserNameTBox
            // 
            UserNameTBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTBox.Location = new Point(375, 100);
            UserNameTBox.Name = "UserNameTBox";
            UserNameTBox.Size = new Size(272, 54);
            UserNameTBox.TabIndex = 21;
            UserNameTBox.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(9, 109);
            label1.Name = "label1";
            label1.Size = new Size(340, 42);
            label1.TabIndex = 20;
            label1.Text = "Number Of Device";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.ForeColor = SystemColors.ButtonFace;
            UserName.Location = new Point(12, 9);
            UserName.Name = "UserName";
            UserName.Size = new Size(251, 76);
            UserName.TabIndex = 19;
            UserName.Text = "Device";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(375, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 54);
            textBox1.TabIndex = 25;
            textBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(9, 182);
            label2.Name = "label2";
            label2.Size = new Size(289, 42);
            label2.TabIndex = 24;
            label2.Text = "Serial Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(9, 254);
            label3.Name = "label3";
            label3.Size = new Size(130, 42);
            label3.TabIndex = 26;
            label3.Text = "Model";
            // 
            // ComputerTBox
            // 
            ComputerTBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputerTBox.FormattingEnabled = true;
            ComputerTBox.Location = new Point(375, 245);
            ComputerTBox.Name = "ComputerTBox";
            ComputerTBox.Size = new Size(272, 55);
            ComputerTBox.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(375, 316);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 55);
            comboBox1.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(9, 325);
            label4.Name = "label4";
            label4.Size = new Size(107, 42);
            label4.TabIndex = 28;
            label4.Text = "User";
            // 
            // Device
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(673, 457);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(ComputerTBox);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UserNameTBox);
            Controls.Add(label1);
            Controls.Add(UserName);
            Name = "Device";
            Text = "Device";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox UserNameTBox;
        private Label label1;
        private Label UserName;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox ComputerTBox;
        private ComboBox comboBox1;
        private Label label4;
    }
}