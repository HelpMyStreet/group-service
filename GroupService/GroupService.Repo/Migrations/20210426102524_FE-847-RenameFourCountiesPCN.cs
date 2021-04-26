using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class FE847RenameFourCountiesPCN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "GroupKey", "GroupName", "ParentGroupId" },
                values: new object[] { "four-counties-pcn", "Four Counties PCN", -12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "GroupKey", "GroupName", "ParentGroupId" },
                values: new object[] { "pcn-stamford", "PCN Stamford", null });
        }
    }
}
