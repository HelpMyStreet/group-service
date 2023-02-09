using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ChangeAdvertisingRoleInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)65,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":65,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the opportunity is right for you\",\"Detail\":\"Make sure you’ve clicked to ‘view more info’ on the open request to check the opportunity is right for you.\"},{\"Heading\":\"Click to enquire\",\"Detail\":\"We will share your details with the organisation managing the request. They will contact you shortly to discuss the role and take you through the next steps to apply.\"},{\"Heading\":\"Complete application process\",\"Detail\":\"The application process will differ by role, but generally includes some form of training or induction. You’ll need to complete any necessary steps before you can start helping.\"},{\"Heading\":\"Start volunteering\",\"Detail\":\"Once everything is in place you can start volunteering! The request will stay in your “My Requests” view until you have completed or resigned from the volunteer role.\"}],\"Close\":\"In your “My Requests” view you can mark the request as complete or let the requester know you can no longer help by clicking “Can’t Do” so they can’t start looking for a new volunteer.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)65,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":65,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the opportunity is right for you\",\"Detail\":\"Make sure you’ve clicked to ‘view more info’ on the open request to check the opportunity is right for you.\"},{\"Heading\":\"Click to enquire\",\"Detail\":\"We will share your details with the organisation managing the request. They will contact you shortly to discuss the role and take you through the next steps to apply.\"},{\"Heading\":\"Complete application process\",\"Detail\":\"The application process will differ by role, but generally includes some form of training or induction. You’ll need to complete any necessary steps before you can start helping.\"},{\"Heading\":\"Start helping\",\"Detail\":\"Once everything is in place you can start helping! The request will stay in your “My Requests” view for as long as you’re helping.\"}],\"Close\":\"In your “My Requests” view you can mark the request as complete or let the requester know you can no longer help by clicking “Can’t Do” so they can’t start looking for a new volunteer.\"}");
        }
    }
}
