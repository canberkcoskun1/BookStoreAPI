using BookStore.Core.Abstracts;
using BookStore.Core.Common;
using BookStore.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookStore.Repository.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            // it will be defined another time
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
            if(entity is IDeletable softDelete)
            {
                softDelete.IsDeleted = true;
                softDelete.DeletedAt = DateTime.UtcNow;
                _dbSet.Update(entity);
            }
            else
            {
                Task.FromResult(_dbSet.Remove(entity));
            }

        }

        public void RemoveRange(IEnumerable<T> entities)
        {
           _dbSet.RemoveRange(entities);
        }

        public void UpdateAsync(T entity)
        {
            if (entity is IUpdatedAt updatedAt) 
            { 
                updatedAt.UpdatedAt = DateTime.UtcNow;
                Task.FromResult(_dbSet.Update(entity));
            }

        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            // it will be defined another time
            throw new NotImplementedException();
        }
    }
}
