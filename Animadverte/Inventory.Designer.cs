namespace Animadverte
{
    partial class Inventory
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
            listView1 = new ListView();
            listView2 = new ListView();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.ButtonFace;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(382, 76);
            Title.TabIndex = 8;
            Title.Text = "Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(130, 34);
            label1.TabIndex = 9;
            label1.Text = "Devices";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(600, 146);
            label2.Name = "label2";
            label2.Size = new Size(215, 34);
            label2.TabIndex = 10;
            label2.Text = "Complements";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 183);
            listView1.Name = "listView1";
            listView1.Size = new Size(552, 401);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(600, 183);
            listView2.Name = "listView2";
            listView2.Size = new Size(552, 401);
            listView2.TabIndex = 12;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1164, 596);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "Inventory";
            Text = "Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private ListView listView2;
    }
}