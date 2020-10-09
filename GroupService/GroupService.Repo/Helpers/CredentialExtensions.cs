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

        public static void InitialiseCredentialSets()
        {
            CredentialSets.Add(Groups.Generic, 1);
            CredentialSets.Add(Groups.FTLOS, 2);
            CredentialSets.Add(Groups.AgeUKLSL, 3);
            CredentialSets.Add(Groups.HLP, 4);
            CredentialSets.Add(Groups.Tankersley, 5);
            CredentialSets.Add(Groups.Ruddington, 6);
        }

        public static void SetCredentials(this EntityTypeBuilder<Credential> entity)
        {
            entity.HasData(new Credential
            {
                Id = -1,
                Name = "IdentityVerifiedByYoti"
            });

            entity.HasData(new Credential
            {
                Id = 1,
                Name = "ManuallyVerified"
            });

            entity.HasData(new Credential
            {
                Id = 2,
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
                    CredentialId = -1,
                    CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                    Name = "Yoti Identity Verification",
                    HowToAchieve = "Yoti App",
                    DisplayOrder = 1
                });
            }
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
                    CredentialId = -1
                });
            }
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
        }
    }
}
