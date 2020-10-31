using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET.Core_StudentsManagement.Migrations
{
    public partial class JingeFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Dynasty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Dynasty", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 20, 4, "libai@gmail.com", "李白" },
                    { 2, 33, 4, "baijuyi@gmail.com", "白居易" },
                    { 3, 45, 4, "dufu@gmail.com", "杜甫" },
                    { 4, 51, 4, "wangwei@hotmail.com", "王维" },
                    { 5, 88, 1, "quyuan@outlook.com", "屈原" },
                    { 6, 31, 5, "sushi@163.com", "苏轼" },
                    { 7, 25, 3, "taoyuanming@hotmail.com", "陶渊明" },
                    { 8, 30, 4, "lishangyin@gmail.com", "李商隐" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
