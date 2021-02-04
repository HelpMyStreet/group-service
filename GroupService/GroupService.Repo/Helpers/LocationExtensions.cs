using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class LocationExtensions
    {
        public static void SetEnumLocationData(this EntityTypeBuilder<EnumLocation> entity)
        {
            var locations = Enum.GetValues(typeof(Location)).Cast<Location>();

            foreach (var location in locations)
            {
                entity.HasData(new EnumLocation { Id = (int)location, Name = location.ToString() });
            }
        }
    }
}
