using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupService.Repo.Helpers
{
    public static class GroupLocationsExtensions
    {
        public static void SetGroupLocationsConfiguration(this EntityTypeBuilder<GroupLocation> entity)
        {
            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.LouthPCN,
                LocationId = (int) Location.LouthCommunityHospital
            });

            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.GranthamPCN,
                LocationId = (int)Location.TableTennisClubGrantham
            });

            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.SouthLincolnPCN,
                LocationId = (int)Location.WaddingtonBranchSurgerySouthLincoln
            });

            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.StamfordPCN,
                LocationId = (int)Location.StMarysMedicalPracticeStamford
            });

            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.SpilsbyPCN,
                LocationId = (int)Location.FranklinHallSpilsby
            });


            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.BostonPCN,
                LocationId = (int)Location.SidingsMedicalPracticeBoston
            });

            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.LincolnPCN,
                LocationId = (int)Location.RustonsSportsAndSocialClubLincoln
            });

            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.LincolnPortlandPCN,
                LocationId = (int)Location.PortlandMedicalPracticeLincoln
            });

            entity.HasData(new GroupLocation
            {
                GroupId = (int)Groups.Sandbox,
                LocationId = (int)Location.RustonsSportsAndSocialClubLincoln
            });
        }
    }
}
