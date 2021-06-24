using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AmendGroupWelcomeEmail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID and collect two references – this is to make things as safe as possible for you and the people we help. Your referees need to have known you for at least year, be over 18 and not related to you. Download our references form <a href=\\\"{{BaseUrl}}/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx\\\">here</a> for more details.</p><p>We also ask all volunteers to complete our volunteer induction. This is a short web-session which gives us a chance to run through our policies and procedures. It also gives you a chance to meet other volunteers and ask any questions. We will contact you with the next available date when we receive your references. We may also require a DBS check; we’ll be in touch with more information about this if required.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@ageconnectscardiff.org.uk\\\">info@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupEmailConfiguration",
                keyColumns: new[] { "GroupID", "CommunicationJobTypeID" },
                keyValues: new object[] { -23, (byte)15 },
                column: "Configuration",
                value: "[{\"Key\":\"GroupContent\",\"Value\":\"<p>Before you start volunteering with us we need to verify your ID and collect two references – this is to make things as safe as possible for you and the people we help. Your referees need to have known you for at least year, be over 18 and not related to you. Download our references form <a href=\\\"{BaseUrl}/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx\\\">here</a> for more details.</p><p>We also ask all volunteers to complete our volunteer induction. This is a short web-session which gives us a chance to run through our policies and procedures. It also gives you a chance to meet other volunteers and ask any questions. We will contact you with the next available date when we receive your references. We may also require a DBS check; we’ll be in touch with more information about this if required.</p>\"},{\"Key\":\"GroupSignature\",\"Value\":\"Best wishes,</p><p>Age Connects Cardiff & the Vale\"},{\"Key\":\"GroupPS\",\"Value\":\"Questions? Drop us an email at <a href=\\\"mailto:info@ageconnectscardiff.org.uk\\\">info@ageconnectscardiff.org.uk</a>.\"},{\"Key\":\"ShowGroupRequestFormLink\",\"Value\":\"false\"},{\"Key\":\"ShowGroupLogo\",\"Value\":\"true\"}]");
        }
    }
}
