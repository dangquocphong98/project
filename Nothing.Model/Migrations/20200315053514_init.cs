using Microsoft.EntityFrameworkCore.Migrations;

namespace Nothing.Model.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    ID_Language = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key_Language = table.Column<string>(type: "varchar(99)", nullable: false),
                    Language_VN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.ID_Language);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
