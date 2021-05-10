using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class EditManualIDText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "Unfortunately manual ID checks are not available right now, please use Yoti to verify you identity and start volunteering.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email us to find out more about our manual ID check at mailto:baldertoncs@helpmystreet.org");
        }
    }
}
