using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class UrgentRequestNotificationStrategyExtensions
    {
        public static void SetEnumUrgentRequestNotificationStrategyData(this EntityTypeBuilder<EnumUrgentRequestNotificationStrategy> entity)
        {
            var strategies = Enum.GetValues(typeof(UrgentRequestNotificationStrategy)).Cast<UrgentRequestNotificationStrategy>();

            foreach (var strategy in strategies)
            {
                entity.HasData(new EnumUrgentRequestNotificationStrategy { Id = (int)strategy, Name = strategy.ToString() });
            }
        }
    }
}
