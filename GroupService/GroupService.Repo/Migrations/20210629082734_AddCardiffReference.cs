using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddCardiffReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "HowToAchieve",
                schema: "Group",
                table: "GroupCredential",
                unicode: false,
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);

            migrationBuilder.InsertData(
                schema: "Group",
                table: "ActivityCredentialSet",
                columns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                values: new object[,]
                {
                    { -23, 26, 235 },
                    { -23, 22, 234 },
                    { -23, 7, 234 },
                    { -23, 2, 234 },
                    { -23, 22, 235 },
                    { -23, 7, 235 },
                    { -23, 2, 235 },
                    { -23, 16, 234 },
                    { -23, 1, 234 },
                    { -23, 27, 234 },
                    { -23, 11, 234 },
                    { -23, 16, 231 },
                    { -23, 1, 231 },
                    { -23, 27, 231 },
                    { -23, 11, 231 },
                    { -23, 26, 231 },
                    { -23, 16, 235 },
                    { -23, 1, 235 },
                    { -23, 27, 235 },
                    { -23, 11, 235 },
                    { -23, 26, 234 }
                });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 },
                column: "HowToAchieve",
                value: "This activity requires a DBS check, please complete and return this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-dbs-check-form.docx). If it’s been more than two weeks and you haven’t heard anything, please get in touch.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 },
                column: "HowToAchieve",
                value: "If you haven’t done so already, please book your space on one of our Core Induction Training sessions through <a href=\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\">Eventbrite</a>. If you’ve recently completed your induction please be aware that it may take a couple of days for the system to update.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 },
                column: "HowToAchieve",
                value: "Please complete this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx) with details of your **two** referees. If it’s been more than two weeks and you haven’t heard anything, please get in touch.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 1, 231 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 1, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 1, 235 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 2, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 2, 235 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 7, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 7, 235 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 11, 231 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 11, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 11, 235 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 16, 231 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 16, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 16, 235 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 22, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 22, 235 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 26, 231 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 26, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 26, 235 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 27, 231 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 27, 234 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -23, 27, 235 });

            migrationBuilder.AlterColumn<string>(
                name: "HowToAchieve",
                schema: "Group",
                table: "GroupCredential",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 400);

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { 6, "Reference 2" });

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
                value: "Please contact our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to arrange your volunteer induction.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 },
                column: "HowToAchieve",
                value: "Please complete this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx) and return it by email to mailto:helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.");
        }
    }
}
