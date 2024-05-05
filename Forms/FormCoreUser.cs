using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Task___Winform.Forms.Repositories
{
    public partial class FormCoreUser : Form
    {
        //private readonly GameRepository _gameRepository;
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //Constructor
        public FormCoreUser()
        {
            //_gameRepository = new GameRepository();
            InitializeComponent();
            random = new Random();
            btnCloseChildFormUser.Visible = false;
        }




        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    panelTitleBarUser.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    lblLogo.ForeColor = Color.Black;
                    btnCloseChildFormUser.Visible = true;
                    btnCloseChildFormUser.BackColor = color;
                }
            }
        }



        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuUser.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(13, 13, 13);
                    previousBtn.ForeColor = SystemColors.ActiveBorder;
                    previousBtn.Font = new Font("Segoe UI Emoji", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleUser.Text = childForm.Text;
        }


        private void buttonGamesUser_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.FormGames(), sender);
        }

        private void buttonCategoryUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCategory(), sender);
        }


        private void buttonDashboardUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);
        }

        private void btnCloseChildFormUser_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            ResetUser();
            btnUserLg.BackColor = Color.Transparent;
        }

        private void ResetUser()
        {
            DisableButton();
            lblTitleUser.Text = "HOME";
            panelTitleBarUser.BackColor = Color.Indigo;
            panelLogo.BackColor = Color.Black;
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            currentButton = null;
            btnCloseChildFormUser.Visible = false;
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormCoreUser formCoreUser = new FormCoreUser();
            this.Close();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
        }
        private void btnUserLg_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditUser(), sender);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
