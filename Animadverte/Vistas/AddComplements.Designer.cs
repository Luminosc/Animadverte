namespace Animadverte
{
    partial class AddComplements
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.ButtonFace;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(768, 76);
            Title.TabIndex = 10;
            Title.Text = "Add New Complements";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Stencil", 21.75F);
            textBox1.Location = new Point(311, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 42);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(9, 88);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 12;
            label1.Text = "Items";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Stencil", 21.75F);
            textBox2.Location = new Point(311, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 42);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(9, 184);
            label2.Name = "label2";
            label2.Size = new Size(265, 34);
            label2.TabIndex = 14;
            label2.Text = "Number of Items";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Stencil", 21.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(311, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(275, 42);
            comboBox1.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(511, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(406, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddComplements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(775, 307);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "AddComplements";
            Text = "AddComplements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
    }
}