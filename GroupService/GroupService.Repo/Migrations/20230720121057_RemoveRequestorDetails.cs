using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveRequestorDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -32);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -20);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -17);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -14);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -13);

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

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[,]
                {
                    { -3, "Age UK Lincoln & South Lincolnshire", "36 Park Street", "", "volunteering@ageuklsl.org.uk", "Age UK", "Lincoln & South Lincolnshire", "Lincoln", null, "03455 564 144", "LN1 1UQ" },
                    { -11, "Age UK South Kent Coast", "3 Park Street", "Deal", "volunteering@ageukskc.org.uk", "Age UK", "South Kent Coast", "Kent", null, "01304 372608", "CT14 6AG" },
                    { -9, "Age UK North West Kent", "The Fleming Resource Centre", "Gravesend", "contactus@ageuknorthwestkent.org.uk", "Age UK", "North West Kent", "Kent", null, "01474 564898", "DA12 1HJ" },
                    { -13, "Age UK Faversham and Sittingbourne", "The Old Fire Station", "Crescent Rd", "volunteering@ageukfaversham.org.uk", "Age UK", "Faversham and Sittingbourne", "Faversham", null, "01795 532766", "ME13 7GU" },
                    { -14, "Lincolnshire CVS, Room G8", "Boston Borough Council Offices, Municipal Buildings", "West Street", "karengarlant@lincolnshirecvs.org.uk", "Karen", "Garlant", "Boston", null, "07947 597878", "PE21 8QR" },
                    { -17, "Lakeside Healthcare Group", "Unit 1 Exchange Court", "Cottingham Road", "lyndsay.money@nhs.net", "Lyndsay", "Money", "Corby", null, "01780 761443", "NN17 1TY" },
                    { -20, "Ruston Sports & Social Club", "Newark Road", "Lincoln", "g.burroughs@nhs.net", "Apex PCN", "Practice Manager", "", null, "07340 066491", "LN6 8RN" },
                    { -32, "Ruston Sports & Social Club", "Newark Road", "", "g.burroughs@nhs.net", "Gary", "Burroughs", "Lincoln", null, "07340 066491", "LN6 8RN" },
                    { -36, "Lincolnshire VCS", "City Hall", "", "volunteering@voluntarycentreservices.org.uk", "Voluntary Centre Services", "(VCS)", "Lincoln", null, "01522 551683", "LN1 1DF" },
                    { -37, "Lincolnshire CVS", "Room G8 Boston Borough Council Offices", "Municipal Building West Street", "enquiry@lincolnshirecvs.org.uk", "Lincolnshire Community and Voluntary Service", "(LCVS)", "Boston", null, "01205 510888", "PE21 8QR" }
                });
        }
    }
}
