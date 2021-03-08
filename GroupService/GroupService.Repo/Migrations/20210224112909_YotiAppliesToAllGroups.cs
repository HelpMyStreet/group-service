using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class YotiAppliesToAllGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[,]
                {
                    { -22, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -21, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -20, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -19, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -18, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -17, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -16, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -15, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -14, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." },
                    { -12, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

                Volunteer admins cannot edit this credential." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -21, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -20, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -19, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -18, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -17, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -16, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -15, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -14, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -12, -1 });
        }
    }
}
