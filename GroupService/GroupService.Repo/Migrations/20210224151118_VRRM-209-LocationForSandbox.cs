using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class VRRM209LocationForSandbox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[] { -22, -9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -22, -9 });
        }
    }
}
