using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class RoleExtensions
    {
        public static void SetEnumRoleData(this EntityTypeBuilder<EnumRole> entity)
        {
            var groupRoles = Enum.GetValues(typeof(GroupRoles)).Cast<GroupRoles>();

            foreach (var role in groupRoles)
            {
                entity.HasData(new EnumRole { Id = (int)role, Name = role.ToString() });
            }
        }
    }
}
