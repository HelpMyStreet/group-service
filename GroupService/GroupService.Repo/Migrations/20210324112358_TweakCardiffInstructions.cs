﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakCardiffInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)35,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":35,\"ActivityDetails\":null,\"Intro\":\"This role can be a range of different things such as form filling, helping someone do some research, assisting with telephone calls, teaching someone how to use their phone or tablet, changing a lightbulb or reading someone’s correspondence.\",\"Steps\":[{\"Heading\":\"Check what help is needed\",\"Detail\":\"Make sure to read all of the information available on the open request (including clicking on the “More Info” link). Only accept the request if you’re able to provide the help that is needed.\"},{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. Arrange a convenient date and time to provide the help.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that is needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)44,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":44,\"ActivityDetails\":null,\"Intro\":\"We are looking for you to pick up a prescription on a client’s behalf. (Prescriptions in Wales are free)\",\"Steps\":[{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. You should also check if the client has told the pharmacy that you will be picking up the prescription on their behalf - see the [NHS website] (https://www.nhs.uk/common-health-questions/caring-carers-and-long-term-conditions/can-i-pick-up-a-prescription-for-someone-else/) for more details.\"},{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription on the client’s behalf.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)35,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":35,\"ActivityDetails\":\"[Expense Form](/forms/ageconnect/cardiff/volunteer-expense-form.docx)\",\"Intro\":\"This role can be a range of different things such as form filling, helping someone do some research, assisting with telephone calls, teaching someone how to use their phone or tablet, changing a lightbulb or reading someone’s correspondence.\",\"Steps\":[{\"Heading\":\"Check what help is needed\",\"Detail\":\"Make sure to read all of the information available on the open request (including clicking on the “More Info” link). Only accept the request if you’re able to provide the help that is needed.\"},{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. Arrange a convenient date and time to provide the help.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that is needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)44,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":44,\"ActivityDetails\":\"[Expenses Form](/forms/ageconnect/cardiff/volunteer-expense-form.docx)\",\"Intro\":\"We are looking for you to pick up a prescription on a client’s behalf. (Prescriptions in Wales are free)\",\"Steps\":[{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. You should also check if the client has told the pharmacy that you will be picking up the prescription on their behalf - see the [NHS website] (https://www.nhs.uk/common-health-questions/caring-carers-and-long-term-conditions/can-i-pick-up-a-prescription-for-someone-else/) for more details.\"},{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription on the client’s behalf.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");
        }
    }
}
