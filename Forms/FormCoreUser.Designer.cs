namespace Final_Task___Winform.Forms.Repositories
{
    partial class FormCoreUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoreUser));
            panelDesktopPanel = new Panel();
            pictureBox2 = new PictureBox();
            panelTitleBarUser = new Panel();
            btnUserLg = new Button();
            lblTitleUser = new Label();
            btnCloseChildFormUser = new Button();
            panelMenuUser = new Panel();
            buttonLogout = new Button();
            buttonDashboard = new Button();
            buttonCategory = new Button();
            buttonGamesUser = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTitleBarUser.SuspendLayout();
            panelMenuUser.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Controls.Add(pictureBox2);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(282, 108);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(669, 449);
            panelDesktopPanel.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(21, 21, 21);
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(669, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panelTitleBarUser
            // 
            panelTitleBarUser.BackColor = Color.Indigo;
            panelTitleBarUser.Controls.Add(btnUserLg);
            panelTitleBarUser.Controls.Add(lblTitleUser);
            panelTitleBarUser.Controls.Add(btnCloseChildFormUser);
            panelTitleBarUser.Dock = DockStyle.Top;
            panelTitleBarUser.Location = new Point(282, 0);
            panelTitleBarUser.Name = "panelTitleBarUser";
            panelTitleBarUser.Size = new Size(669, 108);
            panelTitleBarUser.TabIndex = 4;
            // 
            // btnUserLg
            // 
            btnUserLg.BackColor = Color.Transparent;
            btnUserLg.Dock = DockStyle.Right;
            btnUserLg.FlatAppearance.BorderSize = 0;
            btnUserLg.FlatStyle = FlatStyle.Flat;
            btnUserLg.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserLg.ForeColor = SystemColors.ActiveBorder;
            btnUserLg.Image = (Image)resources.GetObject("btnUserLg.Image");
            btnUserLg.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserLg.Location = new Point(582, 0);
            btnUserLg.Name = "btnUserLg";
            btnUserLg.Padding = new Padding(12, 10, 0, 0);
            btnUserLg.Size = new Size(87, 108);
            btnUserLg.TabIndex = 7;
            btnUserLg.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserLg.UseVisualStyleBackColor = false;
            btnUserLg.Click += btnUserLg_Click;
            // 
            // lblTitleUser
            // 
            lblTitleUser.Anchor = AnchorStyles.None;
            lblTitleUser.AutoSize = true;
            lblTitleUser.Font = new Font("Roboto", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleUser.ForeColor = Color.White;
            lblTitleUser.Location = new Point(295, 44);
            lblTitleUser.Name = "lblTitleUser";
            lblTitleUser.Size = new Size(88, 30);
            lblTitleUser.TabIndex = 6;
            lblTitleUser.Text = "HOME";
            // 
            // btnCloseChildFormUser
            // 
            btnCloseChildFormUser.BackColor = Color.Indigo;
            btnCloseChildFormUser.Dock = DockStyle.Left;
            btnCloseChildFormUser.FlatAppearance.BorderSize = 0;
            btnCloseChildFormUser.FlatStyle = FlatStyle.Flat;
            btnCloseChildFormUser.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseChildFormUser.ForeColor = SystemColors.ActiveBorder;
            btnCloseChildFormUser.Image = (Image)resources.GetObject("btnCloseChildFormUser.Image");
            btnCloseChildFormUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseChildFormUser.Location = new Point(0, 0);
            btnCloseChildFormUser.Name = "btnCloseChildFormUser";
            btnCloseChildFormUser.Padding = new Padding(12, 0, 0, 0);
            btnCloseChildFormUser.Size = new Size(87, 108);
            btnCloseChildFormUser.TabIndex = 5;
            btnCloseChildFormUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCloseChildFormUser.UseVisualStyleBackColor = false;
            btnCloseChildFormUser.Click += btnCloseChildFormUser_Click;
            // 
            // panelMenuUser
            // 
            panelMenuUser.BackColor = Color.FromArgb(13, 13, 13);
            panelMenuUser.Controls.Add(buttonLogout);
            panelMenuUser.Controls.Add(buttonDashboard);
            panelMenuUser.Controls.Add(buttonCategory);
            panelMenuUser.Controls.Add(buttonGamesUser);
            panelMenuUser.Controls.Add(panelLogo);
            panelMenuUser.Dock = DockStyle.Left;
            panelMenuUser.Location = new Point(0, 0);
            panelMenuUser.Name = "panelMenuUser";
            panelMenuUser.Size = new Size(282, 557);
            panelMenuUser.TabIndex = 3;
            // 
            // buttonLogout
            // 
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ActiveBorder;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(0, 472);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(14, 8, 0, 0);
            buttonLogout.Size = new Size(282, 82);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "      Logout";
            buttonLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = SystemColors.ActiveBorder;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(0, 351);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(10, 8, 0, 0);
            buttonDashboard.Size = new Size(282, 85);
            buttonDashboard.TabIndex = 5;
            buttonDashboard.Text = "     Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboardUser_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.FlatAppearance.BorderSize = 0;
            buttonCategory.FlatStyle = FlatStyle.Flat;
            buttonCategory.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCategory.ForeColor = SystemColors.ActiveBorder;
            buttonCategory.Image = (Image)resources.GetObject("buttonCategory.Image");
            buttonCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategory.Location = new Point(-2, 243);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Padding = new Padding(18, 8, 0, 0);
            buttonCategory.Size = new Size(282, 85);
            buttonCategory.TabIndex = 2;
            buttonCategory.Text = "        Category";
            buttonCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCategory.UseVisualStyleBackColor = true;
            buttonCategory.Click += buttonCategoryUser_Click;
            // 
            // buttonGamesUser
            // 
            buttonGamesUser.FlatAppearance.BorderSize = 0;
            buttonGamesUser.FlatStyle = FlatStyle.Flat;
            buttonGamesUser.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGamesUser.ForeColor = SystemColors.ActiveBorder;
            buttonGamesUser.Image = (Image)resources.GetObject("buttonGamesUser.Image");
            buttonGamesUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGamesUser.Location = new Point(0, 138);
            buttonGamesUser.Name = "buttonGamesUser";
            buttonGamesUser.Padding = new Padding(12, 8, 0, 0);
            buttonGamesUser.Size = new Size(282, 85);
            buttonGamesUser.TabIndex = 1;
            buttonGamesUser.Text = "       Games";
            buttonGamesUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGamesUser.UseVisualStyleBackColor = true;
            buttonGamesUser.Click += buttonGamesUser_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(282, 108);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold | FontStyle.Italic);
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            lblLogo.Location = new Point(35, 34);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(207, 45);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "Game Center\r\n";
            // 
            // FormCoreUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 557);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBarUser);
            Controls.Add(panelMenuUser);
            Name = "FormCoreUser";
            Text = "Form1";
            panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTitleBarUser.ResumeLayout(false);
            panelTitleBarUser.PerformLayout();
            panelMenuUser.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDesktopPanel;
        private PictureBox pictureBox2;
        private Panel panelTitleBarUser;
        private Button btnCloseChildFormUser;
        private Panel panelMenuUser;
        private Button buttonLogout;
        private Button buttonDashboard;
        private Button buttonCategory;
        private Button buttonGamesUser;
        private Panel panelLogo;
        private Label lblLogo;
        private Label lblTitleUser;
        private Button btnUserLg;
    }
}