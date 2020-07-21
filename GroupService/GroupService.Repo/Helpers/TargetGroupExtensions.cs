using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class TargetGroupExtensions
    {
        public static void SetEnumTargetGroupData(this EntityTypeBuilder<EnumTargetGroup> entity)
        {
            var targetGroups = Enum.GetValues(typeof(TargetGroups)).Cast<TargetGroups>();

            foreach (var targetGroup in targetGroups)
            {
                entity.HasData(new EnumTargetGroup { Id = (int)targetGroup, Name = targetGroup.ToString() });
            }
        }
    }
}
