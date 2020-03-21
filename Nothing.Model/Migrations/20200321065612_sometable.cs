using Microsoft.EntityFrameworkCore.Migrations;

namespace Nothing.Model.Migrations
{
    public partial class sometable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id_Menu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMenu = table.Column<string>(type: "varchar(99)", nullable: false),
                    ParentID = table.Column<int>(nullable: false),
                    Where = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id_Menu);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id_Profile = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Displayname = table.Column<string>(type: "varchar(99)", nullable: false),
                    Id_User = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Pathological = table.Column<string>(type: "varchar(999)", nullable: false),
                    DoctorComment = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id_Profile);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id_User = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(99)", nullable: false),
                    PassWord = table.Column<string>(type: "varchar(99)", nullable: false),
                    RoleMenu = table.Column<string>(nullable: true),
                    Id_Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id_User);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
