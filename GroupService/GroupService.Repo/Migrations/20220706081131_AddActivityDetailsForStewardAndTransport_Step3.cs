using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddActivityDetailsForStewardAndTransport_Step3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)67,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":67,\"ActivityDetails\":\"Volunteers are needed to support the safe movement of patients around events / sites. You may be required to monitor patient numbers, ensure safe social distancing, or identify patients requiring additional support. The maximum shift length is 4 hours.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read all of the available information by expanding ‘more information’ on the open request before clicking to accept a shift.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab by searching for shifts with the status “Done”\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)67,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":67,\"ActivityDetails\":\"Volunteers are needed to support the safe movement of patients around events / sites. You may be required to monitor patient numbers, ensure safe social distancing, or identify patients requiring additional support.The maximum shift length is 4 hours.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read all of the available information by expanding ‘more information’ on the open request before clicking to accept a shift.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab by searching for shifts with the status “Done”\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}");
        }
    }
}
