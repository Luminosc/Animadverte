namespace Animadverte
{
    partial class NewTable
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
            label1 = new Label();
            label2 = new Label();
            NDestCombobox = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SaveBut = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.ButtonFace;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(375, 76);
            Title.TabIndex = 7;
            Title.Text = "New Table";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(330, 42);
            label1.TabIndex = 8;
            label1.Text = "Number of Desks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(57, 215);
            label2.Name = "label2";
            label2.Size = new Size(224, 42);
            label2.TabIndex = 9;
            label2.Text = "Start Host";
            // 
            // NDestCombobox
            // 
            NDestCombobox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NDestCombobox.FormattingEnabled = true;
            NDestCombobox.Location = new Point(348, 108);
            NDestCombobox.Name = "NDestCombobox";
            NDestCombobox.Size = new Size(426, 55);
            NDestCombobox.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(810, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 54);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(348, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 54);
            textBox2.TabIndex = 12;
            // 
            // SaveBut
            // 
            SaveBut.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBut.Location = new Point(909, 305);
            SaveBut.Name = "SaveBut";
            SaveBut.Size = new Size(108, 52);
            SaveBut.TabIndex = 13;
            SaveBut.Text = "Save";
            SaveBut.UseVisualStyleBackColor = true;
            // 
            // NewTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1164, 596);
            Controls.Add(SaveBut);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(NDestCombobox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "NewTable";
            Text = "NewTable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private ComboBox NDestCombobox;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button SaveBut;
    }
}