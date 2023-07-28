using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveGroupEmailConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -40, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -39, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -38, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -37, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -36, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -34, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -33, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -32, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -20, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -17, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -14, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -13, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -12, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -11, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -10, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -9, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -8, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -5, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -3, (byte)15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -2, (byte)15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                columns: new[] { "GroupID", "CommunicationJobTypeID", "Configuration" },
                values: new object[,]
                {
                    { -2, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>For the Love of Scrubs\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -40, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p><p>For some roles, we may also require additional checks or training – we will let you know if any additional checks are needed before you accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contact@helpmystreet.org\\\">contact@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -39, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p><p>For some roles, we may also require additional checks or training – we will let you know if any additional checks are needed before you accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contact@helpmystreet.org\\\">contact@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -38, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p><p>For some roles, we may also require additional checks or training – we will let you know if any additional checks are needed before you accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contact@helpmystreet.org\\\">contact@helpmystreet.org</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -34, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>For most volunteering opportunities we offer we will need to verify your ID and complete some basic training before you can start helping – this is to make things as safe as possible for you and the people we help. You’ll find all the details of the checks needed when you click to accept a request.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>The Boston Community\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"false\"}]" },
                    { -33, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href='mailto:enquiries@aukmm.org.uk'>enquiries@aukmm.org.uk</a></p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>The Age UK Mid Mersey team\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href='mailto:enquiries@aukmm.org.uk'>enquiries@aukmm.org.uk</a>\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -32, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>We are using HelpMyStreet to coordinate our bank shifts. To book onto a shift you will need to have met the essential criteria for the role. If there is something missing from your profile we will let you know when you try to book onto a shift. Please be aware that shifts may be added or cancelled at short notice due to unexpected demand. </p><p>HelpMyStreet was originally built for volunteering so please be aware that there may be some unpaid volunteer roles advertised on the platform. All of our roles will specify where they are paid positions.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Kind regards,</p><p>Gary Burroughs - PCN Manager\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -23, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to do a couple of checks. We need two references from people who have known you for more than a year, they must also be over 18 and not related to you. If you would like to undertake any roles which involve face-to-face contact with a client we will also need a DBS check. Please download our Volunteer Application Form from the <a href=\\\"{{BaseUrl}}/ageconnects-cardiff#resources\\\">useful links</a> section of our landing page to submit your details.<p><p>All of our volunteers also need to complete an induction. This is a short web-session which gives us a chance to run through our policies and procedures - it also gives you a chance to meet other volunteers and ask any questions. If you haven’t done so already, you can book your space for Core Induction Training on Eventbrite by clicking <a href=\\\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\\\">here</a>.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:helen.prior@ageconnectscardiff.org.uk\\\">helen.prior@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -20, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -36, (byte)15, "[{\"Key\":\"DontSendEmail\",\"Value\":\"true\"}]" },
                    { -17, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -13, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:volunteering@ageukfaversham.org.uk\\\">volunteering@ageukfaversham.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK Faversham & Sittingbourne\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:volunteering@ageukfaversham.org.uk.\\\">volunteering@ageukfaversham.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -12, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>The Lincolnshire Volunteers Team\"},{\"Key\":\"GroupPS\",\"Value\":\"\"}]" },
                    { -11, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:contactus@ageukskc.org.uk\\\">contactus@ageukskc.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK South Kent Coast\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contactus@ageukskc.org.uk.\\\">contactus@ageukskc.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -10, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>North Muskham Community Support\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:northmuskham@helpmystreet.org.\\\">northmuskham@helpmystreet.org</a>.\"}]" },
                    { -9, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:contactus@ageuknorthwestkent.org.uk\\\">contactus@ageuknorthwestkent.org.uk</a>.</p><p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age UK North West Kent\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:contactus@ageuknorthwestkent.org.uk\\\">contactus@ageuknorthwestkent.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -8, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Balderton Community Support\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:baldertoncs@helpmystreet.org\\\">baldertoncs@helpmystreet.org</a>.\"}]" },
                    { -5, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Tankersley & Pilley Community Helpers\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:tankersley@helpmystreet.org\\\">tankersley@helpmystreet.org</a>.\"}]" },
                    { -3, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Pip\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:volunteering@ageuklsl.org.uk\\\">volunteering@ageuklsl.org.uk</a>.\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]" },
                    { -14, (byte)15, "[{\"Key\":\"GroupContent\",\"Value\":\"\"},{\"Key\":\"GroupSignature\",\"Value\":\"\"},{\"Key\":\"GroupPS\",\"Value\":\"\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"True\"}]" },
                    { -37, (byte)15, "[{\"Key\":\"DontSendEmail\",\"Value\":\"true\"}]" }
                });
        }
    }
}
