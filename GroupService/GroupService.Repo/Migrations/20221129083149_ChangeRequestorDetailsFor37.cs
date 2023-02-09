using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeRequestorDetailsFor37 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -37,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "Locality", "OtherPhone", "Postcode" },
                values: new object[] { "Lincolnshire CVS", "Room G8 Boston Borough Council Offices", "Municipal Building West Street", "enquiry@lincolnshirecvs.org.uk", "Boston", "01205 510888", "PE21 8QR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -37,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "Locality", "OtherPhone", "Postcode" },
                values: new object[] { "Lincolnshire LCVS", "City Hall", "", "test@email.com", "Lincoln", "01522 551683", "LN1 1DF" });
        }
    }
}
