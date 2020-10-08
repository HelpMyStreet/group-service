using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AllowJoinersAndLeaversFor3Groups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "SecurityConfiguration",
                columns: new[] { "GroupID", "AllowAutonomousJoinersAndLeavers" },
                values: new object[] { -3, true });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SecurityConfiguration",
                columns: new[] { "GroupID", "AllowAutonomousJoinersAndLeavers" },
                values: new object[] { -2, true });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SecurityConfiguration",
                columns: new[] { "GroupID", "AllowAutonomousJoinersAndLeavers" },
                values: new object[] { -5, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SecurityConfiguration",
                keyColumn: "GroupID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SecurityConfiguration",
                keyColumn: "GroupID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SecurityConfiguration",
                keyColumn: "GroupID",
                keyValue: -2);
        }
    }
}
