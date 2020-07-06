using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddJourney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Website");

            migrationBuilder.CreateTable(
                name: "RegistrationJourney",
                schema: "Website",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    Source = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    RegistrationFormVariant = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationJourney", x => new { x.GroupID, x.Source });
                    table.ForeignKey(
                        name: "FK_RegistrationJourney_Group",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestHelpJourney",
                schema: "Website",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    Source = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    RequestHelpFormVariant = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHelpJourney", x => new { x.GroupID, x.Source });
                    table.ForeignKey(
                        name: "FK_RequestHelpJourney_Group",
                        column: x => x.GroupID,
                        principalSchema: "Group",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "ParentGroupId" },
                values: new object[,]
                {
                    { -2, "ftlos", "For the Love of Scrubs", null },
                    { -3, "ageuklsl", "Age UK Lincoln & South Lincolnshire", null },
                    { -4, "hlp", "Healthy London Partnership", null }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant" },
                values: new object[] { -1, "", (byte)0 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "RequestHelpFormVariant" },
                values: new object[,]
                {
                    { -1, "DIY", (byte)3 },
                    { -1, "", (byte)1 }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant" },
                values: new object[,]
                {
                    { -2, "", (byte)2 },
                    { -3, "", (byte)0 },
                    { -4, "", (byte)1 }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "RequestHelpFormVariant" },
                values: new object[,]
                {
                    { -2, "", (byte)4 },
                    { -3, "", (byte)2 },
                    { -4, "", (byte)1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationJourney",
                schema: "Website");

            migrationBuilder.DropTable(
                name: "RequestHelpJourney",
                schema: "Website");

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -2);
        }
    }
}
