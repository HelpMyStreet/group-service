using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddCardiffGroupStep4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[,]
                {
                    { -23, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -23, 1, (byte)1, (byte)2, 2, "Email our volunteer recruiter at helen.prior@ageconnectscardiff.org.uk to request a manual ID check.", "", "Manual ID Verification", @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

                Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -23, 5, (byte)4, (byte)2, 3, "Please complete this [form](/forms/ageconnect/cardiff/referencesform.docx) form and return it by email to helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.", "", "Reference 1", "Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference." },
                    { -23, 6, (byte)4, (byte)2, 4, "Please complete this [form](/forms/ageconnect/cardiff/referencesform.docx) form and return it by email to helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.", "", "Reference 2", "Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference." },
                    { -23, 2, (byte)2, (byte)2, 5, "Email our volunteer recruiter at helen.prior@ageconnectscardiff.org.uk to request a DBS check.", "", "DBS Check", @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

                Volunteer admins should follow internal processes for logging a DBS check." },
                    { -23, 4, (byte)3, (byte)2, 6, "Please contact our volunteer recruiter at helen.prior@ageconnectscardiff.org.uk to arrange your volunteer inductione", "", "Volunteer Induction", "Use this credential to record a completed volunteer induction. Volunteer admins should follow internal processes for completing and logging induction training." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, -1 });

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

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 6 });
        }
    }
}
