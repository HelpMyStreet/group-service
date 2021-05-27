using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class MakeSouthwellUrlRelative : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email mailto:jacky.huson@btinternet.com to request a manual ID check. You will also need to join our group from our <a href=\"/southwell\">HelpMyStreet landing page</a> if you haven’t already.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email mailto:jacky.huson@btinternet.com to request a manual ID check. You will also need to join our group from our <a href=\"http://www.helpmystreet.org/southwell\">HelpMyStreet landing page</a> if you haven’t already.");
        }
    }
}
