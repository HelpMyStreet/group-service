using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddTasksEnabledFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HomepageEnabled",
                schema: "Group",
                table: "Group",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TasksEnabled",
                schema: "Group",
                table: "Group",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -13, 16 });

            migrationBuilder.DropColumn(
                name: "HomepageEnabled",
                schema: "Group",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "TasksEnabled",
                schema: "Group",
                table: "Group");
        }
    }
}
