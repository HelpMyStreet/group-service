using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeEastLindseySupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -14, 24 },
                column: "SupportActivityInstructionsID",
                value: (short)55);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -14, 24 },
                column: "SupportActivityInstructionsID",
                value: (short)22);
        }
    }
}
