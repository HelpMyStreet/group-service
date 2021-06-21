using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakGroupEmailsAndTidyUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to do a couple of checks. We need two references from people who have known you for more than a year, they must also be over 18 and not related to you. If you would like to undertake any roles which involve face-to-face contact with a client we will also need a DBS check.</p><p>All of our volunteers also need to complete an induction. This is a short web-session which gives us a chance to run through our policies and procedures - it also gives you a chance to meet other volunteers and ask any questions. Find out more about these checks when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@ageconnectscardiff.org.uk\\\">info@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>North Muskham Community Support\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:northmuskham@helpmystreet.org.\\\">northmuskham@helpmystreet.org</a>.\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -7, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to do a couple of checks. You will need to verify your ID - which you can do in just a couple of minutes online - and register a DBS check with us. If you’re having trouble verifying your ID or need to register a DBS check email <a href=\\\"mailto:volunteers@ageukwirral.org.uk\\\">volunteers@ageukwirral.org.uk</a>.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK Wirral\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:volunteers@ageukwirral.org.uk\\\">volunteers@ageukwirral.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[] { -32, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>We are using HelpMyStreet to coordinate our bank shifts. To book onto a shift you will need to have met the essential criteria for the role. If there is something missing from your profile we will let you know when you try to book onto a shift.Please be aware that shifts may be added or cancelled at short notice due to unexpected demand. </p><p>HelpMyStreet was originally built for volunteering so please be aware that there may be some unpaid volunteer roles advertised on the platform. All of our roles will specify where they are paid positions.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Kind regards,</p><p>Gary Burroughs - PCN Manager\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -8, (byte)0 },
                column: "ZoomLevel",
                value: 13.5m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -32, (byte)15 });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID and collect two references – this is to make things as safe as possible for you and the people we help. Your referees need to have known you for at least year, be over 18 and not related to you. Download our references form <a href=\\\"{{BaseUrl}}/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx\\\">here</a> for more details.</p><p>We also ask all volunteers to complete our volunteer induction. This is a short web-session which gives us a chance to run through our policies and procedures. It also gives you a chance to meet other volunteers and ask any questions. We will contact you with the next available date when we receive your references. We may also require a DBS check; we’ll be in touch with more information about this if required.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@ageconnectscardiff.org.uk\\\">info@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>North Muskham Community Support\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:northmuskham@helpmystreet.org.\\\">northmuskham@helpmystreet.org</a>.\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -7, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to do a couple of checks. You will need to verify your ID - which you can do in just a couple of minutes online - and register a DBS check with us. If you’re having trouble verifying your ID or need to register a DBS check email <a href=\\\"mailto:volunteers@ageukwirral.org.uk\\\">volunteers@ageukwirral.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK Wirral\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:ruddington@helpmystreet.org\\\">ruddington@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupMapDetails",
                keyColumns: new[] { "GroupID", "MapLocationID" },
                keyValues: new object[] { -8, (byte)0 },
                column: "ZoomLevel",
                value: 12m);
        }
    }
}
