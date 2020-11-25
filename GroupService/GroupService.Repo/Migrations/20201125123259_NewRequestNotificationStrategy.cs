using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class NewRequestNotificationStrategy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewRequestNotificationStrategy",
                schema: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    NewRequestNotificationStrategyId = table.Column<byte>(nullable: false),
                    MaxVolunteer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewRequestNotificationStrategy", x => x.GroupID);
                    table.ForeignKey(
                        name: "FK_NewRequestNotificationStrategy_Group",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewRequestNotificationStrategy",
                schema: "Lookup",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewRequestNotificationStrategy", x => x.ID);
                });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email us to find out more about our manual ID check at baldertoncs@helpmystreet.org");

            migrationBuilder.InsertData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                columns: new[] { "GroupID", "MaxVolunteer", "NewRequestNotificationStrategyId" },
                values: new object[,]
                {
                    { -6, 2147483647, (byte)1 },
                    { -3, 2147483647, (byte)1 },
                    { -2, 2147483647, (byte)1 },
                    { -5, 2147483647, (byte)1 },
                    { -7, 10, (byte)1 },
                    { -8, 2147483647, (byte)1 },
                    { -1, 100, (byte)1 }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "NewRequestNotificationStrategy",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "ClosestNEligibleVolunteers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewRequestNotificationStrategy",
                schema: "Group");

            migrationBuilder.DropTable(
                name: "NewRequestNotificationStrategy",
                schema: "Lookup");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email us to find out more about our manual ID at baldertoncs@helpmystreet.org");
        }
    }
}
