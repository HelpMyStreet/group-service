using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveArroweParkHospital_Step4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 34 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 35 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 36 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 37 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SecurityConfiguration",
                keyColumn: "GroupID",
                keyValue: -35);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)19, 11 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)19, 34 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)19, 35 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)19, 36 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)19, 37 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)60);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)61);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)62);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)63);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[] { -35, 11, 20.0, (short)2 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SecurityConfiguration",
                columns: new[] { "GroupID", "AllowAutonomousJoinersAndLeavers" },
                values: new object[] { -35, true });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[,]
                {
                    { (short)60, "{\"SupportActivityInstructions\":60,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check for any special requirements\",\"Detail\":\"Once you accept the request more information will become available for you to complete it. Make sure to read the request details in full by clicking the “View more info” link next to the request in the “My Requests” section of your profile.\"},{\"Heading\":\"Visit the client\",\"Detail\":\"Make sure you give them plenty of time to get to the door, and double-check for any specific requirements in the request details.\"},{\"Heading\":\"Help prepare a meal and provide company\",\"Detail\":\"Ask the client how you can help - you may need to help them prepare a meal, or just check that they have already eaten.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"After your visit, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)61, "{\"SupportActivityInstructions\":61,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check for any special requirements\",\"Detail\":\"Once you accept the request more information will become available for you to complete it. Make sure to read the request details in full by clicking the “View more info” link next to the request in the “My Requests” section of your profile.\"},{\"Heading\":\"Visit the client\",\"Detail\":\"Make sure you give them plenty of time to get to the door, and double-check for any specific requirements in the request details.\"},{\"Heading\":\"Help prepare a meal and provide company\",\"Detail\":\"Ask the client how you can help - you may need to help them prepare a meal, or just check that they have already eaten.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"After your visit, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)62, "{\"SupportActivityInstructions\":62,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Visit the client\",\"Detail\":\"Use the details provided when you accept the request to visit the client. Make sure you give them plenty of time to get to the door, and double-check for any specific requirements in the request details.\"},{\"Heading\":\"Check they’re OK and ask about their medications\",\"Detail\":\"<ul><li>Check the client is OK and settled at home</li><li>Make sure they have all the medications they need at home</li><li>Ask if they understand how and when to take their medications and check they’re taking them</li></ul>\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"After your visit, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)63, "{\"SupportActivityInstructions\":63,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Visit the client\",\"Detail\":\"Use the details provided when you accept the request to visit the client. Make sure you give them plenty of time to get to the door, and double-check for any specific requirements in the request details.\"},{\"Heading\":\"Check they’re OK\",\"Detail\":\"Check the client is OK and settled at home.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"After your visit, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[,]
                {
                    { (byte)19, 34, (byte)1, false, "Breakfast visit" },
                    { (byte)19, 35, (byte)2, false, "Lunch visit" },
                    { (byte)19, 36, (byte)3, false, "Medication check-in" },
                    { (byte)19, 37, (byte)4, false, "Wellbeing visit" },
                    { (byte)19, 11, (byte)5, false, "I may be able to help with other tasks, so please check with me." }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -35, 34, 20.0, (short)60 },
                    { -35, 35, 20.0, (short)61 },
                    { -35, 36, 20.0, (short)62 },
                    { -35, 37, 20.0, (short)63 }
                });
        }
    }
}
