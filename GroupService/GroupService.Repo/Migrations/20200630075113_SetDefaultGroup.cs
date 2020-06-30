using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class SetDefaultGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupName", "ParentGroupId" },
                values: new object[] { -1, "Generic", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
