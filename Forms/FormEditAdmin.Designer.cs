namespace Final_Task___Winform.Forms
{
    partial class FormEditAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAdmin));
            label2 = new Label();
            label1 = new Label();
            txt_ParolEditAdmin = new TextBox();
            pictureBox1 = new PictureBox();
            txt_LoginEditAdmin = new TextBox();
            lblLogo = new Label();
            btnLoginEditAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(315, 280);
            label2.Name = "label2";
            label2.Size = new Size(249, 28);
            label2.TabIndex = 28;
            label2.Text = "Enter your New Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(314, 185);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 27;
            label1.Text = "Enter your  Username:";
            // 
            // txt_ParolEditAdmin
            // 
            txt_ParolEditAdmin.BackColor = SystemColors.InactiveBorder;
            txt_ParolEditAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ParolEditAdmin.ForeColor = Color.Black;
            txt_ParolEditAdmin.Location = new Point(321, 324);
            txt_ParolEditAdmin.Name = "txt_ParolEditAdmin";
            txt_ParolEditAdmin.Size = new Size(271, 27);
            txt_ParolEditAdmin.TabIndex = 26;
            txt_ParolEditAdmin.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 247);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // txt_LoginEditAdmin
            // 
            txt_LoginEditAdmin.BackColor = SystemColors.InactiveBorder;
            txt_LoginEditAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_LoginEditAdmin.ForeColor = Color.Black;
            txt_LoginEditAdmin.Location = new Point(321, 228);
            txt_LoginEditAdmin.Name = "txt_LoginEditAdmin";
            txt_LoginEditAdmin.Size = new Size(271, 27);
            txt_LoginEditAdmin.TabIndex = 24;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold | FontStyle.Italic);
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            lblLogo.Location = new Point(283, 104);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(359, 90);
            lblLogo.TabIndex = 23;
            lblLogo.Text = "Edit your informations :\r\n\r\n";
            // 
            // btnLoginEditAdmin
            // 
            btnLoginEditAdmin.BackColor = Color.DarkSlateBlue;
            btnLoginEditAdmin.FlatAppearance.BorderColor = Color.Black;
            btnLoginEditAdmin.FlatAppearance.BorderSize = 0;
            btnLoginEditAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEditAdmin.ForeColor = Color.White;
            btnLoginEditAdmin.Location = new Point(381, 390);
            btnLoginEditAdmin.Name = "btnLoginEditAdmin";
            btnLoginEditAdmin.Size = new Size(148, 47);
            btnLoginEditAdmin.TabIndex = 31;
            btnLoginEditAdmin.Text = "Update";
            btnLoginEditAdmin.UseVisualStyleBackColor = false;
            btnLoginEditAdmin.Click += btnLoginEditAdmin_Click_1;
            // 
            // FormEditAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(732, 503);
            Controls.Add(btnLoginEditAdmin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ParolEditAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(txt_LoginEditAdmin);
            Controls.Add(lblLogo);
            Name = "FormEditAdmin";
            Text = "EditAdmin";
            Load += FormEditAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Button btnLoginUpdateAdmin;
        private Label label2;
        private Label label1;
        private TextBox txt_ParolEditAdmin;
        private TextBox txt_Parol;
        private PictureBox pictureBox1;
        private TextBox txt_LoginEditAdmin;
        private Label lblLogo;
        private Button btnLoginEditAdmin;
    }
}