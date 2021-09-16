using Microsoft.EntityFrameworkCore.Migrations;

namespace DtAPI.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DtApis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    kurum_adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ilan_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unique_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ilan_data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtApis", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DtApis");
        }
    }
}
