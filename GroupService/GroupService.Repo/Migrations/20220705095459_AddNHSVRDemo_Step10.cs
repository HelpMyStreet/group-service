using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddNHSVRDemo_Step10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -38, 25, 20.0, (short)33 },
                    { -38, 11, 20.0, (short)2 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[,]
                {
                    { (short)66, "{\"SupportActivityInstructions\":66,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read all of the available information by expanding ‘more information’ on the open request before clicking to accept a request. You must have your own transport that is suitable for the journey described in the request (you can cycle or walk if appropriate).\"},{\"Heading\":\"Completing the request\",\"Detail\":\"You’ll receive a reminder email the day before the transportation is required. Make sure to arrive on time and have a copy of the pick-up and drop-off locations to hand.\"},{\"Heading\":\"Marking it as complete\",\"Detail\":\"Once you’ve completed a request don’t forget to mark it as complete in your “My Requests” tab, this will let the requesting organisation know you have completed the task.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}" },
                    { (short)67, "{\"SupportActivityInstructions\":67,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read all of the available information by expanding ‘more information’ on the open request before clicking to accept a shift.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab by searching for shifts with the status “Done”\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}" },
                    { (short)68, "{\"SupportActivityInstructions\":68,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}" },
                    { (short)69, "{\"SupportActivityInstructions\":68,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Give them a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 66, "NHSDemo_Transport" },
                    { 67, "NHSDemo_Steward" },
                    { 68, "NHSDemo_CheckInAndChat" },
                    { 69, "NHSDemo_CheckInAndChatPlus" }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -38, 37, 20.0, (short)66 },
                    { -38, 36, 20.0, (short)67 },
                    { -38, 38, 20.0, (short)68 },
                    { -38, 39, 20.0, (short)69 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -38, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -38, 25 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -38, 36 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -38, 37 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -38, 38 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -38, 39 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)66);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)67);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)68);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)69);
        }
    }
}
