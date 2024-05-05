using Final_Task___Winform.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }

        private async void btnLoginEditUser_Click(object sender, EventArgs e)
        {

            if (txt_ParolEditUser != null)
            {
                using (var context = new GameContext())
                {
                    string userNameToUpdate = txt_LoginEditUser.Text;
                    var userToUpdate = await context.Employees.FirstOrDefaultAsync(b => b.EmployeeName == userNameToUpdate);

                    if (userToUpdate != null)
                    {
                        userToUpdate.Password = txt_ParolEditUser.Text;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Admin's information updated!");
                    }
                }
            }
            else
            {
                MessageBox.Show("txt_Parol control is null. Check your form design and initialization.");
            }

        }
    }
}
