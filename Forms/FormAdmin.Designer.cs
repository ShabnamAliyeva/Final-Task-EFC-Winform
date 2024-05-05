namespace Final_Task___Winform.Forms
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            lblLogo = new Label();
            txt_Login = new TextBox();
            pictureBox1 = new PictureBox();
            txt_Parol = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold | FontStyle.Italic);
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            lblLogo.Location = new Point(233, 108);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(402, 45);
            lblLogo.TabIndex = 3;
            lblLogo.Text = "Welcome the Game Center";
            // 
            // txt_Login
            // 
            txt_Login.BackColor = SystemColors.InactiveBorder;
            txt_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Login.ForeColor = Color.Black;
            txt_Login.Location = new Point(271, 232);
            txt_Login.Name = "txt_Login";
            txt_Login.Size = new Size(271, 27);
            txt_Login.TabIndex = 17;
            txt_Login.TextChanged += txt_Login_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 247);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txt_Parol
            // 
            txt_Parol.BackColor = SystemColors.InactiveBorder;
            txt_Parol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Parol.ForeColor = Color.Black;
            txt_Parol.Location = new Point(271, 328);
            txt_Parol.Name = "txt_Parol";
            txt_Parol.Size = new Size(271, 27);
            txt_Parol.TabIndex = 19;
            txt_Parol.UseSystemPasswordChar = true;
            txt_Parol.TextChanged += txt_Parol_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(264, 189);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 20;
            label1.Text = "Enter your Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(265, 284);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 21;
            label2.Text = "Enter your Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateBlue;
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(325, 379);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 47);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.SlateBlue;
            linkLabel1.Location = new Point(315, 450);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 23);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create your acoount";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(682, 503);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Parol);
            Controls.Add(pictureBox1);
            Controls.Add(txt_Login);
            Controls.Add(lblLogo);
            ForeColor = Color.White;
            Name = "FormAdmin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private TextBox txt_Login;
        private PictureBox pictureBox1;
        private TextBox txt_Parol;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private LinkLabel linkLabel1;
    }
}