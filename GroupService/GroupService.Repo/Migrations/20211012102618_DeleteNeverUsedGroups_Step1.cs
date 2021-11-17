using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class DeleteNeverUsedGroups_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -30, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -29, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -28, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -27, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -25, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -21, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -19, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -18, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -16, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -15, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -30, -15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -29, -14 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -28, -13 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -27, -12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -26, -11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -25, -15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -25, -14 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -25, -13 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -25, -12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -25, -11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -1, -15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -1, -14 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -1, -13 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -1, -12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -1, -11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -30, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -29, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -28, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -27, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -26, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -25, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -21, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -19, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -18, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -16, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -15, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -30);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -29);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -28);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -27);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -26);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -25);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -21);

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
                keyValue: -16);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -15);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -25, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -30, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -29, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -28, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -27, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -26, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -25, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -21, "a" });

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
                keyValues: new object[] { -16, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -15, "a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[,]
                {
                    { -15, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -30, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -28, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -27, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -25, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -29, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -19, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -18, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -16, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -21, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[,]
                {
                    { -1, -13 },
                    { -25, -11 },
                    { -1, -11 },
                    { -25, -12 },
                    { -1, -12 },
                    { -25, -13 },
                    { -25, -14 },
                    { -30, -15 },
                    { -25, -15 },
                    { -1, -15 },
                    { -29, -14 },
                    { -28, -13 },
                    { -27, -12 },
                    { -26, -11 },
                    { -1, -14 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -27, 24, 20.0, (short)54 },
                    { -30, 24, 20.0, (short)54 },
                    { -29, 24, 20.0, (short)54 },
                    { -28, 24, 20.0, (short)54 },
                    { -26, 24, 20.0, (short)54 },
                    { -18, 24, 20.0, (short)22 },
                    { -16, 24, 20.0, (short)22 },
                    { -21, 24, 20.0, (short)22 },
                    { -15, 24, 20.0, (short)22 },
                    { -19, 24, 20.0, (short)22 },
                    { -25, 24, 20.0, (short)54 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[,]
                {
                    { -29, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "07851 595171", "NG18 1QA" },
                    { -28, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "07851 595171", "NG18 1QA" },
                    { -27, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "07851 595171", "NG18 1QA" },
                    { -26, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "07851 595171", "NG18 1QA" },
                    { -25, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "07851 595171", "NG18 1QA" },
                    { -21, "Portland Medical Practice", "60 Portland St", "Lincoln", "laura@factor-50.co.uk", "Lincoln Portland", "PCN", "", null, "", "LN5 7LB" },
                    { -19, "Sidings Medical Practice", "14 Sleaford Rd", "Boston", "laura@factor-50.co.uk", "Boston", "PCN", "", null, "", "PE21 8EG" },
                    { -18, "Franklin Hall", "Halton Rd", "Spilsby", "laura@factor-50.co.uk", "Spilsby", "PCN", "", null, "", "PE23 5LA" },
                    { -16, "Cliff Villages Medical Practice", "Mere Rd", "Waddington", "laura@factor-50.co.uk", "South Lincoln", "PCN", "Lincoln", null, "", "LN5 9NX" },
                    { -15, "Grantham Meres Leisure Centre Table Tennis Club", "Trent Road", "Grantham", "laura@factor-50.co.uk", "Grantham", "PCN", "", null, "", "NG31 7XQ" },
                    { -30, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "07851 595171", "NG18 1QA" }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant", "TargetGroups" },
                values: new object[] { -25, "", (byte)14, (byte)5 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[,]
                {
                    { -30, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -28, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -26, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -25, "a", true, (byte)18, true, false, false, (byte)4 },
                    { -21, "a", true, (byte)17, true, false, false, (byte)4 },
                    { -19, "a", true, (byte)17, true, false, false, (byte)4 },
                    { -18, "a", true, (byte)17, true, false, false, (byte)4 },
                    { -16, "a", true, (byte)17, true, false, false, (byte)4 },
                    { -15, "a", true, (byte)17, true, false, false, (byte)4 },
                    { -29, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -27, "a", true, (byte)24, true, false, false, (byte)4 }
                });
        }
    }
}
