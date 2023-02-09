using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeEmailAddressForVCS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -37,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Lincolnshire Community and Voluntary Service", "(LCVS)" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -36,
                columns: new[] { "EmailAddress", "FirstName", "LastName" },
                values: new object[] { "volunteering@voluntarycentreservices.org.uk", "Voluntary Centre Services", "(VCS)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -37,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Lincolnshire LCVS", "(Voluntary Centre Services)" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -36,
                columns: new[] { "EmailAddress", "FirstName", "LastName" },
                values: new object[] { "test@email.com", "Lincolnshire VCS", "(Voluntary Centre Services)" });
        }
    }
}
