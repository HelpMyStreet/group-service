using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class NewRequestFormFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AccessRestrictedByRole",
                schema: "Website",
                table: "RequestHelpJourney",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RequestorDefinedByGroup",
                schema: "Website",
                table: "RequestHelpJourney",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -7, "" },
                columns: new[] { "AccessRestrictedByRole", "RequestorDefinedByGroup" },
                values: new object[] { true, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessRestrictedByRole",
                schema: "Website",
                table: "RequestHelpJourney");

            migrationBuilder.DropColumn(
                name: "RequestorDefinedByGroup",
                schema: "Website",
                table: "RequestHelpJourney");
        }
    }
}
