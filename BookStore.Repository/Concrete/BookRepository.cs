using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Entities;
using BookStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Concrete
{
    public class BookRepository : GenericRepository<Book>, IBookRepository 
    {   
        private readonly DbSet<Book> _books;
        public BookRepository(AppDbContext context) : base(context) 
        {
            _books = context.Set<Book>();   
        }

        public async Task<Book> FindBookByIdAsync(int id)
        {
            var books = await _books.Where(x => x.Id == id).FirstOrDefaultAsync();
            return books;
        }

        public async Task<Book> FindBookByNameAsync(string bookname)
        {
            var bookName = await _books.Where(x => x.BookName == bookname).FirstOrDefaultAsync();
            return bookName;
        }
        
    }
}
