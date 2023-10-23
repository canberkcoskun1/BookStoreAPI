using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Entities;
using BookStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Concrete
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        private readonly DbSet<Genre> _genre;
        public GenreRepository(AppDbContext context) : base(context) 
        {
            _genre = context.Set<Genre>();
        }
        public async Task<Genre> FindGenreByIdAsync(int id)
        {
            var genre = await _genre.Where(x => x.Id == id).FirstOrDefaultAsync();
            return genre;
        }

        public async Task<Genre> FindGenreByNameAsync(string name)
        {
            var genre = await _genre.Where(x => x.GenreName == name).FirstOrDefaultAsync();
            return genre;
        }

        // Get genre with books
        public async Task<List<Genre>> GetAllGenreWithBooksAsync()
        {
            return await _genre.Include(x => x.Books).ThenInclude(x => x.Author).ToListAsync();
        }
    }
}
