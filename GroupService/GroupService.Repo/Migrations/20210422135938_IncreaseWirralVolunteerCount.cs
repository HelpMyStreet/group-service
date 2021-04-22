using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class IncreaseWirralVolunteerCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -7,
                column: "MaxVolunteer",
                value: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -7,
                column: "MaxVolunteer",
                value: 10);
        }
    }
}
