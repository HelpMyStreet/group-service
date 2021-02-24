using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddingSandboxCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -22, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, email your group admins to find out how they can check your ID", "", "Manual ID Verification", @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -22, 2, (byte)2, (byte)2, 3, "Email your group admins to request or register your DBS check", "", "DBS Check", @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

Volunteer admins should follow internal processes for logging a DBS check." });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -22, 3, (byte)3, (byte)2, 4, "Email your group admins to book onto the next course", "", "Befriender Training", "Use this credential to record that a volunteer has completed the Befriender traning course." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, 3 });
        }
    }
}
