using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupService.Repo.Helpers
{
    public static class SecurityConfigurationExtensions
    {
        public static void SetDefaultSecurityConfiguration(this EntityTypeBuilder<SecurityConfiguration> entity)
        {
            entity.HasData(new SecurityConfiguration
            {
                GroupId = (int)Groups.Ruddington,
                AllowAutonomousJoinersAndLeavers = true
            });

            entity.HasData(new SecurityConfiguration
            {
                GroupId = (int)Groups.AgeUKLSL,
                AllowAutonomousJoinersAndLeavers = true
            });

            entity.HasData(new SecurityConfiguration
            {
                GroupId = (int)Groups.FTLOS,
                AllowAutonomousJoinersAndLeavers = true
            });

            entity.HasData(new SecurityConfiguration
            {
                GroupId = (int)Groups.Tankersley,
                AllowAutonomousJoinersAndLeavers = true
            });
        }
    }
}
