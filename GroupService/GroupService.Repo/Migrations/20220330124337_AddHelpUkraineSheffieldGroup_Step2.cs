using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddHelpUkraineSheffieldGroup_Step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -36, 34, 300.0, (short)64 },
                    { -36, 1, 20.0, (short)1 },
                    { -36, 7, 2000.0, (short)4 },
                    { -36, 10, 20.0, (short)6 },
                    { -36, 11, 20.0, (short)2 }
                });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)64,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":64,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Make sure you’ve found an appropriate match\",\"Detail\":\"Make sure you have read all of the information available and are happy that you can provide suitable accommodation for the person(s) requesting help.\"},{\"Heading\":\"Click to ‘Accept’\",\"Detail\":\"If you’re happy you’ll provide a good match, click to accept the request. Please only accept one request for each property / room you have available - if you accept multiple requests you may make the process slower for the person(s) requesting help.\"},{\"Heading\":\"Make contact\",\"Detail\":\"Use the details in the ‘My requests’ section of your profile to make contact with the person requesting help. In some cases we may not be able to share their details with you directly and  you will have to contact the request coordinator for more information.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Let us know when the person(s) you’re helping have moved in by marking the request as complete in “My Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do”. This will automatically notify everyone involved in the request for you and make the request visible to other volunteer hosts who may be able to help.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -36, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -36, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -36, 10 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -36, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -36, 34 });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)64,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":64,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Make sure you’ve found an appropriate match\",\"Detail\":\"Make sure you have read all of the information available and are happy that you can provide suitable accommodation for the person(s) requesting help.\"},{\"Heading\":\"Click to ‘Accept’\",\"Detail\":\"If you’re happy you’ll provide a good match, click to accept the request. Please only accept one request for each property / room you have available - if you accept multiple requests you may make the process slower for the person(s) requesting help.\"},{\"Heading\":\"Contact the request coordinator\",\"Detail\":\"Use the details in the ‘My requests’ section of your profile to contact the request coordinator who will be able to provide more information. If your match is accepted they will also be able to provide the details of the person(s) requesting help.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Let us know when the person(s) you’re helping have moved in by marking the request as complete in “My Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do”. This will automatically notify everyone involved in the request for you.\"}");
        }
    }
}
