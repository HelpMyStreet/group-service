using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class FE803CorrectCredentialsText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -24, 1 },
                column: "HowToAchieve",
                value: "Email Sam Kelly on mailto:sam@bridgescommunitytrust.org.uk to arrange a manual ID check at The One Stop Shop.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -24, 1 },
                column: "HowToAchieve",
                value: "Email the Oh My Nottz team at mailto:guy@mynottz.com to arrange a manual ID check at The One Stop Shop.");
        }
    }
}
