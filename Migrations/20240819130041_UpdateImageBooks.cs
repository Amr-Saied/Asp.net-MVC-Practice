using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImageBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/great-gatsby.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/1984.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/to-kill-a-mockingbird.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/pride-and-prejudice.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/catcher-in-the-rye.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/the-hobbit.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/moby-dick.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/war-and-peace.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/the-odyssey.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/crime-and-punishment.jpg");
        }
    }
}
