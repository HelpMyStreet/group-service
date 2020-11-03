using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class MissingApostrophe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer's identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer's identity.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteers identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteers identity.");
        }
    }
}
