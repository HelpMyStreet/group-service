using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddNewSubGroupsLCVSAndVCS_Step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[,]
                {
                    { -36, "Lincolnshire VCS", "City Hall", "", "test@email.com", "Lincolnshire VCS", "(Voluntary Centre Services)", "Lincoln", null, "01522 551683", "LN1 1DF" },
                    { -37, "Lincolnshire LCVS", "City Hall", "", "test@email.com", "Lincolnshire LCVS", "(Voluntary Centre Services)", "Lincoln", null, "01522 551683", "LN1 1DF" }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[,]
                {
                    { -36, "a", true, (byte)32, true, false, true, (byte)0 },
                    { -37, "a", true, (byte)32, true, false, true, (byte)0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -37);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -36);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -37, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -36, "a" });
        }
    }
}
