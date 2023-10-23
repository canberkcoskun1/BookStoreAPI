using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookStore.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Global Query Filters
            modelBuilder.Entity<User>().HasQueryFilter(x => x.IsActive && !x.IsDeleted);
            modelBuilder.Entity<Genre>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Author>().HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
