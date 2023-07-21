using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupService.Repo.Migrations
{
    public partial class RemoveGroupCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -40, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -40, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -40, 12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -39, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -39, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -39, 12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -38, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -38, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -38, 12 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -34, 10 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -33, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -33, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -33, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 8 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -32, 9 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 4 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -23, 5 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -13, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -11, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -10, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -10, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -9, 2 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -8, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -5, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, -1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -3, 1 });

            migrationBuilder.DeleteData(
                schema: "Group",
                table: "GroupCredential",
                keyColumns: new[] { "GroupID", "CredentialID" },
                keyValues: new object[] { -2, -1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Group",
                table: "GroupCredential",
                columns: new[] { "GroupID", "CredentialID", "CredentialTypeID", "CredentialVerifiedById", "DisplayOrder", "HowToAchieve", "HowToAchieve_CTA_Destination", "Name", "WhatIsThis" },
                values: new object[,]
                {
                    { -13, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -23, 1, (byte)1, (byte)2, 1, "Email our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to request a manual ID check.", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -23, 5, (byte)4, (byte)2, 2, "Please complete this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx) with details of your **two** referees. If it’s been more than two weeks and you haven’t heard anything, please get in touch.", "", "References", "Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference." },
                    { -23, 2, (byte)2, (byte)2, 3, "This activity requires a DBS check, please complete and return this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-dbs-check-form.docx). If it’s been more than two weeks and you haven’t heard anything, please get in touch.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -23, 4, (byte)3, (byte)2, 4, "If you haven’t done so already, please book your space on one of our Core Induction Training sessions through <a href=\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\" target=\"_blank\">Eventbrite</a>. If you’ve recently completed your induction please be aware that it may take a couple of days for the system to update.", "", "Volunteer Induction", "Use this credential to record a completed volunteer induction. Volunteer admins should follow internal processes for completing and logging induction training." },
                    { -32, 1, (byte)1, (byte)2, 1, "Please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net to request a manual ID check.", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -32, 8, (byte)3, (byte)2, 2, "Please email a copy of the required certificates to Gary Burroughs at mailto:g.burroughs@nhs.net, including your NMC, GMC or GPhC registration, mandated vaccination courses/programmes on immunisation, BLS and anaphylaxis training, and the COVID-19 vaccinator competency toolkit.", "", "Vaccinator Training", "Use this credential to certify that the user meets the essential criteria for a bank staff vaccinator. Once you have certified this credential users will be able to book onto shifts." },
                    { -32, 9, (byte)6, (byte)2, 3, "A member of the team will be in touch to confirm how you will be paid for any shifts you complete. If you haven’t heard from us within two weeks please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net.", "", "Bank Details", "Use this credential to confirm payment arrangements have been agreed." },
                    { -33, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, email us at mailto:enquiries@aukmm.org.uk to request a manual ID check.", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -33, 2, (byte)2, (byte)2, 3, "This activity requires a DBS check. Email us at mailto:enquiries@aukmm.org.uk to request or register a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -34, 1, (byte)1, (byte)2, 2, "If you are unable to confirm your ID using Yoti please make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can get in touch with more information about how you can request a manual ID check.", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -34, 5, (byte)4, (byte)2, 3, "We ask all our volunteers to provide a personal reference - this must be someone who is 18 or over, has known you for over a year and is not related to you. Please have a think about who this could be, and check that they are happy for you to share their contact details with us for the purpose of requesting a reference. Please also make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can contact you for their information.", "", "References", "Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference." },
                    { -34, 10, (byte)3, (byte)2, 4, "Safeguarding how-to text: ‘We ask all our volunteers to complete basic safeguarding training to keep you, and the people we help safe. Please make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can get in touch with more information about this short training session.", "", "Safeguarding training", "Use this credential to certify that the user has completed safeguarding training." },
                    { -34, 2, (byte)2, (byte)2, 5, "For some activities we need to our volunteers to be DBS checked. Please make sure you’re a member of our group by clicking ‘Join Our Group’ from our <a href=\"/boston\">landing page</a> whilst you’re logged in to HelpMyStreet so we can get in touch with more information about requesting or registering a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -38, 2, (byte)2, (byte)2, 2, "Here you can enter your own text to let volunteers know how to request and log a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -38, 12, (byte)2, (byte)2, 3, "The **Health, Safety and Infection Prevention and Control** for Volunteers training is a free, online learning module provided by Health Education England (HEE). <a href=\"https://portal.e-lfh.org.uk/Component/Details/556093\" target=\"_blank\">Launch the training module</a> and upload your completion certificate to continue. (You will need to log-in or sign up for a free account to access this training.)", "", "Health and Safety Training", "Use this credential to certify that the volunteer has completed the relevant training module. Volunteer admins should follow internal processes for manually verifying training." },
                    { -40, 2, (byte)2, (byte)2, 2, "Here you can enter your own text to let volunteers know how to request and log a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -40, 12, (byte)2, (byte)2, 3, "The **Health, Safety and Infection Prevention and Control** for Volunteers training is a free, online learning module provided by Health Education England (HEE). <a href=\"https://portal.e-lfh.org.uk/Component/Details/556093\" target=\"_blank\">Launch the training module</a> and upload your completion certificate to continue. (You will need to log-in or sign up for a free account to access this training.)", "", "Health and Safety Training", "Use this credential to certify that the volunteer has completed the relevant training module. Volunteer admins should follow internal processes for manually verifying training." },
                    { -13, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, email Age UK Faversham and Sittingbourne to find out how they can check your ID at mailto:volunteering@ageukfaversham.org.uk", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -39, 2, (byte)2, (byte)2, 2, "Here you can enter your own text to let volunteers know how to request and log a DBS check.", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -13, 2, (byte)2, (byte)2, 3, "Email Age UK Faversham and Sittingbourne to request or register your DBS check at mailto:volunteering@ageukfaversham.org.uk", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -11, 2, (byte)2, (byte)2, 3, "Email Age UK South Kent Coast to request or register your DBS check at mailto:volunteering@ageukskc.org.uk", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -11, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -10, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -9, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -8, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -5, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -3, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -2, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -33, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -34, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -38, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -40, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -39, -1, (byte)1, (byte)1, 1, "Complete online", "/account?next=verify", "Yoti ID Verification", "Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential." },
                    { -3, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, email Age UK Lincoln & South Lincolnshire to find out how they can check your ID at mailto:volunteering@ageuklsl.org.uk", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -8, 1, (byte)1, (byte)2, 2, "Unfortunately manual ID checks are not available right now, please use Yoti to verify you identity and start volunteering.", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -10, 1, (byte)1, (byte)2, 2, "Please contact North Muskham Community Support to find out more about our manual ID check by emailing mailto:northmuskham@helpmystreet.org", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -9, 2, (byte)2, (byte)2, 3, "Email Age UK North West Kent to request or register your DBS check at mailto:contactus@ageuknorthwestkent.org.uk", "", "DBS Check", "Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check." },
                    { -9, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, email Age UK North West Kent to find out how they can check your ID at mailto:contactus@ageuknorthwestkent.org.uk", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -11, 1, (byte)1, (byte)2, 2, "If you’re unable to verify with Yoti, email Age UK South Kent Coast to find out how they can check your ID at mailto:volunteering@ageukskc.org.uk", "", "Manual ID Verification", "Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity." },
                    { -39, 12, (byte)2, (byte)2, 3, "The **Health, Safety and Infection Prevention and Control** for Volunteers training is a free, online learning module provided by Health Education England (HEE). <a href=\"https://portal.e-lfh.org.uk/Component/Details/556093\" target=\"_blank\">Launch the training module</a> and upload your completion certificate to continue. (You will need to log-in or sign up for a free account to access this training.)", "", "Health and Safety Training", "Use this credential to certify that the volunteer has completed the relevant training module. Volunteer admins should follow internal processes for manually verifying training." }
                });
        }
    }
}
