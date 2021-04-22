﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class ActivityDetailsForCardiff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)35,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":35,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested some practical support. Expenses can be claimed for this role.\",\"Intro\":\"This role can be a range of different things such as form filling, helping someone do some research, assisting with telephone calls, teaching someone how to use their phone or tablet, changing a lightbulb or reading someone’s correspondence.\",\"Steps\":[{\"Heading\":\"Check what help is needed\",\"Detail\":\"Make sure to read all of the information available on the open request (including clicking on the “More Info” link). Only accept the request if you’re able to provide the help that is needed.\"},{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. Arrange a convenient date and time to provide the help.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that is needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)36,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":36,\"ActivityDetails\":\"As a Befriender you will visit older people who are experiencing loneliness and isolation to offer support and companionship.  It could be that you are the only person they see that day, or even that week. The client will have been assessed as being isolated and requested someone visit them regularly for a chat and to see someone new. We are looking for you to visit and have a friendly chat for at least one hour each time. We will arrange your first visit with the client (and most likely be there to introduce you, but this might not apply in all cases). On your first visit be prepared to introduce yourself – take along your ID badge or a letter from Age Connects explaining who you are. Agree with the client when and how often you will be visiting. We suggest keeping to the same time each week, but it can be flexible. Expenses can be claimed for this role.\",\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Visit the client\",\"Detail\":\"Meet up as agreed and have a lovely time - for the first visit, make sure you take along your ID badge or a letter from Age Connects explaining who you are\"},{\"Heading\":\"Contact your volunteer manager\",\"Detail\":\"Once you have completed your first visit, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more visits are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the visits anymore. We would also just love to hear how you’re getting on!\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)42,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":42,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested someone to shop for them. As a shopper you will be providing a shop and deliver service for the client either on a weekly or fortnightly basis. It could be that you are the only person they see or speak to that day, or even that week, and it can be an opportunity to provide the client with information about other services they may need. This is a fee-paying service, the client will pay £5 per shop. Expenses can be claimed for this role. Further guidance can be found when accepting the request, or in the ‘Volunteer Instructions’ section of the accepted request.\",\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Confirm the shopping list\",\"Detail\":\"Contact the client to confirm what they need. Please read our [shopping guidance for Age Connects Volunteers](/pdf/ageconnectscardiff/shopping-guidance.pdf) for more detail about payment methods.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Carry out the shopping and deliver it back to them. If they need it, we would like you to help them put the shopping away.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more help is required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support if you are helping with regular shopping.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the shopping service any more.\"}],\"Close\":\"If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)43,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":43,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested someone ring them on a regular basis for a chat and to brighten their day. We have explained to the client that a volunteer will be calling, but they might have forgotten so be prepared to introduce yourself and explain your role. Agree on your first call when and how often you will be calling, we suggest keeping to the same time each week, but it can be flexible. Do not forget to “use 141” to withhold your number (otherwise, you might receive a call back at unsuitable hours). Feel free to browse the internet for ideas if you struggle to get the conversation going.\",\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Give the client a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Contact your volunteer manager\",\"Detail\":\"Once you have completed your first call, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more calls are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the call anymore. We would also just love to hear how you’re getting on!\"}],\"Close\":\"If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)44,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":44,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested someone collect a prescription on their behalf. Most pharmacies will provide a delivery service for clients, so please explore with the client why they feel they need the help of a volunteer – it's possible they have not been able to get through on the phone or there is another issue that you can resolve for future prescriptions. If it is your first visit to a client, be prepared to introduce yourself – take along your ID badge or a letter from Age Connects explaining who you are. Expenses can be claimed for this role.\",\"Intro\":\"We are looking for you to pick up a prescription on a client’s behalf. (Prescriptions in Wales are free)\",\"Steps\":[{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. You should also check if the client has told the pharmacy that you will be picking up the prescription on their behalf - see the [NHS website](https://www.nhs.uk/common-health-questions/caring-carers-and-long-term-conditions/can-i-pick-up-a-prescription-for-someone-else/) for more details.\"},{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription on the client’s behalf.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: (short)36,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":36,\"ActivityDetails\":null,\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Visit the client\",\"Detail\":\"Meet up as agreed and have a lovely time - for the first visit, make sure you take along your ID badge or a letter from Age Connects explaining who you are\"},{\"Heading\":\"Contact your volunteer manager\",\"Detail\":\"Once you have completed your first visit, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more visits are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the visits anymore. We would also just love to hear how you’re getting on!\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)42,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":42,\"ActivityDetails\":null,\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Confirm the shopping list\",\"Detail\":\"Contact the client to confirm what they need. Please read our [shopping guidance for Age Connects Volunteers](/pdf/ageconnectscardiff/shopping-guidance.pdf) for more detail about payment methods.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Carry out the shopping and deliver it back to them. If they need it, we would like you to help them put the shopping away.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more help is required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support if you are helping with regular shopping.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the shopping service any more.\"}],\"Close\":\"If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)43,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":43,\"ActivityDetails\":null,\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Give the client a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Contact your volunteer manager\",\"Detail\":\"Once you have completed your first call, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more calls are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the call anymore. We would also just love to hear how you’re getting on!\"}],\"Close\":\"If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help.\"}");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)44,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":44,\"ActivityDetails\":null,\"Intro\":\"We are looking for you to pick up a prescription on a client’s behalf. (Prescriptions in Wales are free)\",\"Steps\":[{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. You should also check if the client has told the pharmacy that you will be picking up the prescription on their behalf - see the [NHS website](https://www.nhs.uk/common-health-questions/caring-carers-and-long-term-conditions/can-i-pick-up-a-prescription-for-someone-else/) for more details.\"},{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription on the client’s behalf.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}");
        }
    }
}