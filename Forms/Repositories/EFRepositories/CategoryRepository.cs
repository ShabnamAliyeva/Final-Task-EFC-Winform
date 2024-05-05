using Final_Task___Winform.Entities;
using Final_Task___Winform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Repositories.EFRespositories
{
    internal class CategoryRepository : GenericRepository<Category>,
        ICategoryRepository
    {
        public Task<IEnumerable<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
