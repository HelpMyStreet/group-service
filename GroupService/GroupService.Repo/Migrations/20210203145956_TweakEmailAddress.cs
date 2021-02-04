using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakEmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: (short)23,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":23,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:kirsty.groves@ageuknorthwestkent.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)20,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":20,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK South Kent Coast)\",\"Detail\":\"Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.\"},{\"Heading\":\"Collecting the prescription\",\"Detail\":\"Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by mailto:emailingvolunteering@ageukskc.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)23,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":23,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK North West Kent)\",\"Detail\":\"Please contact mailto:kirsty.groves@ageuknorthwestkent.org.uk to arrange for the collection of hot meals and the delivery details.\"},{\"Heading\":\"Deliver the meals\",\"Detail\":\"Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Accepted Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknwk.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
