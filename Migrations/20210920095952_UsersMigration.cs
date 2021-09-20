using Microsoft.EntityFrameworkCore.Migrations;

namespace DtAPI.Migrations
{
    public partial class UsersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Users",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   created_at = table.Column<string>(type: "datetime", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Users", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
