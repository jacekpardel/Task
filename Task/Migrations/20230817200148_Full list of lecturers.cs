using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IS_Task.Migrations
{
    /// <inheritdoc />
    public partial class Fulllistoflecturers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 2, "piotr@poczta.pl", "Piotr", 54332 },
                    { 3, "maciek@poczta.pl", "Maciej", 53454 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
