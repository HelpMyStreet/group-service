using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakGroupDetailsForKent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Age UK", "South Kent Coast" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)16,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":16,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"For the Folkestone area please contact the Marigold Centre on 01303 279031, or for the Deal area contact the Deal Centre on 01304 372608 to book your meal. (You provide the company; we’ll provide the food!).\"},{\"Heading\":\"Enjoy your dinner together\",\"Detail\":\"Use the details given to you to meet up at the person’s chosen mealtime (usually between 12 noon and 1pm). Have a chat and provide some company for the person you’re joining.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)17,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)18,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info' link. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)19,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":19,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk .\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)20,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":20,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by mailto:emailingvolunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)21,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":21,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Mark", "Colley" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)16,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":16,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact Marigold Centre for the  Folkestone area on 01303 279031 or for the Deal Area contact the Deal Centre on 01304 372608 to book your meal (you provide the company, we’ll provide the food!).\"},{\"Heading\":\"Enjoy your dinner together\",\"Detail\":\"Use the details given to you to meet up at the person’s chosen mealtime ( usually between 12 noon and 1pm). Have a chat and provide some company for the person you’re joining.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk. If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)17,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk. If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)18,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":17,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)19,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":19,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)20,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":20,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us Age UK South Kent Coast\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by mailto:emailingvolunteering@ageukskc.org.uk  If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)21,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":21,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us Age UK South Kent Coast\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.\"},{\"Heading\":\"Purchase the shopping items\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
