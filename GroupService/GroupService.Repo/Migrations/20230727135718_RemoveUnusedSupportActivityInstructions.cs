using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveUnusedSupportActivityInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)9);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[,]
                {
                    { (short)9, "{\"SupportActivityInstructions\":9,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact us (Age UK Lincoln & South Lincolnshire)\",\"Detail\":\"Please contact volunteering@ageuklsl.org.uk to arrange collection of a pre-made wellbeing package from one of our sites. We’ll also give you all the details you need for the delivery.\"},{\"Heading\":\"Deliver the package\",\"Detail\":\"Use the details provided to deliver the package. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. If you have any concerns about the person you visited let us know immediately by emailing volunteering@ageuklsl.org.uk.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)40, "{\"SupportActivityInstructions\":40,\"ActivityDetails\":null,\"Intro\":\"We are working on some changes which will make it easier to manage repeat requests, but for now please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Check how long the help is needed for\",\"Detail\":\"You can find out more in the ‘More details’ section of the request. Some requests may be for one-off help, while others are for ongoing support.\"},{\"Heading\":\"Take out the bins\",\"Detail\":\"When the help is needed, take out the bins. Make sure you take them out first thing (or the night before) and bring them back in if required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When the help is no longer needed, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" }
                });
        }
    }
}
