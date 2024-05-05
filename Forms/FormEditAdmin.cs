using Final_Task___Winform.Context;
using Final_Task___Winform.Entities;
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
    public partial class FormEditAdmin : Form
    {
        public FormEditAdmin()
        {
            InitializeComponent();
        }

        private void FormEditAdmin_Load(object sender, EventArgs e)
        {

        }

       

        private async void btnLoginEditAdmin_Click_1(object sender, EventArgs e)
        {
            if (txt_ParolEditAdmin != null)
            {
                using (var context = new GameContext())
                {
                    string adminNameToUpdate = txt_LoginEditAdmin.Text;
                    var adminToUpdate = await context.Admins.FirstOrDefaultAsync(a => a.AdminName == adminNameToUpdate);

                    if (adminToUpdate != null)
                    {
                        adminToUpdate.Password = txt_ParolEditAdmin.Text;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Admin's informations updated!");
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
