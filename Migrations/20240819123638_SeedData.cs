using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", 10.99m, "The Great Gatsby" },
                    { 2, "George Orwell", "Dystopian", 8.99m, "1984" },
                    { 3, "Harper Lee", "Classic", 12.99m, "To Kill a Mockingbird" },
                    { 4, "Jane Austen", "Romance", 9.99m, "PrBookIde and Prejudice" },
                    { 5, "J.D. Salinger", "Fiction", 11.99m, "The Catcher in the Rye" },
                    { 6, "J.R.R. Tolkien", "Fantasy", 14.99m, "The Hobbit" },
                    { 7, "Herman Melville", "Adventure", 13.99m, "Moby Dick" },
                    { 8, "Leo Tolstoy", "Historical", 19.99m, "War and Peace" },
                    { 9, "Homer", "Epic", 15.99m, "The Odyssey" },
                    { 10, "Fyodor Dostoevsky", "Psychological", 17.99m, "Crime and Punishment" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 10);
        }
    }
}
