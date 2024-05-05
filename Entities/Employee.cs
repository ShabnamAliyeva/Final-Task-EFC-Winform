using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        public string Password { get; set; }
    }
}
