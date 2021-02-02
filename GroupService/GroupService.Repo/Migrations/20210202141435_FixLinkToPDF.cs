using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class FixLinkToPDF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)22,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":22,\"ActivityDetails\":\"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the shift or by clicking ‘View more info’ on accepted shifts in the “My Shifts” tab.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Make sure you’ve read all of the information available to you and are happy to provide the help that is needed. You’ll find a brief summary of the role by clicking the ‘View more info’ link on the request, and more detail in our [role description and useful information](/pdf/lincs-vaccination-support/lincs-vaccination-support-role-description.pdf) attachment.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"Once you've accepted a shift you will get a confirmation email straight away and a reminder email the day before your shift. Please arrive 15 minutes before the start of your shift to receive an induction and basic training for the role. Please also bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). If for any reason you need to cancel you shift, let us know as soon as possible by updating the request in the “My Shifts” tab and clicking “Can’t Do”.\"},{\"Heading\":\"Feedback\",\"Detail\":\"Once you’ve completed a shift it was be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab, as well as links to submit feedback to the organisation(s) who requested and received your help.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)22,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":22,\"ActivityDetails\":\"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the shift or by clicking ‘View more info’ on accepted shifts in the “My Shifts” tab.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Make sure you’ve read all of the information available to you and are happy to provide the help that is needed. You’ll find a brief summary of the role by clicking the ‘View more info’ link on the request, and more detail in our role description and useful information attachment (link to attached PDF).\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"Once you've accepted a shift you will get a confirmation email straight away and a reminder email the day before your shift. Please arrive 15 minutes before the start of your shift to receive an induction and basic training for the role. Please also bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). If for any reason you need to cancel you shift, let us know as soon as possible by updating the request in the “My Shifts” tab and clicking “Can’t Do”.\"},{\"Heading\":\"Feedback\",\"Detail\":\"Once you’ve completed a shift it was be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab, as well as links to submit feedback to the organisation(s) who requested and received your help.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}");
        }
    }
}
