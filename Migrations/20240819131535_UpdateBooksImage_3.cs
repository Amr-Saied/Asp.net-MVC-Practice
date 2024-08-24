using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBooksImage_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1605824499i/55953683.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9781503280786-L.jpg");
        }
    }
}
