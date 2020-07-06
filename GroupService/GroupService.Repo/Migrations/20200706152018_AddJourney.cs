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
                    RegistrationSourceID = table.Column<byte>(nullable: false)
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
                    RequestHelpSourceID = table.Column<byte>(nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationJourney",
                schema: "Website");

            migrationBuilder.DropTable(
                name: "RequestHelpJourney",
                schema: "Website");
        }
    }
}
