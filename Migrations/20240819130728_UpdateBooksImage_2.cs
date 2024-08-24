using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBooksImage_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780743273565-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780451524935-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780061120084-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780141439518-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780316769488-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780547928227-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9781503280786-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780199232765-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780140268867-L.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/isbn/9780140449136-L.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://example.com/images/great-gatsby.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://example.com/images/1984.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://example.com/images/to-kill-a-mockingbird.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://example.com/images/pride-and-prejudice.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://example.com/images/catcher-in-the-rye.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://example.com/images/the-hobbit.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://example.com/images/moby-dick.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://example.com/images/war-and-peace.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://example.com/images/the-odyssey.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://example.com/images/crime-and-punishment.jpg");
        }
    }
}
