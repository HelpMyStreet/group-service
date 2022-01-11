using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveUnusedObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrgentRequestNotificationStrategy",
                schema: "Lookup");

            migrationBuilder.DropColumn(
                name: "UrgentRequestNotificationStrategyId",
                schema: "Group",
                table: "NewRequestNotificationStrategy");

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CommunicationJobType",
                columns: new[] { "ID", "Name" },
                values: new object[] { 18, "JobsDueTomorrow" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CommunicationJobType",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.AddColumn<byte>(
                name: "UrgentRequestNotificationStrategyId",
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                type: "tinyint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UrgentRequestNotificationStrategy",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrgentRequestNotificationStrategy", x => x.ID);
                });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -34,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -33,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -32,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -31,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -23,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -22,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -13,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -11,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -10,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -9,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -8,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -7,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -6,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -5,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -3,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -2,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -1,
                column: "UrgentRequestNotificationStrategyId",
                value: (byte)1);

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "UrgentRequestNotificationStrategy",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 2, "DontSendEmail" },
                    { 1, "SendEmail" }
                });
        }
    }
}
