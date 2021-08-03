using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AmendMersey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "GeographicName", "LinkURL" },
                values: new object[] { "St Helens, Halton, Knowsley and Warrington", "/ageukmidmersey" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "GeographicName", "LinkURL" },
                values: new object[] { null, "/ageuk-midmersey" });
        }
    }
}
