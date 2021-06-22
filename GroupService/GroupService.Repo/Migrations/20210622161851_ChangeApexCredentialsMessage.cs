using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeApexCredentialsMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 },
                column: "HowToAchieve",
                value: "Please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net to request a manual ID check.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 },
                column: "HowToAchieve",
                value: "If you’re unable to verify with Yoti, please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net to request a manual ID check.");
        }
    }
}
