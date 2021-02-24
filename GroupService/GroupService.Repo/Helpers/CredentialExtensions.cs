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
        private static List<Groups> EXCLUDE_GROUPS = new List<Groups>();
        private static List<SupportActivities> EXCLUDE_ACTIVITIES = new List<SupportActivities>();

        // Credential Set IDs
        private static Dictionary<Groups, int> IDENTITY_CREDENTIAL_SETS;
        private static Dictionary<Groups, int> DBS_CREDENTIAL_SETS;
        private const int SANDBOX_BEFRIENDER_TRAINING_CREDENTIAL_SET = 142;

        // Credential IDs
        private const int IDENTITY_VERIFIED_BY_YOTI = -1;
        private const int MANUALLY_VERIFIED = 1;
        private const int DBS_CHECK = 2;
        private const int SANDBOX_BEFRIENDER_TRAINING = 3;

        public static void InitialiseCredentialSets()
        {
            IDENTITY_CREDENTIAL_SETS = new Dictionary<Groups, int>
            {
                { Groups.Generic, 1 },
                { Groups.FTLOS, 2 },
                { Groups.AgeUKLSL, 3 },
                { Groups.HLP, 4 },
                { Groups.Tankersley, 5 },
                { Groups.Ruddington, 6 },
                { Groups.AgeUKWirral, 7 },
                { Groups.AgeUKNottsBalderton, 8 },
                { Groups.AgeUKNorthWestKent, 9 },
                { Groups.AgeUKNottsNorthMuskham, 10 },
                { Groups.AgeUKSouthKentCoast, 11 },
                { Groups.AgeUKFavershamAndSittingbourne, 13 },
                { Groups.Sandbox, 14 }
            };
            DBS_CREDENTIAL_SETS = new Dictionary<Groups, int> 
            {
                { Groups.AgeUKWirral, 71 },
                { Groups.AgeUKNorthWestKent, 91 },
                { Groups.AgeUKSouthKentCoast, 111 },
                { Groups.AgeUKFavershamAndSittingbourne, 131 },
                { Groups.Sandbox, 141 },
            };

            EXCLUDE_GROUPS.Add(Groups.LincolnshireVolunteers);
            EXCLUDE_GROUPS.Add(Groups.LouthPCN);
            EXCLUDE_GROUPS.Add(Groups.GranthamPCN);
            EXCLUDE_GROUPS.Add(Groups.SouthLincolnPCN);
            EXCLUDE_GROUPS.Add(Groups.StamfordPCN);
            EXCLUDE_GROUPS.Add(Groups.SpilsbyPCN);
            EXCLUDE_GROUPS.Add(Groups.BostonPCN);
            EXCLUDE_GROUPS.Add(Groups.LincolnPCN);
            EXCLUDE_GROUPS.Add(Groups.LincolnPortlandPCN);
            EXCLUDE_GROUPS.Add(Groups.Sandbox);
            EXCLUDE_ACTIVITIES.Add(SupportActivities.VaccineSupport);

            GROUPS_USING_YOTI = new List<Groups> {
                Groups.Sandbox,
                Groups.AgeUKFavershamAndSittingbourne,
                Groups.AgeUKSouthKentCoast,
                Groups.AgeUKNottsNorthMuskham,
                Groups.AgeUKNorthWestKent,
                Groups.AgeUKNottsBalderton,
                Groups.AgeUKWirral,
                Groups.Ruddington,
                Groups.Tankersley,
                Groups.HLP,
                Groups.AgeUKLSL,
                Groups.FTLOS,
                Groups.Generic,
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
                Groups.Sandbox
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

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.Sandbox,
                CredentialId = MANUALLY_VERIFIED,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                Name = "Manual ID Verification",
                HowToAchieve = "If you’re unable to verify with Yoti, email your group admins to find out how they can check your ID",
                HowToAchieve_CTA_Destination = "",
                WhatIsThis = $"Use this credential to certify that you have verified a volunteer’s identity and are satisfied they are who they claim to be. \r\n\r\n" +
                $"Volunteer admins should follow internal processes for manually verifying a volunteer’s identity.",
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
                WhatIsThis = $"Use this credential to record a completed DBS (Disclosure and Barring Service) check.\r\n\r\n" +
                $"Volunteer admins should follow internal processes for logging a DBS check.",
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
        }

        public static void SetActivityCredentialSet(this EntityTypeBuilder<ActivityCredentialSet> entity)
        {
            var groups = Enum.GetValues(typeof(Groups)).Cast<Groups>();
            var activities = Enum.GetValues(typeof(SupportActivities)).Cast<SupportActivities>();

            foreach (var group in groups.Where(x=> !EXCLUDE_GROUPS.Contains(x)))
            {
                foreach (var activity in activities.Where(x => !EXCLUDE_ACTIVITIES.Contains(x)))
                {
                    entity.HasData(new ActivityCredentialSet
                    {
                        GroupId = (int)group,
                        ActivityId = (int)activity,
                        CredentialSetId = IDENTITY_CREDENTIAL_SETS[group]
                    });
                }
            }

            foreach (var activity in activities.Where(x => !EXCLUDE_ACTIVITIES.Contains(x)))
            {
                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKWirral,
                    ActivityId = (int)activity,
                    CredentialSetId = DBS_CREDENTIAL_SETS[Groups.AgeUKWirral]
                });

                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKNorthWestKent,
                    ActivityId = (int)activity,
                    CredentialSetId = DBS_CREDENTIAL_SETS[Groups.AgeUKNorthWestKent]
                });

                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKSouthKentCoast,
                    ActivityId = (int)activity,
                    CredentialSetId = DBS_CREDENTIAL_SETS[Groups.AgeUKSouthKentCoast]
                });

                entity.HasData(new ActivityCredentialSet
                {
                    GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                    ActivityId = (int)activity,
                    CredentialSetId = DBS_CREDENTIAL_SETS[Groups.AgeUKFavershamAndSittingbourne]
                });
            }
        }
    }
}
