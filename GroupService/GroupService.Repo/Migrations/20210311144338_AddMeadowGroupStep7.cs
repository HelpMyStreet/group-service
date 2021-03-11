using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddMeadowGroupStep7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -24, 1, (short)1 },
                    { -24, 12, (short)7 },
                    { -24, 10, (short)6 },
                    { -24, 2, (short)2 },
                    { -24, 3, (short)2 },
                    { -24, 29, (short)3 },
                    { -24, 7, (short)4 },
                    { -24, 31, (short)3 },
                    { -24, 22, (short)18 },
                    { -24, 11, (short)2 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)40, "{\"SupportActivityInstructions\":40,\"ActivityDetails\":null,\"Intro\":\"We are working on some changes which will make it easier to manage repeat requests, but for now please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Check how long the help is needed for\",\"Detail\":\"You can find out more in the ‘More details’ section of the request. Some requests may be for one-off help, while others are for ongoing support.\"},{\"Heading\":\"Take out the bins\",\"Detail\":\"When the help is needed, take out the bins. Make sure you take them out first thing (or the night before) and bring them back in if required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When the help is no longer needed, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed.\"}],\"Close\":\"If for any reason you can’t attend the training you’ve selected, let us know by updating your shift and clicking “Can’t Do”. You can re-book onto any available training at any time.\"}" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[] { -24, 30, (short)40 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 3 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 10 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 22 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 29 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 30 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -24, 31 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)40);
        }
    }
}
