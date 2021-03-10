using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakCardiffCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Volunteer Induction");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 },
                column: "HowToAchieve",
                value: "Email our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to request a manual ID check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 },
                column: "HowToAchieve",
                value: "Email our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to request a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "HowToAchieve",
                value: "Please contact our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to arrange your volunteer inductione");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 },
                column: "HowToAchieve",
                value: "Please complete this [form](/forms/ageconnect/cardiff/referencesform.docx) form and return it by email to mailto:helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 6 },
                column: "HowToAchieve",
                value: "Please complete this [form](/forms/ageconnect/cardiff/referencesform.docx) form and return it by email to mailto:helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Volunteer Training");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 },
                column: "HowToAchieve",
                value: "Email our volunteer recruiter at helen.prior@ageconnectscardiff.org.uk to request a manual ID check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 },
                column: "HowToAchieve",
                value: "Email our volunteer recruiter at helen.prior@ageconnectscardiff.org.uk to request a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "HowToAchieve",
                value: "Please contact our volunteer recruiter at helen.prior@ageconnectscardiff.org.uk to arrange your volunteer inductione");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 },
                column: "HowToAchieve",
                value: "Please complete this [form](/forms/ageconnect/cardiff/referencesform.docx) form and return it by email to helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 6 },
                column: "HowToAchieve",
                value: "Please complete this [form](/forms/ageconnect/cardiff/referencesform.docx) form and return it by email to helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.");
        }
    }
}
