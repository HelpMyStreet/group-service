using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakMeadowsConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "meadows-community-helpers", "Meadows Community Helpers" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)40,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":40,\"ActivityDetails\":null,\"Intro\":\"We are working on some changes which will make it easier to manage repeat requests, but for now please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Check how long the help is needed for\",\"Detail\":\"You can find out more in the ‘More details’ section of the request. Some requests may be for one-off help, while others are for ongoing support.\"},{\"Heading\":\"Take out the bins\",\"Detail\":\"When the help is needed, take out the bins. Make sure you take them out first thing (or the night before) and bring them back in if required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When the help is no longer needed, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "GroupKey", "GroupName" },
                values: new object[] { "meadow-community-helpers", "Meadow Community Helpers" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)40,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":40,\"ActivityDetails\":null,\"Intro\":\"We are working on some changes which will make it easier to manage repeat requests, but for now please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Check how long the help is needed for\",\"Detail\":\"You can find out more in the ‘More details’ section of the request. Some requests may be for one-off help, while others are for ongoing support.\"},{\"Heading\":\"Take out the bins\",\"Detail\":\"When the help is needed, take out the bins. Make sure you take them out first thing (or the night before) and bring them back in if required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When the help is no longer needed, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed.\"}],\"Close\":\"If for any reason you can’t attend the training you’ve selected, let us know by updating your shift and clicking “Can’t Do”. You can re-book onto any available training at any time.\"}");
        }
    }
}
