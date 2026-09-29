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
            button1 = new Button();
            PasswordTBox = new TextBox();
            UserNameTBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(364, 333);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordTBox
            // 
            PasswordTBox.Font = new Font("Stencil", 26.25F);
            PasswordTBox.Location = new Point(247, 252);
            PasswordTBox.Name = "PasswordTBox";
            PasswordTBox.PasswordChar = '*';
            PasswordTBox.Size = new Size(565, 49);
            PasswordTBox.TabIndex = 15;
            // 
            // UserNameTBox
            // 
            UserNameTBox.Font = new Font("Stencil", 26.25F);
            UserNameTBox.Location = new Point(247, 164);
            UserNameTBox.Name = "UserNameTBox";
            UserNameTBox.Size = new Size(565, 49);
            UserNameTBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(16, 255);
            label3.Name = "label3";
            label3.Size = new Size(200, 42);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(57, 167);
            label2.Name = "label2";
            label2.Size = new Size(107, 42);
            label2.TabIndex = 12;
            label2.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(305, 16);
            label1.Name = "label1";
            label1.Size = new Size(215, 76);
            label1.TabIndex = 11;
            label1.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(829, 376);
            Controls.Add(button1);
            Controls.Add(PasswordTBox);
            Controls.Add(UserNameTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox PasswordTBox;
        private TextBox UserNameTBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
