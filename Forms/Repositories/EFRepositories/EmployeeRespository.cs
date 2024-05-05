using Final_Task___Winform.Entities;
using Final_Task___Winform.Forms.Interfaces;
using Final_Task___Winform.Interfaces;
using Final_Task___Winform.Repositories.EFRespositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Forms.Repositories.EFRepositories
{
    internal class EmployeeRespository : GenericRepository<Employee>,
        IEmployeeRespository
    {

    
        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }

      
    }
}
