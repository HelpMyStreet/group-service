using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class AddMansfieldCVSGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "HomepageEnabled", "ParentGroupId", "ShiftsEnabled", "TasksEnabled" },
                values: new object[] { -25, "mansfield-cvs", "Mansfield CVS", false, null, true, false });

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

            migrationBuilder.InsertData(
                schema: "Group",
                table: "SupportActivityInstructions",
                columns: new[] { "SupportActivityInstructionsID", "Instructions" },
                values: new object[] { (short)54, "{\"SupportActivityInstructions\":54,\"ActivityDetails\":\"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the shift or by clicking “View more info” on accepted shifts in the “My Shifts” tab.\",\"Intro\":null,\"Steps\":[{\"Heading\":\"Check the request details\",\"Detail\":\"Please read the [role description and useful information](/pdf/mansfield-cvs/nottinghamshire-vaccine-support-information.pdf) attachment for full details of the role. Volunteers may also be asked to participate in regular lateral flow testing, you can find more information [here](/pdf/mansfield-cvs/lateral-flow-testing-for-vaccination-support-volunteers.pdf).\"},{\"Heading\":\"Attending your shift\",\"Detail\":\"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather (e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the details in the “My Shifts” tab but searching for shifts with the status “Done”.\"}],\"Close\":\"If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer.\"}" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -11, "MansfieldWickesSite" },
                    { -12, "GamstonCommunityHall" },
                    { -13, "RichardHerrodCentre" },
                    { -14, "KingsMeadowCampus" },
                    { -15, "ForestRecreationGround" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 14, "MansfieldCVS" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                columns: new[] { "ID", "Name" },
                values: new object[] { 24, "Mansfield_CVS" });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 54, "MansfieldCVS_VaccineSupport" });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                columns: new[] { "RequestHelpFormVariantID", "SupportActivityID", "DisplayOrder", "IsPreSelected", "Label" },
                values: new object[] { (byte)14, 24, (byte)1, true, "Volunteering to support the COVID-19 vaccination programme (e.g. support staff for local vaccination centres)" });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "Group",
                columns: new[] { "Id", "GroupKey", "GroupName", "HomepageEnabled", "ParentGroupId", "ShiftsEnabled", "TasksEnabled" },
                values: new object[,]
                {
                    { -26, "mansfield-wickes", "Mansfield (Wickes Site)", false, -25, true, false },
                    { -27, "gamston-community-hall", "Gamston Community Hall", false, -25, true, false },
                    { -28, "richard-herrod-centre", "Richard Herrod Centre", false, -25, true, false },
                    { -29, "kings-meadow-campus", "King's Meadow Campus", false, -25, true, false },
                    { -30, "forest-recreation-ground", "Forest Recreation Ground", false, -25, true, false }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[] { -25, 24, (short)54 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[] { -25, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "", "NG18 1QA" });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RegistrationJourney",
                columns: new[] { "GroupID", "Source", "RegistrationFormVariant" },
                values: new object[] { -25, "", (byte)10 });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[] { -25, "a", true, (byte)18, true, false, false, (byte)4 });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupLocation",
                columns: new[] { "GroupID", "LocationID" },
                values: new object[,]
                {
                    { -26, -11 },
                    { -30, -15 },
                    { -27, -12 },
                    { -29, -14 },
                    { -28, -13 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                columns: new[] { "GroupID", "SupportActivityID", "SupportActivityInstructionsID" },
                values: new object[,]
                {
                    { -30, 24, (short)54 },
                    { -29, 24, (short)54 },
                    { -28, 24, (short)54 },
                    { -27, 24, (short)54 },
                    { -26, 24, (short)54 }
                });

            migrationBuilder.InsertData(
                schema: "Group",
                table: "RequestorDetails",
                columns: new[] { "GroupId", "AddressLine1", "AddressLine2", "AddressLine3", "EmailAddress", "FirstName", "LastName", "Locality", "MobilePhone", "OtherPhone", "Postcode" },
                values: new object[,]
                {
                    { -28, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "", "NG18 1QA" },
                    { -26, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "", "NG18 1QA" },
                    { -29, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "", "NG18 1QA" },
                    { -27, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "", "NG18 1QA" },
                    { -30, "Mansfield Community House", "36 Wood Street", "Mansfield", "chorsman@scintillaspark.co.uk", "Caroline", "Horsman", "Nottinghamshire", null, "", "NG18 1QA" }
                });

            migrationBuilder.InsertData(
                schema: "Website",
                table: "RequestHelpJourney",
                columns: new[] { "GroupID", "Source", "AccessRestrictedByRole", "RequestHelpFormVariant", "RequestorDefinedByGroup", "RequestsRequireApproval", "SuppressRecipientPersonalDetails", "TargetGroups" },
                values: new object[,]
                {
                    { -27, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -30, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -28, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -29, "a", true, (byte)24, true, false, false, (byte)4 },
                    { -26, "a", true, (byte)24, true, false, false, (byte)4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -30, -15 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -29, -14 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -28, -13 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -27, -12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupLocation",
                keyColumns: new[] { "GroupID", "LocationID" },
                keyValues: new object[] { -26, -11 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -30, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -29, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -28, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -27, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -26, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupSupportActivityInstructions",
                keyColumns: new[] { "GroupID", "SupportActivityID" },
                keyValues: new object[] { -25, 24 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -30);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -29);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -28);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -27);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -26);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "RequestorDetails",
                keyColumn: "GroupId",
                keyValue: -25);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -15);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -14);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -13);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -12);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "Location",
                keyColumn: "ID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RegistrationFormVariant",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "RequestHelpFormVariant",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Lookup",
                table: "SupportActivityInstructions",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationFormSupportActivity",
                keyColumns: new[] { "RequestHelpFormVariantID", "SupportActivityID" },
                keyValues: new object[] { (byte)14, 24 });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RegistrationJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -25, "" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -30, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -29, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -28, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -27, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -26, "a" });

            migrationBuilder.DeleteData(
                schema: "Website",
                table: "RequestHelpJourney",
                keyColumns: new[] { "GroupID", "Source" },
                keyValues: new object[] { -25, "a" });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "SupportActivityInstructions",
                keyColumn: "SupportActivityInstructionsID",
                keyValue: (short)54);

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "Group",
                keyColumn: "Id",
                keyValue: -25);

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
        }
    }
}
