using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddApexBankStaff_GroupCredentials2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[,]
                {
                    { -32, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -32, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net to request a manual ID check.", "", "Manual ID Verification", @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

                Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -32, 8, (byte)3, (byte)2, 3, " Please email a copy of the required certificates toGary Burroughs at mailto:g.burroughs@nhs.net.Including your NMC, GMC or GPhC registration,mandated vaccination courses/programmes onImmunisation, BLS and anaphylaxis training, and theCOVID-19 vaccinator competency toolkit.", "", "Vaccinator Training", @"Use this credential to certify that the user meets the essential criteria for a bank staff vaccinator. 

                Once you have certified this credential users will be able to book onto shifts." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 8 });
        }
    }
}
