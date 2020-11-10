using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class MakeLinksRelative : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "{\"SupportActivityInstructions\":2,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if they’ll be a charge for anything, and if needed agree how they will pay you back.You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)7,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":7,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how they will pay you back (£2 - £3 per face covering to cover the cost of materials plus the cost of postage if required). You can find out more about secure payment methods in our [FAQs](/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)8,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":8,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Let them know that they can make a donation [here](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet) (suggested £3 - £4 per face covering). If you need to post the face coverings let them know if you’ll need them to cover the cost of postage on top of the donation and agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt. If you need more materials email requestmaterials.ftlos@outlook.com.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way and share a link to [our fundraising page](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet).\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)1,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":1,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](https://www.helpmystreet.org/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)2,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":2,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if they’ll be a charge for anything, and if needed agree how they will pay you back.You can find out more about secure payment methods in our [FAQs](https://www.helpmystreet.org/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)7,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":7,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how they will pay you back (£2 - £3 per face covering to cover the cost of materials plus the cost of postage if required). You can find out more about secure payment methods in our [FAQs](https://www.helpmystreet.org/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)8,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":8,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Let them know that they can make a donation [here](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet) (suggested £3 - £4 per face covering). If you need to post the face coverings let them know if you’ll need them to cover the cost of postage on top of the donation and agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](https://www.helpmystreet.org/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt. If you need more materials email requestmaterials.ftlos@outlook.com.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way and share a link to [our fundraising page](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet).\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you’ve done, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
