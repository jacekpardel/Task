using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS_Task.Migrations
{
    /// <inheritdoc />
    public partial class Secondseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Lecturers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 1, "jan@poczta.pl", "Jan", 55554 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
