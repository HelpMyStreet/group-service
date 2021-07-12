using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveCardiffGroupCredentialsForReferences2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -23, 6, (byte)4, (byte)2, 4, "Please complete this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx) and return it by email to mailto:helen.prior@ageconnectscardiff.org.uk. We need both references to complete your onboarding.", "", "Reference 2", "Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference." });
        }
    }
}
