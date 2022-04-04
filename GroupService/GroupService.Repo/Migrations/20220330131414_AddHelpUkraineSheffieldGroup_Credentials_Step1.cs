using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddHelpUkraineSheffieldGroup_Credentials_Step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -36, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -36, -1 });
        }
    }
}
