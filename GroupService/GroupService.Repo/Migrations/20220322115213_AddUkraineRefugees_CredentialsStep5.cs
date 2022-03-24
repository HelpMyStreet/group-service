using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddUkraineRefugees_CredentialsStep5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[] { -35, 1, (byte)2, (byte)2, 2, "Hosts must be approved before they can be matched to a request for accommodation. A member of our team will be in touch as soon as possible to start the process.", "", "Approved Host", "Use this credential to certify that a host has completed all of the necessary checks and is approved for hosting. Volunteer admins should follow internal processes for manually verifying an approved host." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -35, 1 });            
        }
    }
}
