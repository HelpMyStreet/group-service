using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveAgeConnectsGroup_Step7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -23, (byte)0 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -23, (byte)1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 16 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 22 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 26 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 27 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -23, 28 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                keyColumn: "GroupID",
                keyValue: -23);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)34);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)35);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)36);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)37);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)38);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)39);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)42);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)43);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)44);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[] { -23, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to do a couple of checks. We need two references from people who have known you for more than a year, they must also be over 18 and not related to you. If you would like to undertake any roles which involve face-to-face contact with a client we will also need a DBS check. Please download our Volunteer Application Form from the <a href=\\\"{{BaseUrl}}/ageconnects-cardiff#resources\\\">useful links</a> section of our landing page to submit your details.<p><p>All of our volunteers also need to complete an induction. This is a short web-session which gives us a chance to run through our policies and procedures - it also gives you a chance to meet other volunteers and ask any questions. If you haven’t done so already, you can book your space for Core Induction Training on Eventbrite by clicking <a href=\\\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\\\">here</a>.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:helen.prior@ageconnectscardiff.org.uk\\\">helen.prior@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupMapDetails",
                columns: new[] { "GroupID", "MapLocationID", "Latitude", "Longitude", "ZoomLevel" },
                values: new object[,]
                {
                    { -23, (byte)1, 51.5022198m, -3.2752615m, 11m },
                    { -23, (byte)0, 51.5022198m, -3.2752615m, 11m }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "NewRequestNotificationStrategy",
                columns: new[] { "GroupID", "MaxVolunteer", "NewRequestNotificationStrategyId" },
                values: new object[] { -23, 2147483647, (byte)1 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[,]
                {
                    { (short)36, "{\"SupportActivityInstructions\":36,\"ActivityDetails\":\"As a Befriender you will visit older people who are experiencing loneliness and isolation to offer support and companionship.  It could be that you are the only person they see that day, or even that week. The client will have been assessed as being isolated and requested someone visit them regularly for a chat and to see someone new. We are looking for you to visit and have a friendly chat for at least one hour each time. We will arrange your first visit with the client (and most likely be there to introduce you, but this might not apply in all cases). On your first visit be prepared to introduce yourself – take along your ID badge or a letter from Age Connects explaining who you are. Agree with the client when and how often you will be visiting. We suggest keeping to the same time each week, but it can be flexible. Expenses can be claimed for this role.\",\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Visit the client\",\"Detail\":\"Meet up as agreed and have a lovely time - for the first visit, make sure you take along your ID badge or a letter from Age Connects explaining who you are\"},{\"Heading\":\"Contact your volunteer manager\",\"Detail\":\"Once you have completed your first visit, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more visits are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the visits anymore. We would also just love to hear how you’re getting on!\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}" },
                    { (short)43, "{\"SupportActivityInstructions\":43,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested someone ring them on a regular basis for a chat and to brighten their day. We have explained to the client that a volunteer will be calling, but they might have forgotten so be prepared to introduce yourself and explain your role. Agree on your first call when and how often you will be calling, we suggest keeping to the same time each week, but it can be flexible. Do not forget to “use 141” to withhold your number (otherwise, you might receive a call back at unsuitable hours). Feel free to browse the internet for ideas if you struggle to get the conversation going.\",\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Give the client a call\",\"Detail\":\"Be a friendly voice at the end of the phone and have a good chat.\"},{\"Heading\":\"Contact your volunteer manager\",\"Detail\":\"Once you have completed your first call, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more calls are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the call anymore. We would also just love to hear how you’re getting on!\"}],\"Close\":\"If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help.\"}" },
                    { (short)38, "{\"SupportActivityInstructions\":38,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the transport\",\"Detail\":\"Use the details given to you to pick up and drop off as required.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)35, "{\"SupportActivityInstructions\":35,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested some practical support. Expenses can be claimed for this role.\",\"Intro\":\"This role can be a range of different things such as form filling, helping someone do some research, assisting with telephone calls, teaching someone how to use their phone or tablet, changing a lightbulb or reading someone’s correspondence.\",\"Steps\":[{\"Heading\":\"Check what help is needed\",\"Detail\":\"Make sure to read all of the information available on the open request (including clicking on the “More Info” link). Only accept the request if you’re able to provide the help that is needed.\"},{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. Arrange a convenient date and time to provide the help.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help that is needed.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}" },
                    { (short)34, "{\"SupportActivityInstructions\":34,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Find out what help is needed\",\"Detail\":\"Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request.\"},{\"Heading\":\"Provide the help that is needed\",\"Detail\":\"Use the details given to you to carry out the request.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you're finished, mark the request as complete in “My Requests”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)37, "{\"SupportActivityInstructions\":37,\"ActivityDetails\":null,\"Intro\":null,\"Steps\":[{\"Heading\":\"Contact the requester\",\"Detail\":\"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"When you’re finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”.\"}" },
                    { (short)44, "{\"SupportActivityInstructions\":44,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested someone collect a prescription on their behalf. Most pharmacies will provide a delivery service for clients, so please explore with the client why they feel they need the help of a volunteer – it's possible they have not been able to get through on the phone or there is another issue that you can resolve for future prescriptions. If it is your first visit to a client, be prepared to introduce yourself – take along your ID badge or a letter from Age Connects explaining who you are. Expenses can be claimed for this role.\",\"Intro\":\"We are looking for you to pick up a prescription on a client’s behalf. (Prescriptions in Wales are free)\",\"Steps\":[{\"Heading\":\"Let the client know you’re able to help\",\"Detail\":\"Contact the client to let them know who you are and to confirm the help is still needed. You should also check if the client has told the pharmacy that you will be picking up the prescription on their behalf - see the [NHS website](https://www.nhs.uk/common-health-questions/caring-carers-and-long-term-conditions/can-i-pick-up-a-prescription-for-someone-else/) for more details.\"},{\"Heading\":\"Collect the prescription\",\"Detail\":\"Collect the prescription on the client’s behalf.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Once you have completed the task, mark it as complete from your “My Requests” page.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete.\"}],\"Close\":\"If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}" },
                    { (short)42, "{\"SupportActivityInstructions\":42,\"ActivityDetails\":\"This client has been assessed as being isolated (little or no family support) and has requested someone to shop for them. As a shopper you will be providing a shop and deliver service for the client either on a weekly or fortnightly basis. It could be that you are the only person they see or speak to that day, or even that week, and it can be an opportunity to provide the client with information about other services they may need. This is a fee-paying service, the client will pay £5 per shop. Expenses can be claimed for this role. Further guidance can be found when accepting the request, or in the ‘Volunteer Instructions’ section of the accepted request.\",\"Intro\":\"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.\",\"Steps\":[{\"Heading\":\"Confirm the shopping list\",\"Detail\":\"Contact the client to confirm what they need. Please read our [shopping guidance for Age Connects Volunteers](/pdf/ageconnectscardiff/shopping-guidance.pdf) for more detail about payment methods.\"},{\"Heading\":\"Provide help\",\"Detail\":\"Carry out the shopping and deliver it back to them. If they need it, we would like you to help them put the shopping away.\"},{\"Heading\":\"Mark the request as complete\",\"Detail\":\"Only mark the request as complete when no more help is required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support if you are helping with regular shopping.\"},{\"Heading\":\"Share any concerns or updates\",\"Detail\":\"Please make sure to tell us if you have any concerns about the client, or if they do not want the shopping service any more.\"}],\"Close\":\"If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx).\"}" },
                    { (short)39, "{\"SupportActivityInstructions\":39,\"ActivityDetails\":null,\"Intro\":\"If you need to complete your volunteer induction training you can book on to this course.\",\"Steps\":[{\"Heading\":\"Book your place\",\"Detail\":\"Accept this shift to book your place.\"},{\"Heading\":\"Attend the training\",\"Detail\":\"Use the details provided to attend your training.\"},{\"Heading\":\"We’ll update your record\",\"Detail\":\"Once you’ve completed your training we’ll update your record.\"}],\"Close\":\"If for any reason you can’t attend the training you’ve selected, let us know by updating your shift and clicking “Can’t Do”. You can re-book onto any available training at any time.\"}" }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityConfiguration",
                columns: new[] { "GroupID", "SupportActivityID", "Radius", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -23, 26, 20.0, (short)36 },
                    { -23, 7, 2000.0, (short)43 },
                    { -23, 16, 20.0, (short)38 },
                    { -23, 27, 20.0, (short)35 },
                    { -23, 22, 20.0, (short)34 },
                    { -23, 11, 20.0, (short)37 },
                    { -23, 2, 20.0, (short)44 },
                    { -23, 1, 20.0, (short)42 },
                    { -23, 28, 20.0, (short)39 }
                });
        }
    }
}
