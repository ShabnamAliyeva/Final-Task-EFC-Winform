using Final_Task___Winform.Context;
using Final_Task___Winform.Entities;
using Final_Task___Winform.Forms.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Task___Winform.Forms
{

    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new GameContext())
            {
                string username = txt_Login.Text;
                string password = txt_Parol.Text;


                Employee employee = new Employee();
                var employeeName = employee.EmployeeName;

                Admin admin1 = new Admin();
                var adminName = admin1.AdminName;



                var user = db.Employees.FirstOrDefault(u => u.EmployeeName == username && u.Password == password);
                var admin = db.Admins.FirstOrDefault(a => a.AdminName == username && a.Password == password);
                FormCore formCore = new FormCore();
                FormAdmin formAdmin = new FormAdmin();
                FormCoreUser formCoreUser = new FormCoreUser();
                if (user != null || username == employeeName)
                {
                    MessageBox.Show($"User login successful! Welcome {username}!");
                    formCoreUser.Show();
                    this.Close();

                }
                else if (admin != null || username == adminName)
                {

                    MessageBox.Show($"Admin login successful! Welcome {username}!");
                    this.Close();
                    formCore.Show();



                }
                else
                {
                    MessageBox.Show("Access denied!");
                }
            }

        }

        private void txt_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Parol_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdmin formAdmin1 = new FormAdmin();
            this.Close();
            FormNewAccount formNewAccount = new FormNewAccount();
            formNewAccount.ShowDialog();
        }
    }
}
