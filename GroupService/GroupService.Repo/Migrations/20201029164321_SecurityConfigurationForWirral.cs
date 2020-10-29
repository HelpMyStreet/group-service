using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class SecurityConfigurationForWirral : Migration
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

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SecurityConfiguration",
                columns: new[] { "GroupID", "AllowAutonomousJoinersAndLeavers" },
                values: new object[] { -7, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SecurityConfiguration",
                keyColumn: "GroupID",
                keyValue: -7);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified.
Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified.
Volunteer admins cannot edit this credential.");
        }
    }
}
