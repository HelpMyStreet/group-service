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

            foreach (var group in groups)
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
                $"Volunteer admins should follow internal processes for manually verifying a volunteer's identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKLSL,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email Age UK Lincoln & South Lincolnshire to find out how they can check your ID at volunteering@ageuklsl.org.uk",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
               $"Volunteer admins should follow internal processes for manually verifying a volunteer's identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.AgeUKNottsBalderton,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, please email us to find out more about our manual ID check at baldertoncs@helpmystreet.org",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
               $"Volunteer admins should follow internal processes for manually verifying a volunteer's identity.",
                DisplayOrder = 2,
                CredentialVerifiedById = (byte)CredentialVerifiedBy.GroupAdmin
            });
        }

        public static void SetCredentialSet(this EntityTypeBuilder<CredentialSet> entity)
        {
            var groups = Enum.GetValues(typeof(Groups)).Cast<Groups>();

            foreach (var group in groups)
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
        }

        public static void SetActivityCredentialSet(this EntityTypeBuilder<ActivityCredentialSet> entity)
        {
            var groups = Enum.GetValues(typeof(Groups)).Cast<Groups>();
            var activities = Enum.GetValues(typeof(SupportActivities)).Cast<SupportActivities>();

            foreach (var group in groups)
            {
                foreach (var activity in activities)
                {
                    entity.HasData(new ActivityCredentialSet
                    {
                        GroupId = (int)group,
                        ActivityId = (int)activity,
                        CredentialSetId = CredentialSets[group]
                    });
                }
            }

            foreach (var activity in activities)
            {
                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKWirral,
                    ActivityId = (int)activity,
                    CredentialSetId = AGEUKWIRRAL_DBS_CHECK_CREDENTIAL_SET
                });
            }
        }
    }
}
