using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class RequestEventsExtensions
    {
        public static void SetEnumRequestEventData(this EntityTypeBuilder<EnumRequestEvents> entity)
        {
            var requestEvents = Enum.GetValues(typeof(RequestEvent)).Cast<RequestEvent>();

            foreach (var requestEvent in requestEvents)
            {
                entity.HasData(new EnumRequestEvents { Id = (int)requestEvent, Name = requestEvent.ToString() });
            }
        }
    }
}
