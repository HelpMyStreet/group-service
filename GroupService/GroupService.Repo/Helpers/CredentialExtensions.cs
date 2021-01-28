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
        public static Dictionary<Groups, int> CredentialSets = new Dictionary<Groups, int>();
        private const int IDENTITY_VERIFIED_BY_YOTI = -1;
        private const int MANUALLY_VERIFIED = 1;
        private const int DBS_CHECK = 2;
        private const int AGEUKWIRRAL_DBS_CHECK_CREDENTIAL_SET = 71;
        private const int AGEUKNWK_DBS_CHECK_CREDENTIAL_SET = 91;
        private const int AGEUKSKC_DBS_CHECK_CREDENTIAL_SET = 111;
        private const int AGEFANDS_DBS_CHECK_CREDENTIAL_SET = 131;

        private static List<Groups> EXCLUDE_GROUPS = new List<Groups>();
        private static List<SupportActivities> EXCLUDE_ACTIVITIES = new List<SupportActivities>();
        public static void InitialiseCredentialSets()
        {
            CredentialSets.Add(Groups.Generic, 1);
            CredentialSets.Add(Groups.FTLOS, 2);
            CredentialSets.Add(Groups.AgeUKLSL, 3);
            CredentialSets.Add(Groups.HLP, 4);
            CredentialSets.Add(Groups.Tankersley, 5);
            CredentialSets.Add(Groups.Ruddington, 6);
            CredentialSets.Add(Groups.AgeUKWirral, 7);
            CredentialSets.Add(Groups.AgeUKNottsBalderton, 8);
            CredentialSets.Add(Groups.AgeUKNorthWestKent, 9);
            CredentialSets.Add(Groups.AgeUKNottsNorthMuskham, 10);
            CredentialSets.Add(Groups.AgeUKSouthKentCoast, 11);
            CredentialSets.Add(Groups.AgeUKFavershamAndSittingbourne, 13);

            EXCLUDE_GROUPS.Add(Groups.LincolnshireVolunteers);
            EXCLUDE_GROUPS.Add(Groups.LouthPCN);
            EXCLUDE_GROUPS.Add(Groups.GranthamPCN);
            EXCLUDE_GROUPS.Add(Groups.SouthLincolnPCN);
            EXCLUDE_GROUPS.Add(Groups.StamfordPCN);
            EXCLUDE_GROUPS.Add(Groups.SpilsbyPCN);
            EXCLUDE_GROUPS.Add(Groups.BostonPCN);
            EXCLUDE_GROUPS.Add(Groups.LincolnPCN);
            EXCLUDE_GROUPS.Add(Groups.LincolnPortlandPCN);

            EXCLUDE_ACTIVITIES.Add(SupportActivities.Steward);
            EXCLUDE_ACTIVITIES.Add(SupportActivities.BackOfficeAdmin);
            EXCLUDE_ACTIVITIES.Add(SupportActivities.FrontOfHouseAdmin);
            EXCLUDE_ACTIVITIES.Add(SupportActivities.HealthcareAssistant);
            EXCLUDE_ACTIVITIES.Add(SupportActivities.HealthcareAssistant);
            EXCLUDE_ACTIVITIES.Add(SupportActivities.VaccineSupport);
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
        }

        public static void SetGroupCredentials(this EntityTypeBuilder<GroupCredential> entity)
        {
            var groups = Enum.GetValues(typeof(Groups)).Cast<Groups>();

            foreach (var group in groups.Where(x=> !EXCLUDE_GROUPS.Contains(x)))
            {
                entity.HasData(new GroupCredential
                {
                    GroupId = (int)group,
                    CredentialId = IDENTITY_VERIFIED_BY_YOTI,
                    CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                    Name = "Yoti ID Verification",
                    HowToAchieve = "Complete online",
                    HowToAchieve_CTA_Destination = "/account?next=verify",
                    WhatIsThis = $"Yoti is our trusted digital identity verification provider. Volunteers can follow the instructions in their profile to get verified.\r\n\r\n" +
                    $"Volunteer admins cannot edit this credential.",
                    DisplayOrder = 1,
                    CredentialVerifiedById = (byte) CredentialVerifiedBy.System
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
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check.\r\n\r\n" +
                $"Volunteer admins should follow internal processes for logging a DBS check.",
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
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
                $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
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
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
               $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKNottsBalderton,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, please email us to find out more about our manual ID check at mailto:baldertoncs@helpmystreet.org",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
               $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
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
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
               $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
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
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check.\r\n\r\n" +
                $"Volunteer admins should follow internal processes for logging a DBS check.",
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
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
                $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
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
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check.\r\n\r\n" +
                $"Volunteer admins should follow internal processes for logging a DBS check.",
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
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
                $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
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
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check.\r\n\r\n" +
                $"Volunteer admins should follow internal processes for logging a DBS check.",
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
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
                $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });
        }

        public static void SetCredentialSet(this EntityTypeBuilder<CredentialSet> entity)
        {
            var groups = Enum.GetValues(typeof(Groups)).Cast<Groups>();

            foreach (var group in groups.Where(x => !EXCLUDE_GROUPS.Contains(x)))
            {                
                entity.HasData(new CredentialSet
                {
                    Id = CredentialSets[group],
                    GroupId = (int)group,
                    CredentialId = IDENTITY_VERIFIED_BY_YOTI
                });                
            }

            entity.HasData(new CredentialSet
            {
                Id = CredentialSets[Groups.AgeUKWirral],
                GroupId = (int)Groups.AgeUKWirral,
                CredentialId = MANUALLY_VERIFIED
            });

            entity.HasData(new CredentialSet
            {
                Id = AGEUKWIRRAL_DBS_CHECK_CREDENTIAL_SET,
                GroupId = (int)Groups.AgeUKWirral,
                CredentialId = DBS_CHECK
            });

            entity.HasData(new CredentialSet
            {
                Id = CredentialSets[Groups.AgeUKLSL],
                GroupId = (int)Groups.AgeUKLSL,
                CredentialId = MANUALLY_VERIFIED
            });

            entity.HasData(new CredentialSet
            {
                Id = CredentialSets[Groups.AgeUKNottsBalderton],
                GroupId = (int)Groups.AgeUKNottsBalderton,
                CredentialId = MANUALLY_VERIFIED
            });

            entity.HasData(new CredentialSet
            {
                Id = CredentialSets[Groups.AgeUKNottsNorthMuskham],
                GroupId = (int)Groups.AgeUKNottsNorthMuskham,
                CredentialId = MANUALLY_VERIFIED
            });

            entity.HasData(new CredentialSet
            {
                Id = CredentialSets[Groups.AgeUKNorthWestKent],
                GroupId = (int)Groups.AgeUKNorthWestKent,
                CredentialId = MANUALLY_VERIFIED
            });

            entity.HasData(new CredentialSet
            {
                Id = AGEUKNWK_DBS_CHECK_CREDENTIAL_SET,
                GroupId = (int)Groups.AgeUKNorthWestKent,
                CredentialId = DBS_CHECK
            });

            entity.HasData(new CredentialSet
            {
                Id = CredentialSets[Groups.AgeUKSouthKentCoast],
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                CredentialId = MANUALLY_VERIFIED
            });

            entity.HasData(new CredentialSet
            {
                Id = AGEUKSKC_DBS_CHECK_CREDENTIAL_SET,
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                CredentialId = DBS_CHECK
            });

            entity.HasData(new CredentialSet
            {
                Id = CredentialSets[Groups.AgeUKFavershamAndSittingbourne],
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                CredentialId = MANUALLY_VERIFIED
            });

            entity.HasData(new CredentialSet
            {
                Id = AGEFANDS_DBS_CHECK_CREDENTIAL_SET,
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                CredentialId = DBS_CHECK
            });
        }

        public static void SetActivityCredentialSet(this EntityTypeBuilder<ActivityCredentialSet> entity)
        {
            var groups = Enum.GetValues(typeof(Groups)).Cast<Groups>();
            var activities = Enum.GetValues(typeof(SupportActivities)).Cast<SupportActivities>();

            foreach (var group in groups.Where(x => !EXCLUDE_GROUPS.Contains(x)))
            {
                foreach (var activity in activities.Where(x => !EXCLUDE_ACTIVITIES.Contains(x)))
                {
                    entity.HasData(new ActivityCredentialSet
                    {
                        GroupId = (int)group,
                        ActivityId = (int)activity,
                        CredentialSetId = CredentialSets[group]
                    });
                }
            }

            foreach (var activity in activities.Where(x => !EXCLUDE_ACTIVITIES.Contains(x)))
            {
                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKWirral,
                    ActivityId = (int)activity,
                    CredentialSetId = AGEUKWIRRAL_DBS_CHECK_CREDENTIAL_SET
                });

                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKNorthWestKent,
                    ActivityId = (int)activity,
                    CredentialSetId = AGEUKNWK_DBS_CHECK_CREDENTIAL_SET
                });

                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKSouthKentCoast,
                    ActivityId = (int)activity,
                    CredentialSetId = AGEUKSKC_DBS_CHECK_CREDENTIAL_SET
                });

                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                    ActivityId = (int)activity,
                    CredentialSetId = AGEFANDS_DBS_CHECK_CREDENTIAL_SET
                });
            }
        }
    }
}
