using GroupService.Repo.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.Helpers
{
    public static class GroupExtensions
    {
        public static void SetDefaultGroup(this EntityTypeBuilder<Group> entity)
        {
            entity.HasData(new Group
            {
                Id = (int)-1,
                GroupName = "Generic",
                GroupKey = "Generic"
            });
        }
    }
}
