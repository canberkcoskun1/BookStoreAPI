using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UserSeed_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeletedAt", "EmailAdress", "IsActive", "IsAdmin", "IsDeleted", "Password", "ProfileImg", "Username" },
                values: new object[,]
                {
                    { 1, null, "testdata@gmail.com", true, true, false, "test1", "a.jpg", "CANB" },
                    { 2, null, "test1@gmail.com", true, false, false, "test2", "a.jpg", "Test1" },
                    { 3, null, "test2@gmail.com", true, false, false, "test3", "a.jpg", "Test2" },
                    { 4, null, "test3@gmail.com", false, false, true, "test4", "a.jpg", "Test3" },
                    { 5, null, "test4@gmail.com", true, false, false, "test5", "a.jpg", "Test4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
