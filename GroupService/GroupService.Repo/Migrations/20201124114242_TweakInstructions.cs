using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)1,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":1,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)2,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":2,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)4,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":4,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)1,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":1,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)2,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":2,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)4,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":4,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good natter.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
