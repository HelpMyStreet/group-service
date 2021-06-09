using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AmendGroupWelcomeEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -24, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>The Meadows Community Helpers\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:meadows-community-helpers@helpmystreet.org\\\">meadows-community-helpers@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID and collect two references – this is to make things as safe as possible for you and the people we help. Your referees need to have known you for at least year, be over 18 and not related to you. Download our references form <a href=\\\"{BaseUrl}/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx\\\">here</a> for more details.</p><p>We also ask all volunteers to complete our volunteer induction. This is a short web-session which gives us a chance to run through our policies and procedures. It also gives you a chance to meet other volunteers and ask any questions. We will contact you with the next available date when we receive your references. We may also require a DBS check; we’ll be in touch with more information about this if required.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@ageconnectscardiff.org.uk\\\">info@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -22, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p><p>For some roles, we may also require additional checks or training – we will let you know if any additional checks are needed before accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contact@helpmystreet.org\\\">contact@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -20, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -17, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -13, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:volunteering@ageukfaversham.org.uk\\\">volunteering@ageukfaversham.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK South Kent Coast\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:volunteering@ageukfaversham.org.uk.\\\">volunteering@ageukfaversham.org.uk</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -12, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>The Lincolnshire Volunteers Team\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -11, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:contactus@ageukskc.org.uk\\\">contactus@ageukskc.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK South Kent Coast\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contactus@ageukskc.org.uk.\\\">contactus@ageukskc.org.uk</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:contactus@ageuknorthwestkent.org.uk>contactus@ageuknorthwestkent.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>North Muskham Community Support\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:northmuskham@helpmystreet.org.\\\">northmuskham@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -9, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:contactus@ageuknorthwestkent.org.uk>contactus@ageuknorthwestkent.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK North West Kent\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contactus@ageuknorthwestkent.org.uk\\\">contactus@ageuknorthwestkent.org.uk</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -8, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Balderton Community Support\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:baldertoncs@helpmystreet.org\\\">baldertoncs@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -7, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:volunteers@ageukwirral.org.uk>volunteers@ageukwirral.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK Wirral\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:ruddington@helpmystreet.org\\\">ruddington@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -6, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Ruddington Community Response Team\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:ruddington@helpmystreet.org\\\">ruddington@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -5, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Tankersley & Pilley Community Helpers\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:tankersley@helpmystreet.org\\\">tankersley@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -4, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Healthy London Partnership\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -3, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK Lincoln & South Lincolnshire\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -2, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>For the Love of Scrubs\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -1, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>HelpMyStreet has partnered with organisations across the country to help make volunteering easier. To find out who we’re working with go to <a href=\\\"www.helpmystreet.org\\\">www.helpmystreet.org</a> and search our interactive map.</p><p>Most requests will need you to verify your ID before you start helping -  this is to make things as safe as possible for everyone using our site.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[,]
                {
                    { -31, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID and ensure you consent to our volunteer agreement – this is to make things as safe as possible for you and the people we help.</p><p>Please read the public documents found on our website (<a href=\\\"https://www.thetorpedos.org/publicdocuments\\\">here</a>) and drop us an email at <a href=\\\"mailto:info@thetorpedos.org\\\">info@thetorpedos.org</a> to confirm you’ve read and agree to our policies and volunteer agreement.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Southwell Torpedos\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@thetorpedos.org\\\">info@thetorpedos.org</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"true\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -30, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -29, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -28, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -27, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -25, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Mansfield CVS</p>\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -21, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -19, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -18, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -16, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -15, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"False\"}]" },
                    { -14, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -31, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -30, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -29, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -28, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -27, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -25, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -21, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -19, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -18, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -16, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -15, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -14, (byte)15 });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -24, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -22, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -20, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -17, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -13, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -12, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -11, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at northmuskham@helpmystreet.org<p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -9, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -8, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at baldertoncs@helpmystreet.org</p><p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -7, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -6, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -5, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"<p>Questions? Email us at tankersley@helpmystreet.org</p><p>P.S.Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about.Complete our Request Help form and let us know what they need.</p>\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -4, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -3, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -2, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"1\"},{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -1, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"HeaderRequired\",\"Value\":\"0\"},{\"Key\":\"GroupContent\",\"Value\":\"<p>If you haven’t done it already, you may like to complete your online ID verification now. We’ve made it as quick and easy as possible with the help of our partner, Yoti. Click here to launch your profile and get verified.</p><p>Most requests on our platform require ID verification to give people in need of help the confidence you are who you say you are. Some of our partner organisations may also require additional checks, if this is the case we’ll let you know when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.\"}]");
        }
    }
}
