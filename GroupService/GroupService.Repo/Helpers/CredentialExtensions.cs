using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class CredentialExtensions
    {
        private static List<Groups> GROUPS_USING_YOTI;
        private static List<Groups> GROUPS_USING_MANUAL_ID;

        // Credential Set IDs
        private static Dictionary<Groups, int> IDENTITY_CREDENTIAL_SETS;
        private static Dictionary<Groups, int> DBS_CREDENTIAL_SETS;
        private const int SANDBOX_BEFRIENDER_TRAINING_CREDENTIAL_SET = 142;
        private const int AGECONNECT_CARDIFF_TRAINING_CREDENTIAL_SET = 234;
        private const int AGECONNECT_CARDIFF_REFERENCES_CREDENTIAL_SET = 235;
        private const int SOUTHWELL_PROCEDURES_AND_POLICIES_CREDENTIAL_SET = 317;
        private const int APEXBANKSTAFF_VACCINATOR_TRAINING_CREDENTIAL_SET = 328;
        private const int APEXBANKSTAFF_BANK_DETAILS_CREDENTIAL_SET = 329;

        // Credential IDs
        private const int IDENTITY_VERIFIED_BY_YOTI = -1;
        private const int MANUALLY_VERIFIED = 1;
        private const int DBS_CHECK = 2;
        private const int SANDBOX_BEFRIENDER_TRAINING = 3;
        private const int VOLUNTEER_INDUCTION = 4;
        private const int REFERENCES = 5;
        private const int POLICIES_AND_PROCEDURES = 7;
        private const int VACCINATOR_TRAINING = 8;
        private const int BANK_DETAILS = 9;

        public static void InitialiseCredentialSets()
        {
            IDENTITY_CREDENTIAL_SETS = new Dictionary<Groups, int>
            {
                { Groups.Generic, 1 },
                { Groups.FTLOS, 2 },
                { Groups.AgeUKLSL, 3 },
                { Groups.Tankersley, 5 },
                { Groups.Ruddington, 6 },
                { Groups.AgeUKWirral, 7 },
                { Groups.AgeUKNottsBalderton, 8 },
                { Groups.AgeUKNorthWestKent, 9 },
                { Groups.AgeUKNottsNorthMuskham, 10 },
                { Groups.AgeUKSouthKentCoast, 11 },
                { Groups.AgeUKFavershamAndSittingbourne, 13 },
                { Groups.Sandbox, 14 },
                { Groups.AgeConnectsCardiff, 23 },
                { Groups.MeadowsCommunityHelpers, 24 },
                { Groups.Southwell, 31 },
                { Groups.ApexBankStaff, 32 },
                { Groups.AgeUKMidMersey, 33 },

            };
            DBS_CREDENTIAL_SETS = new Dictionary<Groups, int>
            {
                { Groups.AgeUKWirral, 71 },
                { Groups.AgeUKNorthWestKent, 91 },
                { Groups.AgeUKSouthKentCoast, 111 },
                { Groups.AgeUKFavershamAndSittingbourne, 131 },
                { Groups.Sandbox, 141 },
                { Groups.AgeConnectsCardiff, 231 },
                { Groups.AgeUKMidMersey, 331 }
            };

            GROUPS_USING_YOTI = new List<Groups> {
                Groups.MeadowsCommunityHelpers,
                Groups.Sandbox,
                Groups.AgeUKFavershamAndSittingbourne,
                Groups.AgeUKSouthKentCoast,
                Groups.AgeUKNottsNorthMuskham,
                Groups.AgeUKNorthWestKent,
                Groups.AgeUKNottsBalderton,
                Groups.AgeUKWirral,
                Groups.Ruddington,
                Groups.Tankersley,
                Groups.AgeUKLSL,
                Groups.FTLOS,
                Groups.Generic,
                Groups.Southwell,
                Groups.AgeUKMidMersey
            };

            GROUPS_USING_MANUAL_ID = new List<Groups>
            {
                Groups.AgeUKWirral,
                Groups.AgeUKLSL,
                Groups.AgeUKNottsBalderton,
                Groups.AgeUKNottsNorthMuskham,
                Groups.AgeUKNorthWestKent,
                Groups.AgeUKSouthKentCoast,
                Groups.AgeUKFavershamAndSittingbourne,
                Groups.Sandbox,
                Groups.AgeConnectsCardiff,
                Groups.MeadowsCommunityHelpers,
                Groups.Southwell,
                Groups.ApexBankStaff,
                Groups.AgeUKMidMersey
            };
        }

        public static void SetCredentials(this EntityTypeBuilder<Credential> entity)
        {
            entity.HasData(new Credential
            {
                Id = IDENTITY_VERIFIED_BY_YOTI,
                Name = "IdentityVerifiedByYoti"
            });

            entity.HasData(new Credential
            {
                Id = MANUALLY_VERIFIED,
                Name = "ManuallyVerified"
            });

            entity.HasData(new Credential
            {
                Id = DBS_CHECK,
                Name = "DBS Check"
            });

            entity.HasData(new Credential
            {
                Id = SANDBOX_BEFRIENDER_TRAINING,
                Name = "Sandbox - Befriender Training"
            });

            entity.HasData(new Credential
            {
                Id = VOLUNTEER_INDUCTION,
                Name = "Volunteer Induction"
            });

            entity.HasData(new Credential
            {
                Id = REFERENCES,
                Name = "References"
            });

            entity.HasData(new Credential
            {
                Id = POLICIES_AND_PROCEDURES,
                Name = "Policies & Procedures"
            });

            entity.HasData(new Credential
            {
                Id = VACCINATOR_TRAINING,
                Name = "Vaccinator Training"
            });

            entity.HasData(new Credential
            {
                Id = BANK_DETAILS,
                Name = "Bank Details"
            });
        }

        public static void SetGroupCredentials(this EntityTypeBuilder<GroupCredential> entity)
        {
            foreach (var group in GROUPS_USING_YOTI)
            {
                entity.HasData(new GroupCredential
                {
                    GroupId = (int)group,
                    CredentialId = IDENTITY_VERIFIED_BY_YOTI,
                    CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                    Name = "Yoti ID Verification",
                    HowToAchieve = "Complete online",
                    HowToAchieve_CTA_Destination = "/account?next=verify",
                    WhatIsThis = $"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified. Volunteer admins cannot edit this credential.",
                    DisplayOrder = 1,
                    CredentialVerifiedById = (byte)CredentialVerifiedBy.System
                });
            }

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKWirral,
                CredentialId = DBS_CHECK,
                CredentialTypeId = (int)CredentialTypes.ThirdPartyCheck,
                Name = "DBS Check",
                HowToAchieve = "Email Age UK Wirral to request or register your DBS check at mailto:volunteers@ageukwirral.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKWirral,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email Age UK Wirral to find out how they can check your ID at mailto:volunteers@ageukwirral.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKLSL,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email Age UK Lincoln & South Lincolnshire to find out how they can check your ID at mailto:volunteering@ageuklsl.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKNottsBalderton,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "Unfortunately manual ID checks are not available right now, please use Yoti to verify you identity and start volunteering.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKNottsNorthMuskham,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "Please contact North Muskham Community Support to find out more about our manual ID check by emailing mailto:northmuskham@helpmystreet.org",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                CredentialId = DBS_CHECK,
                CredentialTypeId = (int)CredentialTypes.ThirdPartyCheck,
                Name = "DBS Check",
                HowToAchieve = "Email Age UK North West Kent to request or register your DBS check at mailto:contactus@ageuknorthwestkent.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email Age UK North West Kent to find out how they can check your ID at mailto:contactus@ageuknorthwestkent.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                CredentialId = DBS_CHECK,
                CredentialTypeId = (int)CredentialTypes.ThirdPartyCheck,
                Name = "DBS Check",
                HowToAchieve = "Email Age UK South Kent Coast to request or register your DBS check at mailto:volunteering@ageukskc.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email Age UK South Kent Coast to find out how they can check your ID at mailto:volunteering@ageukskc.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                CredentialId = DBS_CHECK,
                CredentialTypeId = (int)CredentialTypes.ThirdPartyCheck,
                Name = "DBS Check",
                HowToAchieve = "Email Age UK Faversham and Sittingbourne to request or register your DBS check at mailto:volunteering@ageukfaversham.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email Age UK Faversham and Sittingbourne to find out how they can check your ID at mailto:volunteering@ageukfaversham.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.Sandbox,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email your group admins to find out how they can check your ID",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.Sandbox,
                CredentialId = DBS_CHECK,
                CredentialTypeId = (int)CredentialTypes.ThirdPartyCheck,
                Name = "DBS Check",
                HowToAchieve = "Email your group admins to request or register your DBS check",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.Sandbox,
                CredentialId = SANDBOX_BEFRIENDER_TRAINING,
                CredentialTypeId = (int)CredentialTypes.Training,
                Name = "Befriender Training",
                HowToAchieve = "Email your group admins to book onto the next course",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record that a volunteer has completed the Befriender traning course.",
                DisplayOrder = 4,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeConnectsCardiff,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "Email our volunteer recruiter at mailto:helen.prior@ageconnectscardiff.org.uk to request a manual ID check.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 1,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeConnectsCardiff,
                CredentialId = REFERENCES,
                CredentialTypeId = (int)CredentialTypes.References,
                Name = "References",
                HowToAchieve = $"Please complete this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx) with details of your **two** referees. " +
                $"If it’s been more than two weeks and you haven’t heard anything, please get in touch.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed reference. Volunteer admins should follow internal processes for logging a personal reference.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeConnectsCardiff,
                CredentialId = DBS_CHECK,
                CredentialTypeId = (int)CredentialTypes.ThirdPartyCheck,
                Name = "DBS Check",
                HowToAchieve = $"This activity requires a DBS check, please complete and return this [form](/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-dbs-check-form.docx). " +
                $"If it’s been more than two weeks and you haven’t heard anything, please get in touch.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeConnectsCardiff,
                CredentialId = VOLUNTEER_INDUCTION,
                CredentialTypeId = (int)CredentialTypes.Training,
                Name = "Volunteer Induction",
                HowToAchieve = $"If you haven’t done so already, please book your space on one of our Core Induction Training sessions through <a href=\"https://www.eventbrite.co.uk/o/age-connects-cardiff-amp-vale-32377866579\" target=\"_blank\">Eventbrite</a>. " +
                $"If you’ve recently completed your induction please be aware that it may take a couple of days for the system to update.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed volunteer induction. Volunteer admins should follow internal processes for completing and logging induction training.",
                DisplayOrder = 4,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.MeadowsCommunityHelpers,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "Email Sam Kelly on mailto:sam@bridgescommunitytrust.org.uk to arrange a manual ID check at The One Stop Shop.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.Southwell,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = $"If you’re unable to verify with Yoti, please email mailto:jacky.huson@btinternet.com to request a manual ID check. You will also need to join our group from our <a href=\"/southwell\">HelpMyStreet landing page</a> if you haven’t already.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.Southwell,
                CredentialId = POLICIES_AND_PROCEDURES,
                CredentialTypeId = (int)CredentialTypes.PolicyAgreement,
                Name = "Volunteer Agreement",
                HowToAchieve = $"In order to reassure the individuals we support please read and consent to our volunteer agreement found <a href=\"https://www.thetorpedos.org/publicdocuments\">here</a>. If you consent email mailto:info@thetorpedos.org and we will update your profile.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that a volunteer has accepted the Southwell Torpedos Volunteer Agreement. Volunteer admins should follow internal processes for manually verifying this credential.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });


            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.ApexBankStaff,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = $"Please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net to request a manual ID check.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 1,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.ApexBankStaff,
                CredentialId = VACCINATOR_TRAINING,
                CredentialTypeId = (int)CredentialTypes.Training,
                Name = "Vaccinator Training",
                HowToAchieve = $"Please email a copy of the required certificates to Gary Burroughs at mailto:g.burroughs@nhs.net, including your NMC, GMC or GPhC registration, mandated vaccination courses/programmes on immunisation, BLS and anaphylaxis training, and the COVID-19 vaccinator competency toolkit.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that the user meets the essential criteria for a bank staff vaccinator. Once you have certified this credential users will be able to book onto shifts.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.ApexBankStaff,
                CredentialId = BANK_DETAILS,
                CredentialTypeId = (int)CredentialTypes.BankDetails,
                Name = "Bank Details",
                HowToAchieve = $"A member of the team will be in touch to confirm how you will be paid for any shifts you complete. If you haven’t heard from us within two weeks please email Gary Burroughs, PCN Manager at mailto:g.burroughs@nhs.net.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to confirm payment arrangements have been agreed.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKMidMersey,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = $"If you’re unable to verify with Yoti, email us at mailto:enquiries@aukmm.org.uk to request a manual ID check.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKMidMersey,
                CredentialId = DBS_CHECK,
                CredentialTypeId = (int)CredentialTypes.ThirdPartyCheck,
                Name = "DBS Check",
                HowToAchieve = $"This activity requires a DBS check. Email us at mailto:enquiries@aukmm.org.uk to request or register a DBS check.",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check. Volunteer admins should follow internal processes for logging a DBS check.",
                DisplayOrder = 3,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });
        }

        public static void SetCredentialSet(this EntityTypeBuilder<CredentialSet> entity)
        {
            foreach (var group in GROUPS_USING_YOTI)
            {
                entity.HasData(new CredentialSet
                {
                    Id = IDENTITY_CREDENTIAL_SETS[group],
                    GroupId = (int)group,
                    CredentialId = IDENTITY_VERIFIED_BY_YOTI
                });
            }

            foreach (var dbsCredentialSet in DBS_CREDENTIAL_SETS)
            {
                entity.HasData(new CredentialSet
                {
                    Id = dbsCredentialSet.Value,
                    GroupId = (int)dbsCredentialSet.Key,
                    CredentialId = DBS_CHECK
                });
            }

            foreach (var group in GROUPS_USING_MANUAL_ID)
            {
                entity.HasData(new CredentialSet
                {
                    Id = IDENTITY_CREDENTIAL_SETS[group],
                    GroupId = (int)group,
                    CredentialId = MANUALLY_VERIFIED,
                });
            }

            entity.HasData(new CredentialSet
            {
                Id = SANDBOX_BEFRIENDER_TRAINING_CREDENTIAL_SET,
                GroupId = (int)Groups.Sandbox,
                CredentialId = SANDBOX_BEFRIENDER_TRAINING,
            });

            entity.HasData(new CredentialSet
            {
                Id = AGECONNECT_CARDIFF_TRAINING_CREDENTIAL_SET,
                GroupId = (int)Groups.AgeConnectsCardiff,
                CredentialId = VOLUNTEER_INDUCTION,
            });

            entity.HasData(new CredentialSet
            {
                Id = AGECONNECT_CARDIFF_REFERENCES_CREDENTIAL_SET,
                GroupId = (int)Groups.AgeConnectsCardiff,
                CredentialId = REFERENCES,
            });

            entity.HasData(new CredentialSet
            {
                Id = SOUTHWELL_PROCEDURES_AND_POLICIES_CREDENTIAL_SET,
                GroupId = (int)Groups.Southwell,
                CredentialId = POLICIES_AND_PROCEDURES,
            });

            entity.HasData(new CredentialSet
            {
                Id = APEXBANKSTAFF_VACCINATOR_TRAINING_CREDENTIAL_SET,
                GroupId = (int)Groups.ApexBankStaff,
                CredentialId = VACCINATOR_TRAINING,
            });

            entity.HasData(new CredentialSet
            {
                Id = APEXBANKSTAFF_BANK_DETAILS_CREDENTIAL_SET,
                GroupId = (int)Groups.ApexBankStaff,
                CredentialId = BANK_DETAILS,
            });
        }

        public static void SetActivityCredentialSet(this EntityTypeBuilder<ActivityCredentialSet> entity)
        {
            var ageUKFavershamAndSittingbourneActivities = new List<SupportActivities> { SupportActivities.PhoneCalls_Friendly, SupportActivities.Other, SupportActivities.MealsToYourDoor, SupportActivities.VolunteerSupport, SupportActivities.MealtimeCompanion };
            SetActivityCredentialSet(entity, Groups.AgeUKFavershamAndSittingbourne, ageUKFavershamAndSittingbourneActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKFavershamAndSittingbourne]);
            SetActivityCredentialSet(entity, Groups.AgeUKFavershamAndSittingbourne, ageUKFavershamAndSittingbourneActivities, DBS_CREDENTIAL_SETS[Groups.AgeUKFavershamAndSittingbourne]);

            var ageUKSouthKentCoastActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Other, SupportActivities.PhoneCalls_Friendly, SupportActivities.MealsToYourDoor, SupportActivities.VolunteerSupport, SupportActivities.MealtimeCompanion };
            SetActivityCredentialSet(entity, Groups.AgeUKSouthKentCoast, ageUKSouthKentCoastActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKSouthKentCoast]);
            SetActivityCredentialSet(entity, Groups.AgeUKSouthKentCoast, ageUKSouthKentCoastActivities, DBS_CREDENTIAL_SETS[Groups.AgeUKSouthKentCoast]);

            var ageUKNottsNorthMuskhamActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Errands, SupportActivities.PhoneCalls_Friendly, SupportActivities.Other, SupportActivities.DogWalking };
            SetActivityCredentialSet(entity, Groups.AgeUKNottsNorthMuskham, ageUKNottsNorthMuskhamActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKNottsNorthMuskham]);

            var ageUKNorthWestKentActivities = new List<SupportActivities> { SupportActivities.CollectingPrescriptions, SupportActivities.PhoneCalls_Friendly, SupportActivities.Other, SupportActivities.MealsToYourDoor, SupportActivities.VolunteerSupport };
            SetActivityCredentialSet(entity, Groups.AgeUKNorthWestKent, ageUKNorthWestKentActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKNorthWestKent]);
            SetActivityCredentialSet(entity, Groups.AgeUKNorthWestKent, ageUKNorthWestKentActivities, DBS_CREDENTIAL_SETS[Groups.AgeUKNorthWestKent]);

            var ageUKNottsBaldertonActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.PhoneCalls_Friendly, SupportActivities.Other, SupportActivities.DogWalking };
            SetActivityCredentialSet(entity, Groups.AgeUKNottsBalderton, ageUKNottsBaldertonActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKNottsBalderton]);

            var ageUKWirralActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Other, SupportActivities.ColdWeatherArmy };
            SetActivityCredentialSet(entity, Groups.AgeUKWirral, ageUKWirralActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKWirral]);
            SetActivityCredentialSet(entity, Groups.AgeUKWirral, ageUKWirralActivities, DBS_CREDENTIAL_SETS[Groups.AgeUKWirral]);

            var ruddingtonActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Errands, SupportActivities.DogWalking, SupportActivities.MealPreparation, SupportActivities.PhoneCalls_Friendly, SupportActivities.CheckingIn, SupportActivities.Other, SupportActivities.FaceMask };
            SetActivityCredentialSet(entity, Groups.Ruddington, ruddingtonActivities, IDENTITY_CREDENTIAL_SETS[Groups.Ruddington]);

            var ageUKLSLActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Errands, SupportActivities.Other, SupportActivities.WellbeingPackage };
            SetActivityCredentialSet(entity, Groups.AgeUKLSL, ageUKLSLActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKLSL]);

            SetActivityCredentialSet(entity, Groups.FTLOS, new List<SupportActivities> { SupportActivities.FaceMask }, IDENTITY_CREDENTIAL_SETS[Groups.FTLOS]);

            SetActivityCredentialSet(entity, Groups.Sandbox, new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.PhoneCalls_Friendly, SupportActivities.VaccineSupport }, IDENTITY_CREDENTIAL_SETS[Groups.Sandbox]);
            SetActivityCredentialSet(entity, Groups.Sandbox, new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.PhoneCalls_Friendly }, DBS_CREDENTIAL_SETS[Groups.Sandbox]);
            SetActivityCredentialSet(entity, Groups.Sandbox, new List<SupportActivities> { SupportActivities.PhoneCalls_Friendly }, SANDBOX_BEFRIENDER_TRAINING_CREDENTIAL_SET);

            var ageConnectsCardiffIdentifyReferencesDBSVolunteerInduction = new List<SupportActivities>
            {
                SupportActivities.InPersonBefriending,
                SupportActivities.Other,
                SupportActivities.PracticalSupport,
                SupportActivities.Shopping,
                SupportActivities.Transport
            };

            var ageConnectsCardiffIdentifyReferencesVolunteerInduction = new List<SupportActivities>
            {
                SupportActivities.CollectingPrescriptions,
                SupportActivities.PhoneCalls_Friendly,
                SupportActivities.VolunteerSupport
            };

            SetActivityCredentialSet(entity, Groups.AgeConnectsCardiff, ageConnectsCardiffIdentifyReferencesDBSVolunteerInduction, AGECONNECT_CARDIFF_REFERENCES_CREDENTIAL_SET);
            SetActivityCredentialSet(entity, Groups.AgeConnectsCardiff, ageConnectsCardiffIdentifyReferencesDBSVolunteerInduction, DBS_CREDENTIAL_SETS[Groups.AgeConnectsCardiff], 1);
            SetActivityCredentialSet(entity, Groups.AgeConnectsCardiff, ageConnectsCardiffIdentifyReferencesDBSVolunteerInduction, AGECONNECT_CARDIFF_TRAINING_CREDENTIAL_SET, 2);
            SetActivityCredentialSet(entity, Groups.AgeConnectsCardiff, ageConnectsCardiffIdentifyReferencesVolunteerInduction, AGECONNECT_CARDIFF_REFERENCES_CREDENTIAL_SET);
            SetActivityCredentialSet(entity, Groups.AgeConnectsCardiff, ageConnectsCardiffIdentifyReferencesVolunteerInduction, AGECONNECT_CARDIFF_TRAINING_CREDENTIAL_SET, 1);

            var meadowCommunityHelpersActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.FaceMask, SupportActivities.CheckingIn, SupportActivities.CollectingPrescriptions,
                SupportActivities.Errands, SupportActivities.DigitalSupport, SupportActivities.PhoneCalls_Friendly, SupportActivities.BinDayAssistance, SupportActivities.Covid19Help,
                SupportActivities.VolunteerSupport, SupportActivities.Other };
            SetActivityCredentialSet(entity, Groups.MeadowsCommunityHelpers, meadowCommunityHelpersActivities, IDENTITY_CREDENTIAL_SETS[Groups.MeadowsCommunityHelpers]);

            var defaultActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Errands, SupportActivities.MealPreparation, SupportActivities.PhoneCalls_Friendly, SupportActivities.HomeworkSupport, SupportActivities.CheckingIn, SupportActivities.Other, SupportActivities.FaceMask };
            SetActivityCredentialSet(entity, Groups.Generic, defaultActivities, IDENTITY_CREDENTIAL_SETS[Groups.Generic]);
            SetActivityCredentialSet(entity, Groups.Tankersley, defaultActivities, IDENTITY_CREDENTIAL_SETS[Groups.Tankersley]);

            var southwellActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Other };
            SetActivityCredentialSet(entity, Groups.Southwell, southwellActivities, IDENTITY_CREDENTIAL_SETS[Groups.Southwell]);
            SetActivityCredentialSet(entity, Groups.Southwell, southwellActivities, SOUTHWELL_PROCEDURES_AND_POLICIES_CREDENTIAL_SET);

            var apexbankpcnActivities = new List<SupportActivities> { SupportActivities.BankStaffVaccinator, SupportActivities.Other };
            SetActivityCredentialSet(entity, Groups.ApexBankStaff, apexbankpcnActivities, IDENTITY_CREDENTIAL_SETS[Groups.ApexBankStaff]);
            SetActivityCredentialSet(entity, Groups.ApexBankStaff, apexbankpcnActivities, APEXBANKSTAFF_VACCINATOR_TRAINING_CREDENTIAL_SET, 1);
            SetActivityCredentialSet(entity, Groups.ApexBankStaff, apexbankpcnActivities, APEXBANKSTAFF_BANK_DETAILS_CREDENTIAL_SET, 2);

            var ageukmidmerseyActivities = new List<SupportActivities> {SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Errands, SupportActivities.DogWalking, SupportActivities.PhoneCalls_Friendly, SupportActivities.InPersonBefriending,
            SupportActivities.CheckingIn, SupportActivities.BinDayAssistance, SupportActivities.PracticalSupport, SupportActivities.Covid19Help,
            SupportActivities.DigitalSupport, SupportActivities.WellbeingPackage, SupportActivities.Transport, SupportActivities.VolunteerSupport,
            SupportActivities.EmergencySupport, SupportActivities.SkillShare, SupportActivities.Other};

            SetActivityCredentialSet(entity, Groups.AgeUKMidMersey, ageukmidmerseyActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKMidMersey]);
            SetActivityCredentialSet(entity, Groups.AgeUKMidMersey, ageukmidmerseyActivities, DBS_CREDENTIAL_SETS[Groups.AgeUKMidMersey]);
        }

        private static void SetActivityCredentialSet(EntityTypeBuilder<ActivityCredentialSet> entity, Groups group, List<SupportActivities> activities, int credentialSetId, int displayOrder = 0)
        {
            foreach (var activity in activities)
            {
                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)group,
                    ActivityId = (int)activity,
                    CredentialSetId = credentialSetId,
                    DisplayOrder = displayOrder
                });
            }
        }
    }
}
