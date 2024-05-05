namespace Final_Task___Winform
{
    partial class FormCore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCore));
            panelMenu = new Panel();
            buttonLogoutUser = new Button();
            buttonDashboardUser = new Button();
            buttonSettingUser = new Button();
            buttonCategoryUser = new Button();
            buttonGamesUser = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelTitleBar = new Panel();
            btnAdminLg = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            pictureBox2 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(13, 13, 13);
            panelMenu.Controls.Add(buttonLogoutUser);
            panelMenu.Controls.Add(buttonDashboardUser);
            panelMenu.Controls.Add(buttonSettingUser);
            panelMenu.Controls.Add(buttonCategoryUser);
            panelMenu.Controls.Add(buttonGamesUser);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(282, 671);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // buttonLogoutUser
            // 
            buttonLogoutUser.FlatAppearance.BorderSize = 0;
            buttonLogoutUser.FlatStyle = FlatStyle.Flat;
            buttonLogoutUser.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogoutUser.ForeColor = SystemColors.ActiveBorder;
            buttonLogoutUser.Image = (Image)resources.GetObject("buttonLogoutUser.Image");
            buttonLogoutUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogoutUser.Location = new Point(0, 568);
            buttonLogoutUser.Name = "buttonLogoutUser";
            buttonLogoutUser.Padding = new Padding(14, 8, 0, 0);
            buttonLogoutUser.Size = new Size(282, 85);
            buttonLogoutUser.TabIndex = 6;
            buttonLogoutUser.Text = "      Logout";
            buttonLogoutUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogoutUser.UseVisualStyleBackColor = true;
            buttonLogoutUser.Click += buttonLogout_Click;
            // 
            // buttonDashboardUser
            // 
            buttonDashboardUser.FlatAppearance.BorderSize = 0;
            buttonDashboardUser.FlatStyle = FlatStyle.Flat;
            buttonDashboardUser.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboardUser.ForeColor = SystemColors.ActiveBorder;
            buttonDashboardUser.Image = (Image)resources.GetObject("buttonDashboardUser.Image");
            buttonDashboardUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboardUser.Location = new Point(0, 351);
            buttonDashboardUser.Name = "buttonDashboardUser";
            buttonDashboardUser.Padding = new Padding(10, 8, 0, 0);
            buttonDashboardUser.Size = new Size(282, 85);
            buttonDashboardUser.TabIndex = 5;
            buttonDashboardUser.Text = "     Dashboard";
            buttonDashboardUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboardUser.UseVisualStyleBackColor = true;
            buttonDashboardUser.Click += buttonDashboard_Click;
            // 
            // buttonSettingUser
            // 
            buttonSettingUser.FlatAppearance.BorderSize = 0;
            buttonSettingUser.FlatStyle = FlatStyle.Flat;
            buttonSettingUser.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSettingUser.ForeColor = SystemColors.ActiveBorder;
            buttonSettingUser.Image = (Image)resources.GetObject("buttonSettingUser.Image");
            buttonSettingUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettingUser.Location = new Point(0, 465);
            buttonSettingUser.Name = "buttonSettingUser";
            buttonSettingUser.Padding = new Padding(14, 8, 0, 0);
            buttonSettingUser.Size = new Size(282, 85);
            buttonSettingUser.TabIndex = 4;
            buttonSettingUser.Text = "      Settings";
            buttonSettingUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSettingUser.UseVisualStyleBackColor = true;
            buttonSettingUser.Click += buttonSetting_Click;
            // 
            // buttonCategoryUser
            // 
            buttonCategoryUser.FlatAppearance.BorderSize = 0;
            buttonCategoryUser.FlatStyle = FlatStyle.Flat;
            buttonCategoryUser.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCategoryUser.ForeColor = SystemColors.ActiveBorder;
            buttonCategoryUser.Image = (Image)resources.GetObject("buttonCategoryUser.Image");
            buttonCategoryUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategoryUser.Location = new Point(-2, 243);
            buttonCategoryUser.Name = "buttonCategoryUser";
            buttonCategoryUser.Padding = new Padding(18, 8, 0, 0);
            buttonCategoryUser.Size = new Size(282, 85);
            buttonCategoryUser.TabIndex = 2;
            buttonCategoryUser.Text = "        Category";
            buttonCategoryUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCategoryUser.UseVisualStyleBackColor = true;
            buttonCategoryUser.Click += buttonCategory_Click;
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
            buttonGamesUser.Click += buttonGames_Click;
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
            panelLogo.Paint += panelLogo_Paint;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold | FontStyle.Italic);
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            lblLogo.Location = new Point(33, 33);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(207, 45);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "Game Center\r\n";
            lblLogo.Click += label1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Indigo;
            panelTitleBar.Controls.Add(btnAdminLg);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(282, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1077, 108);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            // 
            // btnAdminLg
            // 
            btnAdminLg.BackColor = Color.Transparent;
            btnAdminLg.Dock = DockStyle.Right;
            btnAdminLg.FlatAppearance.BorderSize = 0;
            btnAdminLg.FlatStyle = FlatStyle.Flat;
            btnAdminLg.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLg.ForeColor = SystemColors.ActiveBorder;
            btnAdminLg.Image = (Image)resources.GetObject("btnAdminLg.Image");
            btnAdminLg.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminLg.Location = new Point(990, 0);
            btnAdminLg.Name = "btnAdminLg";
            btnAdminLg.Padding = new Padding(12, 10, 0, 0);
            btnAdminLg.Size = new Size(87, 108);
            btnAdminLg.TabIndex = 6;
            btnAdminLg.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminLg.UseVisualStyleBackColor = false;
            btnAdminLg.Click += btnAdminLg_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.BackColor = Color.Indigo;
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseChildForm.ForeColor = SystemColors.ActiveBorder;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Padding = new Padding(12, 0, 0, 0);
            btnCloseChildForm.Size = new Size(87, 108);
            btnCloseChildForm.TabIndex = 5;
            btnCloseChildForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCloseChildForm.UseVisualStyleBackColor = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Roboto", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(492, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(88, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Controls.Add(pictureBox2);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(282, 108);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1077, 563);
            panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1077, 563);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FormCore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            ClientSize = new Size(1359, 671);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormCore";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonGamesUser;
        private Button buttonCategoryUser;
        private Button buttonSettingUser;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label lblLogo;
        private Panel panelDesktopPanel;
        private Button btnCloseChildForm;
        private PictureBox pictureBox2;
        private Button buttonDashboardUser;
        private Button buttonLogoutUser;
        private Button btnAdminLg;
    }
}
