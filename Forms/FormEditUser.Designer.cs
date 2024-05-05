namespace Final_Task___Winform.Forms
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            btnLoginEditUser = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_ParolEditUser = new TextBox();
            pictureBox1 = new PictureBox();
            txt_LoginEditUser = new TextBox();
            lblLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoginEditUser
            // 
            btnLoginEditUser.BackColor = Color.DarkSlateBlue;
            btnLoginEditUser.FlatAppearance.BorderColor = Color.Black;
            btnLoginEditUser.FlatAppearance.BorderSize = 0;
            btnLoginEditUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEditUser.ForeColor = Color.White;
            btnLoginEditUser.Location = new Point(410, 366);
            btnLoginEditUser.Name = "btnLoginEditUser";
            btnLoginEditUser.Size = new Size(148, 47);
            btnLoginEditUser.TabIndex = 38;
            btnLoginEditUser.Text = "Update";
            btnLoginEditUser.UseVisualStyleBackColor = false;
            btnLoginEditUser.Click += btnLoginEditUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(346, 265);
            label2.Name = "label2";
            label2.Size = new Size(249, 28);
            label2.TabIndex = 37;
            label2.Text = "Enter your New Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(350, 170);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 36;
            label1.Text = "Enter your Username:";
            // 
            // txt_ParolEditUser
            // 
            txt_ParolEditUser.BackColor = SystemColors.InactiveBorder;
            txt_ParolEditUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ParolEditUser.ForeColor = Color.Black;
            txt_ParolEditUser.Location = new Point(352, 309);
            txt_ParolEditUser.Name = "txt_ParolEditUser";
            txt_ParolEditUser.Size = new Size(271, 27);
            txt_ParolEditUser.TabIndex = 35;
            txt_ParolEditUser.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 247);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // txt_LoginEditUser
            // 
            txt_LoginEditUser.BackColor = SystemColors.InactiveBorder;
            txt_LoginEditUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_LoginEditUser.ForeColor = Color.Black;
            txt_LoginEditUser.Location = new Point(352, 213);
            txt_LoginEditUser.Name = "txt_LoginEditUser";
            txt_LoginEditUser.Size = new Size(271, 27);
            txt_LoginEditUser.TabIndex = 33;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold | FontStyle.Italic);
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            lblLogo.Location = new Point(314, 89);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(359, 90);
            lblLogo.TabIndex = 32;
            lblLogo.Text = "Edit your informations :\r\n\r\n";
            // 
            // FormEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(786, 459);
            Controls.Add(btnLoginEditUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ParolEditUser);
            Controls.Add(pictureBox1);
            Controls.Add(txt_LoginEditUser);
            Controls.Add(lblLogo);
            Name = "FormEditUser";
            Text = "FormEditUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginEditUser;
        private Label label2;
        private Label label1;
        private TextBox txt_ParolEditUser;
        private PictureBox pictureBox1;
        private TextBox txt_LoginEditUser;
        private Label lblLogo;
    }
}