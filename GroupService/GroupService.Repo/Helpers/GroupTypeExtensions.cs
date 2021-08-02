using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class GroupTypeExtensions
    {
        public static void SetEnumGroupTypeData(this EntityTypeBuilder<EnumGroupType> entity)
        {
            var groupTypes = Enum.GetValues(typeof(GroupTypes)).Cast<GroupTypes>();

            foreach (var groupType in groupTypes)
            {
                entity.HasData(new EnumGroupType { Id = (int)groupType, Name = groupType.ToString()});
            }
        }
    }
}
