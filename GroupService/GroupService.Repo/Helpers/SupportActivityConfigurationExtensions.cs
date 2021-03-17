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
        private static List<SupportActivities> _supportActivities_excludeFromAutoSignUp;

        public static void InitialiseData()
        {
            _supportActivities_excludeFromAutoSignUp = new List<SupportActivities>
            {
                SupportActivities.MedicalAppointmentTransport,
                SupportActivities.PhoneCalls_Anxious,
                SupportActivities.HomeworkSupport,
                SupportActivities.FaceMask,
                SupportActivities.CommunityConnector,
                SupportActivities.Transport,
                SupportActivities.VolunteerInduction,
                SupportActivities.Other,
            };
        }
        public static void SetSupportActivityConfigurationExtensionsData(this EntityTypeBuilder<SupportActivityConfiguration> entity)
        {
            var activities = Enum.GetValues(typeof(SupportActivities)).Cast<SupportActivities>();

            foreach (var activity in activities)
            {
                entity.HasData(new SupportActivityConfiguration
                {
                    SupportActivityId = (int)activity,
                    AutoSignUpWhenOtherSelected = !_supportActivities_excludeFromAutoSignUp.Contains(activity)
                });
            }
        }
    }
}
