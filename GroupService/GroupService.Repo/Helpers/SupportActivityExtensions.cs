using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class SupportActivityExtensions
    {
        public static void SetEnumSupportActivityExtensionsData(this EntityTypeBuilder<EnumSupportActivity> entity)
        {
            var supportActivity = Enum.GetValues(typeof(SupportActivities)).Cast<SupportActivities>();

            foreach (var activity in supportActivity)
            {
                entity.HasData(new EnumSupportActivity { Id = (int)activity, Name = activity.ToString(), FriendlyName = activity.FriendlyNameShort() });
            }
        }
    }
}
