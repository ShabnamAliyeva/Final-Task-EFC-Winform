using Final_Task___Winform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Forms.Interfaces
{
    internal interface IEmployeeRespository
    {
        Task Add(Employee employee);

        Task<IEnumerable<Employee>> GetEmployees();
    }

}
