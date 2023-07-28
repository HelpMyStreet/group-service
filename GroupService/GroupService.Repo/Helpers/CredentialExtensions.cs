using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        private const int SOUTHWELL_PROCEDURES_AND_POLICIES_CREDENTIAL_SET = 317;

        // Credential IDs
        private const int IDENTITY_VERIFIED_BY_YOTI = -1;
        private const int MANUALLY_VERIFIED = 1;
        private const int DBS_CHECK = 2;
        private const int SANDBOX_BEFRIENDER_TRAINING = 3;
        private const int POLICIES_AND_PROCEDURES = 7;

        public static void InitialiseCredentialSets()
        {
            IDENTITY_CREDENTIAL_SETS = new Dictionary<Groups, int>
            {
                { Groups.Generic, 1 },
                { Groups.Ruddington, 6 },
                { Groups.AgeUKWirral, 7 },
                { Groups.Sandbox, 14 },
                { Groups.Southwell, 31 }
            };
            DBS_CREDENTIAL_SETS = new Dictionary<Groups, int>
            {
                { Groups.AgeUKWirral, 71 },
                { Groups.Sandbox, 141 }
            };

            GROUPS_USING_YOTI = new List<Groups> {
                Groups.Sandbox,
                Groups.AgeUKWirral,
                Groups.Ruddington,
                Groups.Generic,
                Groups.Southwell
            };

            GROUPS_USING_MANUAL_ID = new List<Groups>
            {
                Groups.AgeUKWirral,
                Groups.Sandbox,
                Groups.Southwell,              
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
                Id = POLICIES_AND_PROCEDURES,
                Name = "Policies & Procedures"
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
                Id = SOUTHWELL_PROCEDURES_AND_POLICIES_CREDENTIAL_SET,
                GroupId = (int)Groups.Southwell,
                CredentialId = POLICIES_AND_PROCEDURES,
            });
        }

        public static void SetActivityCredentialSet(this EntityTypeBuilder<ActivityCredentialSet> entity)
        {
            var ageUKWirralActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Other, SupportActivities.ColdWeatherArmy };
            SetActivityCredentialSet(entity, Groups.AgeUKWirral, ageUKWirralActivities, IDENTITY_CREDENTIAL_SETS[Groups.AgeUKWirral]);
            SetActivityCredentialSet(entity, Groups.AgeUKWirral, ageUKWirralActivities, DBS_CREDENTIAL_SETS[Groups.AgeUKWirral]);

            var ruddingtonActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Errands, SupportActivities.DogWalking, SupportActivities.MealPreparation, SupportActivities.PhoneCalls_Friendly, SupportActivities.CheckingIn, SupportActivities.Other, SupportActivities.FaceMask };
            SetActivityCredentialSet(entity, Groups.Ruddington, ruddingtonActivities, IDENTITY_CREDENTIAL_SETS[Groups.Ruddington]);

            SetActivityCredentialSet(entity, Groups.Sandbox, new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.PhoneCalls_Friendly, SupportActivities.VaccineSupport }, IDENTITY_CREDENTIAL_SETS[Groups.Sandbox]);
            SetActivityCredentialSet(entity, Groups.Sandbox, new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.PhoneCalls_Friendly }, DBS_CREDENTIAL_SETS[Groups.Sandbox]);
            SetActivityCredentialSet(entity, Groups.Sandbox, new List<SupportActivities> { SupportActivities.PhoneCalls_Friendly }, SANDBOX_BEFRIENDER_TRAINING_CREDENTIAL_SET);

            var defaultActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Errands, SupportActivities.MealPreparation, SupportActivities.PhoneCalls_Friendly, SupportActivities.HomeworkSupport, SupportActivities.CheckingIn, SupportActivities.Other, SupportActivities.FaceMask };
            SetActivityCredentialSet(entity, Groups.Generic, defaultActivities, IDENTITY_CREDENTIAL_SETS[Groups.Generic]);

            var southwellActivities = new List<SupportActivities> { SupportActivities.Shopping, SupportActivities.CollectingPrescriptions, SupportActivities.Other };
            SetActivityCredentialSet(entity, Groups.Southwell, southwellActivities, IDENTITY_CREDENTIAL_SETS[Groups.Southwell]);
            SetActivityCredentialSet(entity, Groups.Southwell, southwellActivities, SOUTHWELL_PROCEDURES_AND_POLICIES_CREDENTIAL_SET);
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
