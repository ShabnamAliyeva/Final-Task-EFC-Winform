using Final_Task___Winform.Entities;
using Final_Task___Winform.Extensions;
using Final_Task___Winform.Forms.Repositories.EFRepositories;
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
    public partial class FormNewAccount : Form
    {
        private readonly EmployeeRespository _employeeRespository;
        public FormNewAccount()
        {
            InitializeComponent();
            _employeeRespository = new EmployeeRespository();
        }

        private async void btnLoginNew_Click(object sender, EventArgs e)
        {
            if (txt_LoginNew.IsEmpty())

            {
                MessageBox.Show("Form is not valid!");
                return;
            }

         

            Employee employee = new Employee()
            {
                EmployeeName = txt_LoginNew.Text,
                Password = txt_ParolNew.Text
            };

          
            await _employeeRespository.Add(employee);
            await _employeeRespository.SaveChangesAsync();
            MessageBox.Show("User added!");

            FormNewAccount formNewAccount = new FormNewAccount();
            this.Close();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
        }


    }
    }


