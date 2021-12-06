using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddRichmondCentre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[] { -20, -16 });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[] { -16, "RichmondMedicalCentre" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -20, -16 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -16);
        }
    }
}
