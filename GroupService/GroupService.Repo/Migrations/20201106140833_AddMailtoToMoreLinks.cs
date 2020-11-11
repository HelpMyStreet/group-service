using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddMailtoToMoreLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)10,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":10,\"Intro\":\"This request has been created by Age UK Wirral. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Go shopping\",\"Detail\":\"Pick up their shopping, you will find their shopping list and any specific instructions in “My Accepted Requests”. You’ll need to pay for the shopping on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt\",\"Detail\":\"Write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the shopping\",\"Detail\":\"Drop off the shopping along with the original copy of the receipt. You’ll find their details in “My Accepted Requests”.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)11,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":11,\"Intro\":\"This request has been created by *Age UK Wirral*. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription from the pharmacy, you will find details of the pharmacy in “My Accepted Requests”. If the prescription needs paying for, you’ll need to pay for it on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt (if you paid)\",\"Detail\":\"If you paid for the prescription, write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the medication\",\"Detail\":\"Drop off the medication (along with the original copy of the receipt if you paid for it). You’ll find their details in “My Accepted Requests”\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)10,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":10,\"Intro\":\"This request has been created by Age UK Wirral. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Go shopping\",\"Detail\":\"Pick up their shopping, you will find their shopping list and any specific instructions in “My Accepted Requests”. You’ll need to pay for the shopping on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt\",\"Detail\":\"Write the name of the client on the receipt and email us a photograph to emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the shopping\",\"Detail\":\"Drop off the shopping along with the original copy of the receipt. You’ll find their details in “My Accepted Requests”.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)11,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":11,\"Intro\":\"This request has been created by Age UK Wirral. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription from the pharmacy, you will find details of the pharmacy in “My Accepted Requests”. If the prescription needs paying for, you’ll need to pay for it on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt (if you paid)\",\"Detail\":\"If you paid for the prescription, write the name of the client on the receipt and email us a photograph to emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the medication\",\"Detail\":\"Drop off the medication (along with the original copy of the receipt if you paid for it). You’ll find their details in “My Accepted Requests”\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
