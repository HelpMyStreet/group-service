using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddSouthwell_GroupCredential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -31, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, please email mailto:jacky.huson@btinternet.com to request a manual ID check. You will also need to join our group from our <a href=\"http://www.helpmystreet.org/southwell\">HelpMyStreet landing page</a> if you haven’t already.", "", "Manual ID Verification", @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -31, 7, (byte)5, (byte)2, 3, "In order to reassure the individuals we support please read and consent to our volunteer agreement found <a href=\"https://www.thetorpedos.org/publicdocuments\">here</a>. If you consent email mailto:info@thetorpedos.org and we will update your profile.", "", "Volunteer Agreement", "Use this credential to certify that a volunteer has accepted the Southwell Torpedos Volunteer Agreement. Volunteer admins should follow internal processes for manually verifying this credential." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, 7 });
        }
    }
}
