using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Entities;
using BookStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Concrete
{
    public class LibraryRepository : GenericRepository<Library>, ILibraryRepository
    {
        private readonly DbSet<Library> _library;
        public LibraryRepository(AppDbContext context) : base(context) 
        {
            _library = context.Set<Library>();
        }

        public async Task<Library> FindLibaryByIdAsync(int id)
        {
            var library = await _library.Include(x => x.User).ThenInclude(x => x.Books).Where(x => x.Id == id).FirstOrDefaultAsync();
            return library;
        }
    }
}
