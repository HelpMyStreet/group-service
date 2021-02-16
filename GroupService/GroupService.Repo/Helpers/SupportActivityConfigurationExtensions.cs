using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class SupportActivityConfigurationExtensions
    {
        private static List<SupportActivities> _supportActivitiesExclude;

        public static void InitialiseData()
        {
            _supportActivitiesExclude = new List<SupportActivities>();
            _supportActivitiesExclude.Add(SupportActivities.MedicalAppointmentTransport);            
            _supportActivitiesExclude.Add(SupportActivities.PhoneCalls_Anxious);
            _supportActivitiesExclude.Add(SupportActivities.HomeworkSupport);          
            _supportActivitiesExclude.Add(SupportActivities.FaceMask);
            _supportActivitiesExclude.Add(SupportActivities.CommunityConnector);
            _supportActivitiesExclude.Add(SupportActivities.Transport);
            _supportActivitiesExclude.Add(SupportActivities.Other);
        }
        public static void SetSupportActivityConfigurationExtensionsData(this EntityTypeBuilder<SupportActivityConfiguration> entity)
        {
            var activities = Enum.GetValues(typeof(SupportActivities)).Cast<SupportActivities>();

            foreach (var activity in activities.Where(x => !_supportActivitiesExclude.Contains(x)))
            {
                entity.HasData(new SupportActivityConfiguration
                {
                    SupportActivityId = (int) activity,
                    AutoSignUpWhenOtherSelected = true
                });
            }
        }
    }
}
