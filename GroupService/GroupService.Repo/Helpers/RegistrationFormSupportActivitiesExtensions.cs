using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class RegistrationFormSupportActivitiesExtensions
    {
        private static string GetLabel(SupportActivities activity)
        {
            return activity switch
            {
                SupportActivities.Shopping => "Picking up groceries and other essentials (e.g. food, toiletries, household products etc.)",
                SupportActivities.CollectingPrescriptions => "Collecting prescriptions from a local pharmacy",
                SupportActivities.Errands => "Running essential local errands (e.g. posting mail)",
                SupportActivities.DogWalking => "Walking the dog",
                SupportActivities.MealPreparation => "Preparing and/or delivering a hot / pre-prepared meal",
                SupportActivities.PhoneCalls_Friendly => "Calling someone in need of a friendly chat",
                SupportActivities.PhoneCalls_Anxious => "Providing support over the phone to someone who may be anxious (relevant experience required e.g. mental health first-aider)",
                SupportActivities.HomeworkSupport => "Providing remote support for parents and carers home-schooling their children",
                SupportActivities.CheckingIn => "Reaching out to people in my area to check-in",
                SupportActivities.FaceMask => "Supplying homemade face coverings",
                SupportActivities.WellbeingPackage => "Collecting and delivering a pre-prepared wellbeing package",
                SupportActivities.Other => "I may be able to help with other tasks, so please check with me.",
                SupportActivities.CommunityConnector => "Being a **COMMUNITY CONNECTOR**",
                //SupportActivities.MedicalAppointmentTransport => "Medical Appointment Transport",
                SupportActivities.ColdWeatherArmy => "Providing help in emergency situations during a cold snap",
                SupportActivities.Transport => "Providing transport for essential appointments",
                // SupportActivities.MealsToYourDoor => "Meals To Your Door",
                //SupportActivities.MealtimeCompanion => "Mealtime Companion",
                //SupportActivities.VolunteerSupport => "Volunteer Support",
                //SupportActivities.VaccineSupport => "Vaccine Support",
                _ => throw new ArgumentException(message: $"Unexpected SupportActivity: {activity}", paramName: nameof(activity))
            };
        }

        private static void SetHLPSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.CommunityConnector,
                Label = GetLabel(SupportActivities.CommunityConnector),
                IsPreSelected = true,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = GetLabel(SupportActivities.Shopping),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = GetLabel(SupportActivities.FaceMask),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = GetLabel(SupportActivities.Errands),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = GetLabel(SupportActivities.WellbeingPackage),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = GetLabel(SupportActivities.DogWalking),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = GetLabel(SupportActivities.MealPreparation),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = GetLabel(SupportActivities.PhoneCalls_Friendly),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = GetLabel(SupportActivities.PhoneCalls_Anxious),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = GetLabel(SupportActivities.HomeworkSupport),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = GetLabel(SupportActivities.CheckingIn),
                IsPreSelected = false,
                DisplayOrder = 12
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.HLP,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 13
            });

        }

        private static void SetFtLOSSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = "Supplying reusable homemade face coverings through For the Love of Scrubs",
                IsPreSelected = true,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = GetLabel(SupportActivities.Shopping),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = GetLabel(SupportActivities.Errands),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = GetLabel(SupportActivities.WellbeingPackage),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = GetLabel(SupportActivities.DogWalking),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = GetLabel(SupportActivities.MealPreparation),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = GetLabel(SupportActivities.PhoneCalls_Friendly),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = GetLabel(SupportActivities.PhoneCalls_Anxious),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = GetLabel(SupportActivities.HomeworkSupport),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = GetLabel(SupportActivities.CheckingIn),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 12
            });
        }

        private static void SetFaceMasksSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = "Supplying homemade face coverings",
                IsPreSelected = true,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = GetLabel(SupportActivities.Shopping),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = GetLabel(SupportActivities.Errands),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = GetLabel(SupportActivities.WellbeingPackage),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = GetLabel(SupportActivities.DogWalking),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = GetLabel(SupportActivities.MealPreparation),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = GetLabel(SupportActivities.PhoneCalls_Friendly),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = GetLabel(SupportActivities.PhoneCalls_Anxious),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = GetLabel(SupportActivities.HomeworkSupport),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = GetLabel(SupportActivities.CheckingIn),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 12
            });
        }

        private static void SetAgeUKLSLSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = GetLabel(SupportActivities.WellbeingPackage),
                IsPreSelected = true,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = GetLabel(SupportActivities.Shopping),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = GetLabel(SupportActivities.FaceMask),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = GetLabel(SupportActivities.Errands),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = GetLabel(SupportActivities.DogWalking),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = GetLabel(SupportActivities.MealPreparation),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = GetLabel(SupportActivities.PhoneCalls_Friendly),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = GetLabel(SupportActivities.PhoneCalls_Anxious),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = GetLabel(SupportActivities.HomeworkSupport),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = GetLabel(SupportActivities.CheckingIn),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 12
            });
        }

        private static void SetAgeUKWirralSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = GetLabel(SupportActivities.Shopping),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.ColdWeatherArmy,
                Label = GetLabel(SupportActivities.ColdWeatherArmy),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = GetLabel(SupportActivities.Transport),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = GetLabel(SupportActivities.Errands),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = GetLabel(SupportActivities.DogWalking),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = GetLabel(SupportActivities.PhoneCalls_Friendly),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = GetLabel(SupportActivities.PhoneCalls_Anxious),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 9
            });
        }

        private static void SetAgeUKBaldertonSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = "Picking up groceries and other essentials",
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = GetLabel(SupportActivities.Errands),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = "Walking a calm dog",
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = GetLabel(SupportActivities.MealPreparation),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = "A friendly chat on the phone",
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = GetLabel(SupportActivities.CheckingIn),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 8
            });
        }

        private static void SetAgeUKNWKSupportActivities(EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.MealsToYourDoor,
                Label = "Delivering freshly prepared meal straight to someone’s door",
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = GetLabel(SupportActivities.Transport),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = "Helping with events, admin duties or not-for-profit activities",
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = "A friendly chat on the phone",
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 6
            });
        }

        private static void SetAgeUKSKCSupportActivities(EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = "Picking up groceries and other essentials",
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = "A friendly chat on the phone",
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.MealtimeCompanion,
                Label = "Providing company over a mealtime for someone who lives alone",
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.MealsToYourDoor,
                Label = "Delivering a freshly prepared meal straight to someone’s door",
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = "Helping with events, admin duties or not-for-profit activities",
                IsPreSelected = false,
                DisplayOrder = 6
            });


            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 7
            });
        }

        private static void SetAgeUKFandSSupportActivities(EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = "A friendly chat on the phone",
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.MealtimeCompanion,
                Label = "Providing company over a mealtime for someone who lives alone",
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.MealsToYourDoor,
                Label = "Delivering a freshly prepared meal straight to someone’s door",
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = GetLabel(SupportActivities.Transport),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = "Helping with events, admin duties or not-for-profit activities",
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 6
            });
        }

        private static void SetLincolnshireVolunteersSupportActivities(EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.VaccineSupport,
                Label = "Volunteering to support the COVID-19 vaccination programme (e.g. support staff for local vaccination centres)",
                IsPreSelected = true,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = "Picking up groceries and other essentials (e.g. food, toiletries, household products)",
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = GetLabel(SupportActivities.CollectingPrescriptions),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = GetLabel(SupportActivities.Errands),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = GetLabel(SupportActivities.MealPreparation),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = "A friendly chat on the phone",
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = GetLabel(SupportActivities.CheckingIn),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = GetLabel(SupportActivities.Transport),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.Other,
                Label = GetLabel(SupportActivities.Other),
                IsPreSelected = false,
                DisplayOrder = 9
            });
        }

        public static void SetRegistrationFormSupportActivitiesExtensionsData(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            SetHLPSupportActivities(entity);
            SetFtLOSSupportActivities(entity);
            SetFaceMasksSupportActivities(entity);
            SetAgeUKLSLSupportActivities(entity);
            SetAgeUKWirralSupportActivities(entity);
            SetAgeUKBaldertonSupportActivities(entity);
            SetAgeUKNWKSupportActivities(entity);
            SetAgeUKSKCSupportActivities(entity);
            SetAgeUKFandSSupportActivities(entity);
            SetLincolnshireVolunteersSupportActivities(entity);
        }

        
    }
}
