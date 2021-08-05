using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddIsAdminProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                schema: "Lookup",
                table: "Role",
                nullable: false,
                defaultValue: false);
           
            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "IsAdmin",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "IsAdmin",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "IsAdmin",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "IsAdmin",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Lookup",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "IsAdmin",
                value: true);            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                schema: "Lookup",
                table: "Role");
        }
    }
}
