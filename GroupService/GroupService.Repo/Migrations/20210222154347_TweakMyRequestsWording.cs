using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakMyRequestsWording : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)1,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":1,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)2,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":2,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)3,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":3,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Get in touch with the person who needs the help to confirm what they need. If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)4,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":4,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)5,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":5,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Get in touch to find out how you can help.\"},{\"Heading\":\"Solve the problem… hopefully!\",\"Detail\":\"If you’re able, give them the support they need.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due (including if you don’t know the answer!), let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)6,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":6,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check in\",\"Detail\":\"Give them a call or knock on the door to find out if they’re OK. You can also see if they need anything and let them know someone’s asking after them.\"},{\"Heading\":\"Contact the requester\",\"Detail\":\"A check in is usually requested by someone else for a friend, neighbour or loved one. Give the person who requested the help a call to let them know how it went.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)7,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":7,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how they will pay you back (£2 - £3 per face covering to cover the cost of materials plus the cost of postage if required). You can find out more about secure payment methods in our [FAQs](/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)8,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":8,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Let them know that they can make a donation [here](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet) (suggested £3 - £4 per face covering). If you need to post the face coverings let them know if you’ll need them to cover the cost of postage on top of the donation and agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt. If you need more materials email mailto:requestmaterials.ftlos@outlook.com.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way and share a link to [our fundraising page](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet).\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)9,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":9,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact volunteering@ageuklsl.org.uk to arrange collection of a pre-made wellbeing package from one of our sites. We’ll also give you all the details you need for the delivery.\"},{\"Heading\":\"Deliver the package\",\"Detail\":\"Use the details provided to deliver the package. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)10,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":10,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Go shopping\",\"Detail\":\"Pick up their shopping, you will find their shopping list and any specific instructions in “My Requests”. You’ll need to pay for the shopping on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt\",\"Detail\":\"Write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the shopping\",\"Detail\":\"Drop off the shopping along with the original copy of the receipt. You’ll find their details in “My Requests”.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)11,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":11,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription from the pharmacy, you will find details of the pharmacy in “My Requests”. If the prescription needs paying for, you’ll need to pay for it on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt (if you paid)\",\"Detail\":\"If you paid for the prescription, write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the medication\",\"Detail\":\"Drop off the medication (along with the original copy of the receipt if you paid for it). You’ll find their details in “My Requests”\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)12,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":12,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)13,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":13,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)14,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":14,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)15,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":15,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)16,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":16,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"For the Folkestone area please contact the Marigold Centre on 01303 279031, or for the Deal area contact the Deal Centre on 01304 372608 to book your meal. (You provide the company; we’ll provide the food!).\"},{\"Heading\":\"Enjoy your dinner together\",\"Detail\":\"Use the details given to you to meet up at the person’s chosen mealtime (usually between 12 noon and 1pm). Have a chat and provide some company for the person you’re joining.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)17,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)18,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info' link. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)19,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":19,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk .\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)20,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":20,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)21,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":21,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)23,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":23,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:kirsty.groves@ageuknorthwestkent.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)24,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":24,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)25,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":25,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)26,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":26,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)27,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":27,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)28,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":28,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Faversham & Sittingbourne)\",\"Detail\":\"Please contact mailto:volunteering@ageukfaversham.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)29,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":29,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Faversham & Sittingbourne)\",\"Detail\":\"Please contact mailto:volunteering@ageukfaversham.org.uk to book your meal (you provide the company, we’ll provide the food!).\"},{\"Heading\":\"Enjoy your dinner together\",\"Detail\":\"Use the details given to you to meet up at your chosen mealtime. Have a chat and provide some company for the person you’re joining.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're home, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)30,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":30,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the transport\",\"Detail\":\"Use the details given to you to pick up and drop off as required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)31,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":31,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)32,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":32,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Faversham & Sittingbourne)\",\"Detail\":\"Please contact mailto:volunteering@ageukfaversham.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)1,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":1,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)2,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":2,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)3,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":3,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Get in touch with the person who needs the help to confirm what they need. If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)4,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":4,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)5,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":5,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Get in touch to find out how you can help.\"},{\"Heading\":\"Solve the problem… hopefully!\",\"Detail\":\"If you’re able, give them the support they need.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due (including if you don’t know the answer!), let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)6,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":6,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check in\",\"Detail\":\"Give them a call or knock on the door to find out if they’re OK. You can also see if they need anything and let them know someone’s asking after them.\"},{\"Heading\":\"Contact the requester\",\"Detail\":\"A check in is usually requested by someone else for a friend, neighbour or loved one. Give the person who requested the help a call to let them know how it went.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)7,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":7,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need and agree how they will pay you back (£2 - £3 per face covering to cover the cost of materials plus the cost of postage if required). You can find out more about secure payment methods in our [FAQs](/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)8,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":8,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Let them know that they can make a donation [here](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet) (suggested £3 - £4 per face covering). If you need to post the face coverings let them know if you’ll need them to cover the cost of postage on top of the donation and agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](/questions#5).\"},{\"Heading\":\"Provide help\",\"Detail\":\"Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt. If you need more materials email mailto:requestmaterials.ftlos@outlook.com.\"},{\"Heading\":\"Let them know they’re on the way\",\"Detail\":\"Drop the recipient a note to let them know they’re on the way and share a link to [our fundraising page](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet).\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)9,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":9,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact volunteering@ageuklsl.org.uk to arrange collection of a pre-made wellbeing package from one of our sites. We’ll also give you all the details you need for the delivery.\"},{\"Heading\":\"Deliver the package\",\"Detail\":\"Use the details provided to deliver the package. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)10,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":10,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Go shopping\",\"Detail\":\"Pick up their shopping, you will find their shopping list and any specific instructions in “My Accepted Requests”. You’ll need to pay for the shopping on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt\",\"Detail\":\"Write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the shopping\",\"Detail\":\"Drop off the shopping along with the original copy of the receipt. You’ll find their details in “My Accepted Requests”.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)11,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":11,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription from the pharmacy, you will find details of the pharmacy in “My Accepted Requests”. If the prescription needs paying for, you’ll need to pay for it on your own card before claiming the money back.\"},{\"Heading\":\"Send us a copy of the receipt (if you paid)\",\"Detail\":\"If you paid for the prescription, write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.\"},{\"Heading\":\"Drop off the medication\",\"Detail\":\"Drop off the medication (along with the original copy of the receipt if you paid for it). You’ll find their details in “My Accepted Requests”\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)12,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":12,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that’s needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)13,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":13,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)14,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":14,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)15,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":15,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)16,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":16,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"For the Folkestone area please contact the Marigold Centre on 01303 279031, or for the Deal area contact the Deal Centre on 01304 372608 to book your meal. (You provide the company; we’ll provide the food!).\"},{\"Heading\":\"Enjoy your dinner together\",\"Detail\":\"Use the details given to you to meet up at the person’s chosen mealtime (usually between 12 noon and 1pm). Have a chat and provide some company for the person you’re joining.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)17,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)18,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info' link. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)19,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":19,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk .\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)20,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":20,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)21,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":21,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)23,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":23,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:kirsty.groves@ageuknorthwestkent.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)24,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":24,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)25,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":25,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)26,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":26,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)27,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":27,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)28,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":28,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Faversham & Sittingbourne)\",\"Detail\":\"Please contact mailto:volunteering@ageukfaversham.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)29,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":29,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Faversham & Sittingbourne)\",\"Detail\":\"Please contact mailto:volunteering@ageukfaversham.org.uk to book your meal (you provide the company, we’ll provide the food!).\"},{\"Heading\":\"Enjoy your dinner together\",\"Detail\":\"Use the details given to you to meet up at your chosen mealtime. Have a chat and provide some company for the person you’re joining.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're home, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)30,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":30,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the transport\",\"Detail\":\"Use the details given to you to pick up and drop off as required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)31,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":31,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)32,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":32,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Faversham & Sittingbourne)\",\"Detail\":\"Please contact mailto:volunteering@ageukfaversham.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
