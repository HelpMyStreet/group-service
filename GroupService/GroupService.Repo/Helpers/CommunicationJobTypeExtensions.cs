using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class CommunicationJobTypeExtensions
    {
        public static void SetCommunicationJobData(this EntityTypeBuilder<EnumCommunicationJobType> entity)
        {
            var communicationJobTypes = Enum.GetValues(typeof(CommunicationJobTypes)).Cast<CommunicationJobTypes>();

            foreach (var communicationJob in communicationJobTypes)
            {
                entity.HasData(new EnumCommunicationJobType { Id = (int)communicationJob, Name = communicationJob.ToString() });
            }
        }
    }
}
