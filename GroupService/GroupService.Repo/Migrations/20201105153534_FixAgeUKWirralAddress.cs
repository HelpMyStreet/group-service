using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class FixAgeUKWirralAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -7,
                columns: new[] { "AddressLine3", "Locality" },
                values: new object[] { "141 Park Road North", "Birkenhead" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -7,
                columns: new[] { "AddressLine3", "Locality" },
                values: new object[] { "141 Park Road", "North Birkenhead" });
        }
    }
}
