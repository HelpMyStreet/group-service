using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddEastLindsey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "east-lindsey-pcn", "East Lindsey PCN" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -14,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "OtherPhone", "Postcode" },
                values: new object[] { "Lincolnshire CVS, Room G8", "Boston Borough Council Offices, Municipal Buildings", "West Street", "karengarlant@lincolnshirecvs.org.uk", "Karen", "Garlant", "Boston", "07947 597878", "PE21 8QR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "pcn-louth", "PCN Louth" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -14,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "OtherPhone", "Postcode" },
                values: new object[] { "Louth County Hospital", "High Holme Rd", "Louth", "laura@factor-50.co.uk", "Louth Community", "Hospital", "Lincolnshire", "", "LN11 0EU" });
        }
    }
}
