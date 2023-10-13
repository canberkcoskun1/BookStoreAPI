using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Repository.SeedData
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            User user1 = new() { Id = 1, Username = "CANB", EmailAdress = "testdata@gmail.com",Password = "test1", IsActive = true, IsDeleted = false, ProfileImg = "a.jpg", IsAdmin = true};
            User user2 = new() { Id = 2, Username = "Test1", EmailAdress = "test1@gmail.com",Password = "test2", IsActive = true, IsDeleted = false, ProfileImg = "a.jpg", IsAdmin = false};
            User user3 = new() { Id = 3, Username = "Test2", EmailAdress = "test2@gmail.com",Password = "test3", IsActive = true, IsDeleted = false, ProfileImg = "a.jpg", IsAdmin = false};
            User user4 = new() { Id = 4, Username = "Test3", EmailAdress = "test3@gmail.com", Password = "test4", IsActive = false, IsDeleted = true, ProfileImg = "a.jpg", IsAdmin = false};
            User user5 = new() { Id = 5, Username = "Test4", EmailAdress = "test4@gmail.com",Password = "test5", IsActive = true, IsDeleted = false, ProfileImg = "a.jpg", IsAdmin = false};

            builder.HasData(user1,user2, user3, user4, user5);
        }
    }
}
