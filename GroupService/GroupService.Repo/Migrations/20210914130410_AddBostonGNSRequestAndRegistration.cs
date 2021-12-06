using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddBostonGNSRequestAndRegistration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 18, "BostonGNS" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 29, "BostonGNS_Public" },
                    { 30, "BostonGNS_RequestSubmitter" }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant", "TargetGroups" },
                values: new object[] { -34, "", (byte)18, (byte)5 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[,]
                {
                    { -34, "", false, (byte)29, false, false, true, (byte)0 },
                    { -34, "a", true, (byte)30, false, false, true, (byte)0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -34, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -34, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -34, "a" });
        }
    }
}
