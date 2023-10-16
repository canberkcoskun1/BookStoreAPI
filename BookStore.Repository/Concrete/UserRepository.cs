using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Entities;
using BookStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> _user;
        public UserRepository(AppDbContext context) : base(context)
        {
            _user = context.Set<User>();
        }


        public async Task<User> FindUserByIdAsync(int id)
        {
            var user = await _user.Where(u => u.Id == id).FirstOrDefaultAsync();
            return user;
        }
        public async Task<User> ActivateUserByIdAsync(int id)
        {
            var user = await _user.IgnoreQueryFilters().FirstOrDefaultAsync(u => u.Id == id);
            if (user != null)
                user.IsActive = true;
            return user;
        }

        public async Task<User> DeactivateUserByIdAsync(int id)
        {
            var user = await _user.FirstOrDefaultAsync(u => u.Id == id);
            if (user != null)
                user.IsActive = false;
            return user;
        }

    }
}
