using Final_Task___Winform.Context;
using Final_Task___Winform.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task___Winform.Repositories.EFRespositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly GameContext _context;
        public DbSet<T> Table { get; set; }
        public GenericRepository()
        {
            _context = new GameContext();
            Table = _context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await Table.AddAsync(entity);

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await Table.FindAsync();
        }
        public void Remove(T entity)
        {
            Table.Remove(entity);
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
