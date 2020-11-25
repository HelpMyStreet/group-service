using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class NewRequestNotificationStrategyExtensions
    {
        public static void SetEnumStrategyData(this EntityTypeBuilder<EnumNewRequestNotificationStrategy> entity)
        {
            var strategies = Enum.GetValues(typeof(NewRequestNotificationStrategy)).Cast<NewRequestNotificationStrategy>();

            foreach (var strategy in strategies)
            {
                entity.HasData(new EnumNewRequestNotificationStrategy { Id = (int)strategy, Name = strategy.ToString() });
            }
        }
    }
}
