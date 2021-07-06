using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddMissingConfigurationForFaversham : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 23 },
                column: "Radius",
                value: 20.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
