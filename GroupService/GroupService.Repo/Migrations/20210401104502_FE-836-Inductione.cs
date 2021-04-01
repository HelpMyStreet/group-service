using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class FE836Inductione : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "HowToAchieve",
                value: "Please contact our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to arrange your volunteer induction.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "HowToAchieve",
                value: "Please contact our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to arrange your volunteer inductione");
        }
    }
}
