using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddCardiffInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "SupportActivity",
                columns: new[] { "SupportActivityID", "AutoSignUpWhenOtherSelected" },
                values: new object[] { 28, true });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -23, 7, (short)4 },
                    { -23, 2, (short)2 },
                    { -23, 1, (short)1 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[,]
                {
                    { (short)34, "{\"SupportActivityInstructions\":34,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)35, "{\"SupportActivityInstructions\":35,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)38, "{\"SupportActivityInstructions\":38,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the transport\",\"Detail\":\"Use the details given to you to pick up and drop off as required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)36, "{\"SupportActivityInstructions\":36,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Get in touch with the requester and arrange a convenient time an place to meet up.\"},{\"Heading\":\"Meet up\",\"Detail\":\"Meet up as agreed and have a lovely time.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)39, "{\"SupportActivityInstructions\":39,\"ActivityDetails\":null,\"Intro\":\"If you need to complete your volunteer induction training you can book on to this course.\",\"Steps\":[{\"Heading\":\"Book your place\",\"Detail\":\"Accept this shift to book your place.\"},{\"Heading\":\"Attend the training\",\"Detail\":\"Use the details provided to attend your training.\"},{\"Heading\":\"We’ll update your record\",\"Detail\":\"Once you’ve completed your training we’ll update your record.\"}],\"Close\":\"If for any reason you can’t attend the training you’ve selected, let us know by updating your shift and clicking “Can’t Do”. You can re-book onto any available training at any time.\"}" },
                    { (short)37, "{\"SupportActivityInstructions\":37,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivity",
                columns: new[] { "ID", "Name" },
                values: new object[] { 28, "VolunteerInduction" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 39, "AgeConnectCardiff_VolunteerInduction" },
                    { 38, "AgeConnectCardiff_Transport" },
                    { 37, "AgeConnectCardiff_Other" },
                    { 36, "AgeConnectCardiff_InPersonBefriending" },
                    { 35, "AgeConnectCardiff_PracticalSupport" },
                    { 34, "AgeConnectCardiff_VolunteerSupport" }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -23, 26, (short)36 },
                    { -23, 16, (short)38 },
                    { -23, 27, (short)35 },
                    { -23, 22, (short)34 },
                    { -23, 11, (short)37 },
                    { -23, 28, (short)39 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Configuration",
                table: "SupportActivity",
                keyColumn: "SupportActivityID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 16 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 22 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 26 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 27 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 28 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivity",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)34);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)35);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)36);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)37);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)38);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)39);
        }
    }
}
