namespace Animadverte.Vistas
{
    partial class Complement
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
            textBox1 = new TextBox();
            label2 = new Label();
            ComputerTBox = new ComboBox();
            label1 = new Label();
            UserName = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(629, 347);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 34;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(548, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(288, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 54);
            textBox1.TabIndex = 32;
            textBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(96, 265);
            label2.Name = "label2";
            label2.Size = new Size(186, 42);
            label2.TabIndex = 31;
            label2.Text = "Quantity";
            // 
            // ComputerTBox
            // 
            ComputerTBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputerTBox.FormattingEnabled = true;
            ComputerTBox.Location = new Point(203, 173);
            ComputerTBox.Name = "ComputerTBox";
            ComputerTBox.Size = new Size(501, 55);
            ComputerTBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(96, 183);
            label1.Name = "label1";
            label1.Size = new Size(101, 42);
            label1.TabIndex = 29;
            label1.Text = "Item";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.ForeColor = SystemColors.ButtonFace;
            UserName.Location = new Point(96, 80);
            UserName.Name = "UserName";
            UserName.Size = new Size(478, 76);
            UserName.TabIndex = 28;
            UserName.Text = "Complements";
            // 
            // Complement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(ComputerTBox);
            Controls.Add(label1);
            Controls.Add(UserName);
            Name = "Complement";
            Text = "Complement";
            Load += Complement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox ComputerTBox;
        private Label label1;
        private Label UserName;
    }
}