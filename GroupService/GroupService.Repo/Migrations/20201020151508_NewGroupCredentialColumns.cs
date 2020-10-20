using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class NewGroupCredentialColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HowToAchieve_CTA_Destination",
                schema: "Group",
                table: "GroupCredential",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WhatIsThis",
                schema: "Group",
                table: "GroupCredential",
                unicode: false,
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "Group",
                table: "ActivityCredentialSet",
                columns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                values: new object[,]
                {
                    { -7, 15, 7 },
                    { -7, 16, 71 },
                    { -7, 15, 71 },
                    { -1, 16, 1 },
                    { -2, 16, 2 },
                    { -2, 15, 2 },
                    { -3, 16, 3 },
                    { -3, 15, 3 },
                    { -1, 15, 1 },
                    { -4, 15, 4 },
                    { -5, 16, 5 },
                    { -5, 15, 5 },
                    { -6, 16, 6 },
                    { -6, 15, 6 },
                    { -7, 16, 7 },
                    { -4, 16, 4 }
                });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, -1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Complete online", "/account?action=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified. As an admin you can’t edit this." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Email the AgeUK Wirral team", "", "Manual ID Verification", "" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 2 },
                columns: new[] { "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "WhatIsThis" },
                values: new object[] { 3, "Email the AgeUK Wirral team", "", "" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Complete online", "/account?action=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified. As an admin you can’t edit this." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Complete online", "/account?action=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified. As an admin you can’t edit this." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Complete online", "/account?action=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified. As an admin you can’t edit this." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Complete online", "/account?action=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified. As an admin you can’t edit this." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Complete online", "/account?action=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified. As an admin you can’t edit this." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 },
                columns: new[] { "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { "Complete online", "/account?action=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instruction in their profile to get verified. As an admin you can’t edit this." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -7, 15, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -7, 15, 71 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -7, 16, 7 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -7, 16, 71 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -6, 15, 6 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -6, 16, 6 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -5, 15, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -5, 16, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -4, 15, 4 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -4, 16, 4 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -3, 15, 3 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -3, 16, 3 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -2, 15, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -2, 16, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -1, 15, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "ActivityCredentialSet",
                keyColumns: new[] { "GroupID", "ActivityID", "CredentialSetID" },
                keyValues: new object[] { -1, 16, 1 });

            migrationBuilder.DropColumn(
                name: "HowToAchieve_CTA_Destination",
                schema: "Group",
                table: "GroupCredential");

            migrationBuilder.DropColumn(
                name: "WhatIsThis",
                schema: "Group",
                table: "GroupCredential");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, -1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Yoti App", "Yoti Identity Verification" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Email Someone", "Manually Verified" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 2 },
                columns: new[] { "DisplayOrder", "HowToAchieve" },
                values: new object[] { 2, "Email Someone" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Yoti App", "Yoti Identity Verification" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Yoti App", "Yoti Identity Verification" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Yoti App", "Yoti Identity Verification" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Yoti App", "Yoti Identity Verification" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Yoti App", "Yoti Identity Verification" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 },
                columns: new[] { "HowToAchieve", "Name" },
                values: new object[] { "Yoti App", "Yoti Identity Verification" });
        }
    }
}
