using _01.Domain.Interfaces.Repos;
using _03.Infra.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Infra.Repositories
{
    public class BaseRepository<TEntity, Tkey> : IBaseRepository<TEntity, Tkey> where TEntity : class
    {
        private readonly ShoppingContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(ShoppingContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> AddAndSaveAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await CommiteChangesAsync();
            return entity;
        }

        public async Task CommiteChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAndSaveAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await CommiteChangesAsync();
        }

        public async Task<TEntity> UpdateAndSaveAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await CommiteChangesAsync();
            return entity;
        }
    }
}
