using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddRequestorDefinedByGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[,]
                {
                    { -11, "Age UK South Kent Coast", "3 Park Street", "Deal", "volunteering@ageukskc.org.uk", "Mark", "Colley", "Kent", null, "01304 372608", "CT14 6AG" },
                    { -9, "Age UK North West Kent", "The Fleming Resource Centre", "Gravesend", "contactus@ageuknorthwestkent.org.uk", "Age UK", "North West Kent", "Kent", null, "01474 564898", "DA12 1HJ" }
                });

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "a" },
                column: "RequestorDefinedByGroup",
                value: true);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -9, "a" },
                column: "RequestorDefinedByGroup",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -11);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -9);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -11, "a" },
                column: "RequestorDefinedByGroup",
                value: false);

            migrationBuilder.UpdateData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -9, "a" },
                column: "RequestorDefinedByGroup",
                value: false);
        }
    }
}
