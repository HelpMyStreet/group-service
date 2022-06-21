using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveAgeConnectsGroup_Step6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[,]
                {
                    { -23, 1, (byte)1, (byte)2, 1, "Email our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to request a manual ID check.", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -23, 5, (byte)4, (byte)2, 2, "Please complete this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx) with details of your **two** referees. If it’s been more than two weeks and you haven’t heard anything, please get in touch.", "", "References", "Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference." },
                    { -23, 2, (byte)2, (byte)2, 3, "This activity requires a DBS check, please complete and return this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-dbs-check-form.docx). If it’s been more than two weeks and you haven’t heard anything, please get in touch.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -23, 4, (byte)3, (byte)2, 4, "If you haven’t done so already, please book your space on one of our Core Induction Training sessions through <a href=\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\" target=\"_blank\">Eventbrite</a>. If you’ve recently completed your induction please be aware that it may take a couple of days for the system to update.", "", "Volunteer Induction", "Use this credential to record a completed volunteer induction. Volunteer admins should follow internal processes for completing and logging induction training." }
                });
        }
    }
}
