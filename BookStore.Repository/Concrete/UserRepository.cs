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
    }
}
