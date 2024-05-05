//using Final_Task___Winform.Repositories.EFRespositories;
using Final_Task___Winform.Forms;
using System.Security.Permissions;

namespace Final_Task___Winform
{
    public partial class FormCore : Form
    {
        //private readonly GameRepository _gameRepository;
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //Constructor
        public FormCore()
        {
            //_gameRepository = new GameRepository();
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
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
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    lblLogo.ForeColor = Color.Black;
                    btnCloseChildForm.Visible = true;
                    btnCloseChildForm.BackColor = color;
                }
            }
        }



        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
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
            lblTitle.Text = childForm.Text;
        }


        private void buttonGames_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.FormGames(), sender);
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCategory(), sender);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);

        }
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            btnAdminLg.BackColor = Color.Transparent;
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormCore formCore = new FormCore();
            this.Close();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
        }

        private void btnAdminLg_Click(object sender, EventArgs e)
        {
        
            OpenChildForm(new Forms.FormEditAdmin(), sender);

        }
    
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.Indigo;
            panelLogo.BackColor = Color.Black;
            lblLogo.ForeColor = Color.FromArgb(128, 128, 255);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }




        //--------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
