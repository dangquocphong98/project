using Microsoft.EntityFrameworkCore.Migrations;

namespace Nothing.Model.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pathological",
                table: "Profile",
                type: "nvarchar(999)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(999)");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorComment",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Displayname",
                table: "Profile",
                type: "nvarchar(99)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(99)");

            migrationBuilder.AlterColumn<string>(
                name: "NameMenu",
                table: "Menu",
                type: "nvarchar(99)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(99)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pathological",
                table: "Profile",
                type: "varchar(999)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(999)");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorComment",
                table: "Profile",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Displayname",
                table: "Profile",
                type: "varchar(99)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(99)");

            migrationBuilder.AlterColumn<string>(
                name: "NameMenu",
                table: "Menu",
                type: "varchar(99)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(99)");
        }
    }
}
