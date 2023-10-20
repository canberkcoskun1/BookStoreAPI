using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Entities;
using BookStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Concrete
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        private readonly DbSet<Author> _author;
        public AuthorRepository(AppDbContext context) : base(context)
        {
            _author = context.Set<Author>();
        }
        public async Task<Author> FindAuthorByIdAsync(int id)
        {
            var author = await _author.Include(a => a.Books).Where(x => x.Id == id).FirstOrDefaultAsync();
            return author;
        }

        public async Task<Author> FindAuthorByNameAsync(string name)
        {
            var author = await _author.Include(a => a.Books).Where(x => x.FirstName == name).FirstOrDefaultAsync();
            return author;
        }

        public async Task<List<Author>> GetAllAuthorsWithBooksAsync()
        {
            return await _author.Include(a => a.Books).ToListAsync();
        }
    }
}
