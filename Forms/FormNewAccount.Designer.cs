namespace Final_Task___Winform.Forms
{
    partial class FormNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewAccount));
            btnLoginNew = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_ParolNew = new TextBox();
            pictureBox1 = new PictureBox();
            txt_LoginNew = new TextBox();
            lblLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoginNew
            // 
            btnLoginNew.BackColor = Color.DarkSlateBlue;
            btnLoginNew.FlatAppearance.BorderColor = Color.Black;
            btnLoginNew.FlatAppearance.BorderSize = 0;
            btnLoginNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginNew.ForeColor = Color.White;
            btnLoginNew.Location = new Point(340, 394);
            btnLoginNew.Name = "btnLoginNew";
            btnLoginNew.Size = new Size(148, 47);
            btnLoginNew.TabIndex = 29;
            btnLoginNew.Text = "Create";
            btnLoginNew.UseVisualStyleBackColor = false;
            btnLoginNew.Click += btnLoginNew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(280, 299);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 28;
            label2.Text = "Enter your Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(279, 204);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 27;
            label1.Text = "Enter your Username:";
            // 
            // txt_ParolNew
            // 
            txt_ParolNew.BackColor = SystemColors.InactiveBorder;
            txt_ParolNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ParolNew.ForeColor = Color.Black;
            txt_ParolNew.Location = new Point(286, 343);
            txt_ParolNew.Name = "txt_ParolNew";
            txt_ParolNew.Size = new Size(271, 27);
            txt_ParolNew.TabIndex = 26;
            txt_ParolNew.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 247);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // txt_LoginNew
            // 
            txt_LoginNew.BackColor = SystemColors.InactiveBorder;
            txt_LoginNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_LoginNew.ForeColor = Color.Black;
            txt_LoginNew.Location = new Point(286, 247);
            txt_LoginNew.Name = "txt_LoginNew";
            txt_LoginNew.Size = new Size(271, 27);
            txt_LoginNew.TabIndex = 24;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold | FontStyle.Italic);
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            lblLogo.Location = new Point(248, 123);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(402, 45);
            lblLogo.TabIndex = 23;
            lblLogo.Text = "Welcome the Game Center";
            // 
            // FormNewAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(732, 503);
            Controls.Add(btnLoginNew);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ParolNew);
            Controls.Add(pictureBox1);
            Controls.Add(txt_LoginNew);
            Controls.Add(lblLogo);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormNewAccount";
            Text = "FormNewAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginNew;
        private Label label2;
        private Label label1;
        private TextBox txt_ParolNew;
        private PictureBox pictureBox1;
        private TextBox txt_LoginNew;
        private Label lblLogo;
    }
}