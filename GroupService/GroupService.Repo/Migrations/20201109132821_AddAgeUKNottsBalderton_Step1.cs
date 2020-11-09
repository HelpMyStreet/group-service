using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddAgeUKNottsBalderton_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "ParentGroupId" },
                values: new object[] { -8, "ageuknottsbalderton", "Age UK Notts (Balderton)", null });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 6, "AgeUKNottsBalderton" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 9, "AgeUKNottsBalderton" });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant" },
                values: new object[] { -8, "", (byte)6 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "TargetGroups" },
                values: new object[] { -8, "", false, (byte)9, false, (byte)4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -8, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -8, "" });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -8);
        }
    }
}
