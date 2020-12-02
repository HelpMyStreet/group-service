using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class GPS314AgeUKRequestHelpJourneyAdjustments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[] { -3, "Age UK Lincoln & South Lincolnshire", "36 Park Street", "", "volunteering@ageuklsl.org.uk", "Age UK", "Lincoln & South Lincolnshire", "Lincoln", null, "03455 564 144", "LN1 1UQ" });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -3, "" },
                columns: new[] { "AccessRestrictedByRole", "RequestorDefinedByGroup" },
                values: new object[] { true, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -3);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -3, "" },
                columns: new[] { "AccessRestrictedByRole", "RequestorDefinedByGroup" },
                values: new object[] { false, false });
        }
    }
}
