using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddUrgentRequestNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "UrgentRequestNotificationStrategyId",
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UrgentRequestNotificationStrategy",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrgentRequestNotificationStrategy", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommunicationJobType",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 16, "NewUserNotification" },
                    { 17, "InProgressReminder" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "UrgentRequestNotificationStrategy",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "SendEmail" },
                    { 2, "DontSendEmail" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrgentRequestNotificationStrategy",
                schema: "Lookup");

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CommunicationJobType",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CommunicationJobType",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DropColumn(
                name: "UrgentRequestNotificationStrategyId",
                schema: "Group",
                table: "NewRequestNotificationStrategy");
        }
    }
}
