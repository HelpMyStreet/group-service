using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveUkraineUsers_Step5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -35, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -35, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -35, 10 });

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
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -35);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SecurityConfiguration",
                keyColumn: "GroupID",
                keyValue: -35);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)64);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[] { -35, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>HelpMyStreet is being made available to help prospective UK hosts find a suitable match for the UK Government Homes for Ukraine Scheme. If you find a suitable person / family on HelpMyStreet you will need to submit a separate application through the UK Government Homes for Ukraine Scheme to start the official process.</p><p>HelpMyStreet will be partnering with organisations and individuals who have experience with finding accommodation for people fleeing unsafe situations. Each partner will be able to bring their own processes for vetting hosts and those requesting help.</p><p>You are registering as a host. As a minimum you will need to verify your identity online using photographic ID. Some referring organisations may require additional checks - if these apply you’ll be shown the relevant details when you click to accept a request.</p><p>Many people fleeing Ukraine have some preference for where they are placed to make sure they are close to family, friends, or their wider community. This is important to make sure they are settled and supported in their new community. Our platform will notify you when new requests are submitted for accommodation in your area. If you have also expressed an interest in other volunteering activities the HelpMyStreet platform may also email you about other opportunities in your area.<p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Thank you for your offer of support,</p><p>From all at HelpMyStreet and our partners\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupMapDetails",
                columns: new[] { "GroupID", "MapLocationID", "Latitude", "Longitude", "ZoomLevel" },
                values: new object[] { -35, (byte)0, 54.55m, -4.5m, 5.1m });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -35, 1, 20.0, (short)1 },
                    { -35, 7, 2000.0, (short)4 },
                    { -35, 10, 20.0, (short)6 },
                    { -35, 11, 20.0, (short)2 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                columns: new[] { "GroupID", "MaxVolunteer", "NewRequestNotificationStrategyId" },
                values: new object[] { -35, 0, (byte)1 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SecurityConfiguration",
                columns: new[] { "GroupID", "AllowAutonomousJoinersAndLeavers" },
                values: new object[] { -35, true });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)64, "{\"SupportActivityInstructions\":64,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Make sure you’ve found an appropriate match\",\"Detail\":\"Make sure you have read all of the information available and are happy that you can provide suitable accommodation for the person(s) requesting help.\"},{\"Heading\":\"Click to ‘Accept’\",\"Detail\":\"If you’re happy you’ll provide a good match, click to accept the request. Please only accept one request for each property / room you have available - if you accept multiple requests you may make the process slower for the person(s) requesting help.\"},{\"Heading\":\"Make contact\",\"Detail\":\"Use the details in the ‘My requests’ section of your profile to make contact with the person requesting help. In some cases we may not be able to share their details with you directly and  you will have to contact the request coordinator for more information.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Let us know when the person(s) you’re helping have moved in by marking the request as complete in “My Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do”. This will automatically notify everyone involved in the request for you and make the request visible to other volunteer hosts who may be able to help.\"}" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[] { -35, 34, 300.0, (short)64 });
        }
    }
}
