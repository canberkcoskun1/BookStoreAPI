using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookStore.Service.Concrete
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<T> _repository;

        public Service(IUnitOfWork uow, IGenericRepository<T> repository)
        {
            _uow = uow;
            _repository = repository;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _uow.CommitAsync();
            return entity;
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return _repository.AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _uow.CommitAsync();
            
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _uow.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.UpdateAsync(entity);
            await _uow.CommitAsync();

        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
