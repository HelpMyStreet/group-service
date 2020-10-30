using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AdditionalLineBreaks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

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
                keyValues: new object[] { -7, 2 },
                column: "WhatIsThis",
                value: @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.
Volunteer admins cannot edit this credential.");

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
                keyValues: new object[] { -7, 2 },
                column: "WhatIsThis",
                value: @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.
Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.
Volunteer admins cannot edit this credential.");
        }
    }
}
