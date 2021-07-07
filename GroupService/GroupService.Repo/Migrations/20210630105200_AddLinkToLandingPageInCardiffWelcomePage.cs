using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddLinkToLandingPageInCardiffWelcomePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to do a couple of checks. We need two references from people who have known you for more than a year, they must also be over 18 and not related to you. If you would like to undertake any roles which involve face-to-face contact with a client we will also need a DBS check. Please download our Volunteer Application Form from the <a href=\\\"{{BaseUrl}}/ageconnects-cardiff#resources\\\">useful links</a> section of our landing page to submit your details.<p><p>All of our volunteers also need to complete an induction. This is a short web-session which gives us a chance to run through our policies and procedures - it also gives you a chance to meet other volunteers and ask any questions. If you haven’t done so already, you can book your space for Core Induction Training on Eventbrite by clicking <a href=\\\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\\\">here</a>.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@ageconnectscardiff.org.uk\\\">info@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to do a couple of checks. We need two references from people who have known you for more than a year, they must also be over 18 and not related to you. If you would like to undertake any roles which involve face-to-face contact with a client we will also need a DBS check. Please complete and return this <a href=\\\"{{BaseUrl}}/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx\\\">form</a> with details of your references and to request a DBS check if required.<p><p>All of our volunteers also need to complete an induction. This is a short web-session which gives us a chance to run through our policies and procedures - it also gives you a chance to meet other volunteers and ask any questions. If you haven’t done so already, you can book your space for Core Induction Training on Eventbrite by clicking <a href=\\\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\\\">here</a>.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@ageconnectscardiff.org.uk\\\">info@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");
        }
    }
}
