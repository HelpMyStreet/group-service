using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddMoreMarkdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)8,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":8,\"Intro\":\"This is a request for the *For the Love of Scrubs* team. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Let them know that they can make a donation here (suggested £3 - £4 per face covering). If you need to post the face coverings let them know if you’ll need them to cover the cost of postage on top of the donation and agree how they will pay you back. You can find out more about secure payment methods in our FAQs.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt. If you need more materials email requestmaterials.ftlos@outlook.com.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way and share a link to our fundraising page.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)9,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":9,\"Intro\":\"This request has been created by *Age UK Lincoln & South Lincolnshire*. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact volunteering@ageuklsl.org.uk to arrange collection of a pre-made wellbeing package from one of our sites. We’ll also give you all the details you need for the delivery.\"},{\"Heading\":\"Deliver the package\",\"Detail\":\"Use the details provided to deliver the package. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)10,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":10,\"Intro\":\"This request has been created by *Age UK Wirral*. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Go shopping\",\"Detail\":\"Pick up their shopping, you will find their shopping list and any specific instructions in “My Accepted Requests”. You’ll need to pay for the shopping on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt\",\"Detail\":\"Write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the shopping\",\"Detail\":\"Drop off the shopping along with the original copy of the receipt. You’ll find their details in “My Accepted Requests”.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)12,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":12,\"Intro\":\"This request has been created by *Age UK Wirral*. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)8,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":8,\"Intro\":\"This is a request for the For the Love of Scrubs team. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Let them know that they can make a donation here (suggested £3 - £4 per face covering). If you need to post the face coverings let them know if you’ll need them to cover the cost of postage on top of the donation and agree how they will pay you back. You can find out more about secure payment methods in our FAQs.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt. If you need more materials email requestmaterials.ftlos@outlook.com.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way and share a link to our fundraising page.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)9,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":9,\"Intro\":\"This request has been created by Age UK Lincoln & South Lincolnshire. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact volunteering@ageuklsl.org.uk to arrange collection of a pre-made wellbeing package from one of our sites. We’ll also give you all the details you need for the delivery.\"},{\"Heading\":\"Deliver the package\",\"Detail\":\"Use the details provided to deliver the package. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

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
                keyValue: (short)12,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":12,\"Intro\":\"This request has been created by Age UK Wirral. Please read the following instructions for completing the request.\",\"Steps\":[{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
