using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupService.Repo.Helpers
{
    public static class GroupLocationsExtensions
    {
		private static void Populate(this EntityTypeBuilder<GroupLocation> entity, Groups group, Location location)
		{
			entity.HasData(new GroupLocation
			{
				GroupId = (int)group,
				LocationId = (int)location
			});
		}


        public static void SetGroupLocationsConfiguration(this EntityTypeBuilder<GroupLocation> entity)
        {
			Populate(entity, Groups.Generic, Location.RustonsSportsAndSocialClubLincoln);
			Populate(entity, Groups.Generic, Location.StMarysMedicalPracticeStamford);
			Populate(entity, Groups.Generic, Location.LouthCommunityHospital);
			Populate(entity, Groups.Generic, Location.RichmondMedicalCentre);
		}
	}
}
