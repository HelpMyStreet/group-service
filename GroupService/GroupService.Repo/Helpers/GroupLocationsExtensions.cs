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
			Populate(entity, Groups.EastLindseyPCN, Location.LouthCommunityHospital);
			Populate(entity, Groups.StamfordPCN, Location.StMarysMedicalPracticeStamford);
			Populate(entity, Groups.LincolnPCN, Location.RustonsSportsAndSocialClubLincoln);
			Populate(entity, Groups.Sandbox, Location.RustonsSportsAndSocialClubLincoln);
			Populate(entity, Groups.ApexBankStaff, Location.RustonsSportsAndSocialClubLincoln);
			Populate(entity, Groups.Generic, Location.RustonsSportsAndSocialClubLincoln);
			Populate(entity, Groups.LincolnshireVolunteers, Location.RustonsSportsAndSocialClubLincoln);
			Populate(entity, Groups.Generic, Location.StMarysMedicalPracticeStamford);
			Populate(entity, Groups.LincolnshireVolunteers, Location.StMarysMedicalPracticeStamford);
			Populate(entity, Groups.Generic, Location.LouthCommunityHospital);
			Populate(entity, Groups.LincolnshireVolunteers, Location.LouthCommunityHospital);
			Populate(entity, Groups.LincolnPCN, Location.RichmondMedicalCentre);
			Populate(entity, Groups.LincolnshireVolunteers, Location.RichmondMedicalCentre);
			Populate(entity, Groups.Generic, Location.RichmondMedicalCentre);
			Populate(entity, Groups.ApexBankStaff, Location.RichmondMedicalCentre);

			Populate(entity, Groups.NHSVRDemo, Location.ForestRecreationGround);
			Populate(entity, Groups.NHSVRDemo, Location.RichardHerrodCentre);
			Populate(entity, Groups.NHSVRDemo, Location.MansfieldWickesSite);

		}
	}
}
