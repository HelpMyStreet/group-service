using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AlterGroupSupportActivityInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)22,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":22,\"ActivityDetails\":\"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept this role and basic training will be provided on the day\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Make sure you’ve read all the request details and are happy you can provide the help that is needed. You’ll find a brief summary of the role by clicking the ‘View more info’ link on the request, and more detail in our role description and useful information attachment (link to attached PDF).\"},{\"Heading\":\"Turn up and help (should be 2 but can’t make the numbering work)\",\"Detail\":\"When the help is needed, turn up to complete your shift. Make sure you arrive 15 minutes to receive an induction and basic training for the role. Please also bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat).\"},{\"Heading\":\"Feedback\",\"Detail\":\"Once you’ve completed a shift it was be marked as complete automatically. You’ll still be able to find the details of completed activity in “My Shifts”, as well as links to submit feedback to the organisation(s) who requested and received your help.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)22,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":22,\"ActivityDetails\":\"Activity details for vaccine support\",\"Intro\":null,\"Steps\":null,\"Close\":null}");
        }
    }
}
