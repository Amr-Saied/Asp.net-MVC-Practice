using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddBooksImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "/images/pride-and-prejudice.jpg", "Pride and Prejudice" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Book");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Title",
                value: "PrBookIde and Prejudice");
        }
    }
}
