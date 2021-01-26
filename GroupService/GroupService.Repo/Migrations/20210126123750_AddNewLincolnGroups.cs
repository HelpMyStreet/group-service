using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddNewLincolnGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "pcn-grantham", "PCN Grantham" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "pcn-louth", "PCN Louth" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "ParentGroupId" },
                values: new object[,]
                {
                    { -16, "pcn-southlincoln", "PCN South Lincoln", -12 },
                    { -17, "pcn-stamford", "PCN Stamford", -12 },
                    { -18, "pcn-spilsby", "PCN Spilsby", -12 },
                    { -19, "pcn-boston", "PCN Boston", -12 },
                    { -20, "pcn-lincoln", "PCN Lincoln", -12 },
                    { -21, "pcn-lincoln-portland", "PCN Lincoln Portland", -12 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[,]
                {
                    { -14, 3 },
                    { -15, 4 }
                });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -15,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "FirstName", "LastName", "Locality", "Postcode" },
                values: new object[] { "Grantham Meres Leisure Centre Table Tennis Club", "Trent Road", "Grantham", "Grantham", "PCN", "", "NG31 7XQ" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -14,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "FirstName", "Postcode" },
                values: new object[] { "Louth County Hospital", "High Holme Rd", "Louth", "Louth Community", "LN11 0EU" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)22, "{\"SupportActivityInstructions\":22,\"ActivityDetails\":\"Activity details for vaccine support\",\"Intro\":null,\"Steps\":null,\"Close\":null}" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 22, "Lincoln_VaccineSupport" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[,]
                {
                    { -16, 5 },
                    { -21, 10 },
                    { -19, 8 },
                    { -18, 7 },
                    { -20, 9 },
                    { -17, 6 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -21, 24, (short)22 },
                    { -19, 24, (short)22 },
                    { -18, 24, (short)22 },
                    { -17, 24, (short)22 },
                    { -16, 24, (short)22 },
                    { -15, 24, (short)22 },
                    { -20, 24, (short)22 },
                    { -14, 24, (short)22 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[,]
                {
                    { -21, "Portland Medical Practice", "60 Portland St", "Lincoln", "laura@factor-50.co.uk", "Lincoln Portland", "PCN", "", null, "", "LN5 7LB" },
                    { -17, "Lakeside Healthcare at Stamford", "Wharf Rd", "Stamford", "laura@factor-50.co.uk", "Stamford", "PCN", "", null, "", "PE9 2DH" },
                    { -20, "Ruston Sports & Social Club", "Newark Road", "Lincoln", "laura@factor-50.co.uk", "Lincoln", "PCN", "", null, "", "LN6 8RN" },
                    { -19, "Sidings Medical Practice", "14 Sleaford Rd", "Boston", "laura@factor-50.co.uk", "Boston", "PCN", "", null, "", "PE21 8EG" },
                    { -16, "Cliff Villages Medical Practice", "Mere Rd", "Waddington", "laura@factor-50.co.uk", "South Lincoln", "PCN", "Lincoln", null, "", "LN5 9NX" },
                    { -18, "Franklin Hall", "Halton Rd", "Spilsby", "laura@factor-50.co.uk", "Spilsby", "PCN", "", null, "", "PE23 5LA" }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "TargetGroups" },
                values: new object[,]
                {
                    { -21, "a", true, (byte)17, true, false, (byte)4 },
                    { -20, "a", true, (byte)17, true, false, (byte)4 },
                    { -19, "a", true, (byte)17, true, false, (byte)4 },
                    { -18, "a", true, (byte)17, true, false, (byte)4 },
                    { -17, "a", true, (byte)17, true, false, (byte)4 },
                    { -16, "a", true, (byte)17, true, false, (byte)4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -21, 10 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -20, 9 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -19, 8 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -18, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -17, 6 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -16, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -15, 4 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -14, 3 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -21, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -20, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -19, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -18, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -17, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -16, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -15, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -14, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -21);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -20);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -19);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -18);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -17);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -16);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -21, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -20, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -19, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -18, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -17, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -16, "a" });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)22);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "boston-pilgramhospital", "Pilgram Hospital Boston" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "lincs-countyhospital", "Lincoln County Hospital" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -15,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "FirstName", "LastName", "Locality", "Postcode" },
                values: new object[] { "Pilgram Hospital", "Sibsey Road", "Boston", "Pilgram Hospital", "Boston", "Lincolnshire", "PE21 9QS" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -14,
                columns: new[] { "AddressLine1", "AddressLine2", "AddressLine3", "FirstName", "Postcode" },
                values: new object[] { "Lincoln County Hospital", "Greetwell Road", "Lincoln", "Lincoln County", "LN2 5QY" });
        }
    }
}
