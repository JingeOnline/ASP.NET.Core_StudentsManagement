using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET.Core_StudentsManagement.Migrations
{
    public partial class UpdateStudentModelWithPhotoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "1.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: "2.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: "3.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: "4.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoPath",
                value: "5.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoPath",
                value: "6.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoPath",
                value: "7.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoPath",
                value: "8.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoPath",
                value: null);
        }
    }
}
