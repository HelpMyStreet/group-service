using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddBankDetailsForCardiffStep1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Credential",
                columns: new[] { "ID", "Name" },
                values: new object[] { 9, "Bank Details" });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 },
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 8 },
                columns: new[] { "DisplayOrder", "HowToAchieve" },
                values: new object[] { 2, "Please email a copy of the required certificates to Gary Burroughs at mailto:g.burroughs@nhs.net, including your NMC, GMC or GPhC registration, mandated vaccination courses/programmes on immunisation, BLS and anaphylaxis training, and the COVID-19 vaccinator competency toolkit." });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "CredentialTypes",
                columns: new[] { "ID", "Name" },
                values: new object[] { 6, "BankDetails" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -32, 9, (byte)6, (byte)2, 3, "A member of the team will be in touch to confirm how you will be paid for any shifts you complete. If you haven’t heard from us within two weeks please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net.", "", "Bank Details", "Use this credential to confirm payment arrangements have been agreed." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 9 });

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "CredentialTypes",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Credential",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 },
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 8 },
                columns: new[] { "DisplayOrder", "HowToAchieve" },
                values: new object[] { 3, " Please email a copy of the required certificates to Gary Burroughs at mailto:g.burroughs@nhs.net, including your NMC, GMC or GPhC registration, mandated vaccination courses/programmes on immunisation, BLS and anaphylaxis training, and the COVID-19 vaccinator competency toolkit." });
        }
    }
}
