using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddShowChartsToLookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Role",
                columns: new[] { "ID", "IsAdmin", "Name" },
                values: new object[] { 8, true, "ShowCharts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Role",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
