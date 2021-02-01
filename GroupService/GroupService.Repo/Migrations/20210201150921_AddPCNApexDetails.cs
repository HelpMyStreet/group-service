using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddPCNApexDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "apex-pcn-lincoln", "APEX PCN" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -20,
                columns: new[] { "FirstName", "LastName", "OtherPhone" },
                values: new object[] { "Practice", "Manager", "07340 066491" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "pcn-lincoln", "PCN Lincoln" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -20,
                columns: new[] { "FirstName", "LastName", "OtherPhone" },
                values: new object[] { "Lincoln", "PCN", "" });
        }
    }
}
