using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakEventBriteLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "HowToAchieve",
                value: "If you haven’t done so already, please book your space on one of our Core Induction Training sessions through <a href=\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\" target=\"_blank\">Eventbrite</a>. If you’ve recently completed your induction please be aware that it may take a couple of days for the system to update.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "HowToAchieve",
                value: "If you haven’t done so already, please book your space on one of our Core Induction Training sessions through <a href=\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579 target=\"_blank\"\">Eventbrite</a>. If you’ve recently completed your induction please be aware that it may take a couple of days for the system to update.");
        }
    }
}
