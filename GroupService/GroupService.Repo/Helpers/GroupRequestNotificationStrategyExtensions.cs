using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupService.Repo.Helpers
{
    public static class GroupRequestNotificationStrategyExtensions
    {
        public static void SetGroupRequestNotificationStrategyExtensions(this EntityTypeBuilder<GroupNewRequestNotificationStrategy> entity)
        {
            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Ruddington,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKWirral,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Generic,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = 100
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Sandbox,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Southwell,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });
        }
    }
}