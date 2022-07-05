using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddNHSVRDemoSubgroups_step3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[,]
                {
                    { -40, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -39, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -40, 2, (byte)2, (byte)2, 2, "Here you can enter your own text to let volunteers know how to request and log a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -40, 12, (byte)2, (byte)2, 3, "This is a free, online learning module provided by Health Education England (HEE) on the e-learning for healthcare platform. Launch the training module and upload your completion certificate  to continue. (You will need to log-in or sign up for a free account to access this training.)", "", "Health, Safety and Infection Prevention and Control", "Use this credential to certify that the volunteer has completed the relevant training module. Volunteer admins should follow internal processes for manually verifying training." },
                    { -39, 2, (byte)2, (byte)2, 2, "Here you can enter your own text to let volunteers know how to request and log a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -39, 12, (byte)2, (byte)2, 3, "This is a free, online learning module provided by Health Education England (HEE) on the e-learning for healthcare platform. Launch the training module and upload your completion certificate  to continue. (You will need to log-in or sign up for a free account to access this training.)", "", "Health, Safety and Infection Prevention and Control", "Use this credential to certify that the volunteer has completed the relevant training module. Volunteer admins should follow internal processes for manually verifying training." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -40, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -40, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -40, 12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -39, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -39, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -39, 12 });
        }
    }
}
