using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddBostonGNSGroupGroupCredential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HowToAchieve",
                schema: "Group",
                table: "GroupCredential",
                unicode: false,
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)",
                oldUnicode: false,
                oldMaxLength: 400);

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[,]
                {
                    { -34, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -34, 1, (byte)1, (byte)2, 2, "If you are unable to confirm your ID using Yoti please make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can get in touch with more information about how you can request a manual ID check.", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -34, 5, (byte)4, (byte)2, 3, "We ask all our volunteers to provide a personal reference - this must be someone who is 18 or over, has known you for over a year and is not related to you. Please have a think about who this could be, and check that they are happy for you to share their contact details with us for the purpose of requesting a reference. Please also make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can contact you for their information.", "", "References", "Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference." },
                    { -34, 10, (byte)3, (byte)2, 4, "Safeguarding how-to text: ‘We ask all our volunteers to complete basic safeguarding training to keep you, and the people we help safe. Please make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can get in touch with more information about this short training session.", "", "Safeguarding training", "Use this credential to certify that the user has completed safeguarding training." },
                    { -34, 2, (byte)2, (byte)2, 5, "For some activities we need to our volunteers to be DBS checked. Please make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can get in touch with more information about requesting or registering a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 10 });

            migrationBuilder.AlterColumn<string>(
                name: "HowToAchieve",
                schema: "Group",
                table: "GroupCredential",
                type: "varchar(400)",
                unicode: false,
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1000);
        }
    }
}
