using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupService.Repo.Helpers
{
    public static class GroupCredentialExtensions
    {
        public static void SetGroupCredentials(this EntityTypeBuilder<GroupCredential> entity)
        {
            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.Generic,
                CredentialTypeId = (int) CredentialTypes.IdentityVerification,
                CredentialId = -1,
                Name = "Yoti Identity Verification",
                HowToAchieve = "Use Yoti App",
                DisplayOrder = 1
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.FTLOS,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                CredentialId = -1,
                Name = "Yoti Identity Verification",
                HowToAchieve = "Use Yoti App",
                DisplayOrder = 1
            });

            entity.HasData(new GroupCredential
            {
                GroupId = (int)Groups.FTLOS,
                CredentialTypeId = (int)CredentialTypes.IdentityVerification,
                CredentialId = 1,
                Name = "Yoti Identity Verification",
                HowToAchieve = "Email someone",
                DisplayOrder = 2
            });
        }
    }
}
