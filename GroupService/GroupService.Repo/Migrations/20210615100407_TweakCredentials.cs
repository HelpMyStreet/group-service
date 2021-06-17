using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class TweakCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 8 },
                columns: new[] { "HowToAchieve", "WhatIsThis" },
                values: new object[] { " Please email a copy of the required certificates to Gary Burroughs at mailto:g.burroughs@nhs.net, including your NMC, GMC or GPhC registration, mandated vaccination courses/programmes on immunisation, BLS and anaphylaxis training, and the COVID-19 vaccinator competency toolkit.", "Use this credential to certify that the user meets the essential criteria for a bank staff vaccinator. Once you have certified this credential users will be able to book onto shifts." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -24, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -24, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 },
                column: "WhatIsThis",
                value: "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, 2 },
                column: "WhatIsThis",
                value: "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, 2 },
                column: "WhatIsThis",
                value: "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, 2 },
                column: "WhatIsThis",
                value: "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -10, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -10, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, 2 },
                column: "WhatIsThis",
                value: "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -7, 2 },
                column: "WhatIsThis",
                value: "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -6, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -4, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, 1 },
                column: "WhatIsThis",
                value: "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -1, -1 },
                column: "WhatIsThis",
                value: "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)56,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":56,\"ActivityDetails\":\"This is a paid role. Registered vaccinators are required for the local COVID-19 vaccination site at Ruston Sports and Social Club, Lincoln. Patients from all five APEX PCN member practices attend the site which has a current footfall in excess of 1301 patients per day. We run two four - hour shifts per day. Vaccinators are welcome to book onto a morning and an afternoon shift on the same day. Before you first shift you will be offered a full induction supported by the centre manager, current vaccinators and advanced practitioners.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Accept the shift\",\"Detail\":\"To book onto a shift simply click the green button below. We run two shifts per day and welcome staff wishing to book onto both shifts. You will find all our open shifts in 'Open Shifts'.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You'll receive a reminder email the day before your shift. Once you've completed a shift it will be marked as complete automatically, but you can still view a completed shift by selecting shifts with the status 'Done' in 'My Shifts'.\"}],\"Close\":\"If for any reason you can't complete a shift please let us know as soon as possible by clicking “Can’t Do” on the accepted request. On rare occasions we may need to cancel a shift at short notice, where this is the case we will update you by email and endeavour to contact you using the details provided in your profile.\"}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 8 },
                columns: new[] { "HowToAchieve", "WhatIsThis" },
                values: new object[] { " Please email a copy of the required certificates to Gary Burroughs at mailto:g.burroughs@nhs.net.Including your NMC, GMC or GPhC registration, mandated vaccination courses/programmes onImmunisation, BLS and anaphylaxis training, and the COVID-19 vaccinator competency toolkit.", @"Use this credential to certify that the user meets the essential criteria for a bank staff vaccinator. 

Once you have certified this credential users will be able to book onto shifts." });

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -31, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -24, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -24, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 },
                column: "WhatIsThis",
                value: @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -22, 2 },
                column: "WhatIsThis",
                value: @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, 2 },
                column: "WhatIsThis",
                value: @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, 2 },
                column: "WhatIsThis",
                value: @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -10, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -10, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, 2 },
                column: "WhatIsThis",
                value: @"Use this credential to record a completed DBS (Disclosure and Barring Service) check.

Volunteer admins should follow internal processes for logging a DBS check.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, -1 },
                column: "WhatIsThis",
                value: @"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.

Volunteer admins cannot edit this credential.");

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

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

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

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
                keyValues: new object[] { -3, 1 },
                column: "WhatIsThis",
                value: @"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. 

Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.");

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

            migrationBuilder.UpdateData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)56,
                column: "Instructions",
                value: "{\"SupportActivityInstructions\":56,\"ActivityDetails\":\"This is a paid role. Registered vaccinators are required for the local COVID-19 vaccination site at Ruston Sports and Social Club, Lincoln. Patients from all five APEX PCN member practices attend the site which has a current footfall in excess of 1301 patients per day. We run two four - hour shifts per day. Vaccinators are welcome to book onto a morning and an afternoon shift on the same day. Before you first shift you will be offered a full induction supported by the centre manager, current vaccinators and advanced practitioners.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Accept the shift\",\"Detail\":\"To book onto a shift simply click the green button below. We run two shifts per day and welcome staff wishing to book onto both shifts. You will find all our open shifts in 'Open Shifts'.\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You'll receive a reminder email the day before your shift. Once you've completed a shift it will be marked as complete automatically, but you can still view a completed shift by selecting shifts with the status 'Done' in 'My Shifts'.\"}],\"Close\":\"If for any reason you can't complete a shift please let us know as soon as possible by clicking “Can’t Do” on the accepted request. On rare occasions we may need to cancela shift at short notice, where this is the case we will update you by email and endeavour to contact you using the details provided in your profile.\"}");
        }
    }
}
