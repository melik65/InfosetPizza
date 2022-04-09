using Microsoft.EntityFrameworkCore.Migrations;

namespace Infoset.DataAccessLayer.Migrations
{
    public partial class delete_table_old : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Konums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Boylam = table.Column<double>(type: "float", nullable: false),
                    Enlem = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konums", x => x.Id);
                });
        }
    }
}
