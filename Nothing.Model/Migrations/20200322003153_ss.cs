using Microsoft.EntityFrameworkCore.Migrations;

namespace Nothing.Model.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LanguageCurrent",
                table: "User",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id_Role", "Role_Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Employee" },
                    { 3, "User" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id_User", "Id_Role", "IsDelete", "LanguageCurrent", "PassWord", "RoleMenu", "UserName" },
                values: new object[,]
                {
                    { 1, 1, true, "EN", "Admin", null, "Admin" },
                    { 2, 2, true, "VN", "Employee", null, "Employee" },
                    { 3, 3, true, "VN", "User", null, "User" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id_Role",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id_Role",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id_Role",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id_User",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id_User",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id_User",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LanguageCurrent",
                table: "User");
        }
    }
}
