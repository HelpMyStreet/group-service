using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class RegistrationFormSupportActivitiesExtensions
    {
        private static string GetLabel(this SupportActivities activity)
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
                SupportActivities.VolunteerSupport => "Helping with events, admin duties or not-for-profit activities",
                SupportActivities.EmergencySupport => "Providing help in emergency situations (e.g. extreme weather)",
                //SupportActivities.VaccineSupport => "Vaccine Support",
                SupportActivities.InPersonBefriending => "In-person befriending (when restrictions allow)",
                SupportActivities.PracticalSupport => "Providing help with everyday practical tasks (e.g. changing a lightbulb, filling in forms etc.)",
                SupportActivities.BinDayAssistance => "Taking out the bins on bin day",
                SupportActivities.Covid19Help => "Providing help booking COVID-19 tests or vaccination appointments",
                SupportActivities.DigitalSupport => "Providing digital support for people struggling with technology",
                SupportActivities.BankStaffVaccinator => "Covering bank staff vaccinator shifts (this is a paid role)",
                SupportActivities.SkillShare => "Giving my time to share my skills and interests with other people who are interested to learn more",
                SupportActivities.BreakfastVisit => "Breakfast visit",
                SupportActivities.LunchVisit => "Lunch visit",
                SupportActivities.MedicationCheckIn => "Medication check-in",
                SupportActivities.WellBeingVisit => "Wellbeing visit",
                _ => throw new ArgumentException(message: $"Unexpected SupportActivity: {activity}", paramName: nameof(activity))
            };
        }

        private static void SetDefaultSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = SupportActivities.FaceMask.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = SupportActivities.WellbeingPackage.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = SupportActivities.MealPreparation.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = SupportActivities.PhoneCalls_Anxious.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = SupportActivities.HomeworkSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Default,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 12
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
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = SupportActivities.WellbeingPackage.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = SupportActivities.MealPreparation.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = SupportActivities.PhoneCalls_Anxious.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = SupportActivities.HomeworkSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FtLOS,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
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
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = SupportActivities.WellbeingPackage.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = SupportActivities.MealPreparation.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = SupportActivities.PhoneCalls_Anxious.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = SupportActivities.HomeworkSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.FaceMasks,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
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
                Label = SupportActivities.WellbeingPackage.GetLabel(),
                IsPreSelected = true,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = SupportActivities.FaceMask.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = SupportActivities.MealPreparation.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = SupportActivities.PhoneCalls_Anxious.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = SupportActivities.HomeworkSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 12
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKLSL,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 13
            });
        }

        private static void SetAgeUKWirralSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.ColdWeatherArmy,
                Label = SupportActivities.ColdWeatherArmy.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = SupportActivities.Transport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = SupportActivities.PhoneCalls_Anxious.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKWirral,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
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
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
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
                Label = SupportActivities.MealPreparation.GetLabel(),
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
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
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
                Label = SupportActivities.Transport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKNWK,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
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
                Label = SupportActivities.Other.GetLabel(),
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
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
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
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });


            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKSKC,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
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
                Label = SupportActivities.Transport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKFandS,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
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
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = SupportActivities.MealPreparation.GetLabel(),
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
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = SupportActivities.Transport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            //entity.HasData(new RegistrationFormSupportActivity
            //{
            //    RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
            //    SupportActivityId = (int)SupportActivities.EmergencySupport,
            //    Label = SupportActivities.EmergencySupport.GetLabel(),
            //    IsPreSelected = false,
            //    DisplayOrder = 10
            //});


            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });
        }

        private static void SetRuddingtonSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = true,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = SupportActivities.FaceMask.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = SupportActivities.WellbeingPackage.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.MealPreparation,
                Label = SupportActivities.MealPreparation.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Anxious,
                Label = SupportActivities.PhoneCalls_Anxious.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.HomeworkSupport,
                Label = SupportActivities.HomeworkSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 12
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Ruddington,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 13
            });
        }

        private static void SetCardiffSupportActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.InPersonBefriending,
                Label = SupportActivities.InPersonBefriending.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.EmergencySupport,
                Label = SupportActivities.EmergencySupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = SupportActivities.Transport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.PracticalSupport,
                Label = SupportActivities.PracticalSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });
        }

        private static void SetMeadowCommunityHelpersActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.FaceMask,
                Label = SupportActivities.FaceMask.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.DigitalSupport,
                Label = SupportActivities.DigitalSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.BinDayAssistance,
                Label = SupportActivities.BinDayAssistance.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.Covid19Help,
                Label = SupportActivities.Covid19Help.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MeadowsCommunityHelpers,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });


        }

        private static void SetSouthwellActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Southwell,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Southwell,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });


            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Southwell,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });


            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Southwell,
                SupportActivityId = (int)SupportActivities.BinDayAssistance,
                Label = SupportActivities.BinDayAssistance.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });


            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.Southwell,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

        }

        private static void SetApexBankStaffActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.ApexBankStaff,
                SupportActivityId = (int)SupportActivities.BankStaffVaccinator,
                Label = SupportActivities.BankStaffVaccinator.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.ApexBankStaff,
                SupportActivityId = (int)SupportActivities.Other,
                Label = "Please notify me about any other roles (including unpaid volunteer roles)",
                IsPreSelected = false,
                DisplayOrder = 2
            });
        }

        private static void SetAgeUKMidMerseyActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.Errands,
                Label = SupportActivities.Errands.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.InPersonBefriending,
                Label = SupportActivities.InPersonBefriending.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.CheckingIn,
                Label = SupportActivities.CheckingIn.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.BinDayAssistance,
                Label = SupportActivities.BinDayAssistance.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 8
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.PracticalSupport,
                Label = SupportActivities.PracticalSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 9
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.Covid19Help,
                Label = SupportActivities.Covid19Help.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 10
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.DigitalSupport,
                Label = SupportActivities.DigitalSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 11
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.WellbeingPackage,
                Label = SupportActivities.WellbeingPackage.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 12
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.Transport,
                Label = SupportActivities.Transport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 13
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.VolunteerSupport,
                Label = SupportActivities.VolunteerSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 14
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.EmergencySupport,
                Label = SupportActivities.EmergencySupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 15
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.SkillShare,
                Label = SupportActivities.SkillShare.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 16
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.AgeUKMidMersey,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 17
            });


        }

        private static void SetMansfieldCVSActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.MansfieldCVS,
                SupportActivityId = (int)SupportActivities.VaccineSupport,
                Label = "Volunteering to support the COVID-19 vaccination programme (e.g. support staff for local vaccination centres)",
                IsPreSelected = true,
                DisplayOrder = 1
            });
        }

        private static void SetBostonGNSActivities(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.BostonGNS,
                SupportActivityId = (int)SupportActivities.Shopping,
                Label = SupportActivities.Shopping.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 1
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.BostonGNS,
                SupportActivityId = (int)SupportActivities.PhoneCalls_Friendly,
                Label = SupportActivities.PhoneCalls_Friendly.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 2
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.BostonGNS,
                SupportActivityId = (int)SupportActivities.CollectingPrescriptions,
                Label = SupportActivities.CollectingPrescriptions.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 3
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.BostonGNS,
                SupportActivityId = (int)SupportActivities.PracticalSupport,
                Label = SupportActivities.PracticalSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 4
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.BostonGNS,
                SupportActivityId = (int)SupportActivities.DogWalking,
                Label = SupportActivities.DogWalking.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 5
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.BostonGNS,
                SupportActivityId = (int)SupportActivities.DigitalSupport,
                Label = SupportActivities.DigitalSupport.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 6
            });

            entity.HasData(new RegistrationFormSupportActivity
            {
                RequestHelpFormVariantId = (byte)RegistrationFormVariant.BostonGNS,
                SupportActivityId = (int)SupportActivities.Other,
                Label = SupportActivities.Other.GetLabel(),
                IsPreSelected = false,
                DisplayOrder = 7
            });
        }
        public static void SetRegistrationFormSupportActivitiesExtensionsData(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            SetDefaultSupportActivities(entity);
            SetFtLOSSupportActivities(entity);
            SetFaceMasksSupportActivities(entity);
            SetAgeUKLSLSupportActivities(entity);
            SetAgeUKWirralSupportActivities(entity);
            SetAgeUKBaldertonSupportActivities(entity);
            SetAgeUKNWKSupportActivities(entity);
            SetAgeUKSKCSupportActivities(entity);
            SetAgeUKFandSSupportActivities(entity);
            SetLincolnshireVolunteersSupportActivities(entity);
            SetRuddingtonSupportActivities(entity);
            SetCardiffSupportActivities(entity);
            SetMeadowCommunityHelpersActivities(entity);
            SetMansfieldCVSActivities(entity);
            SetSouthwellActivities(entity);
            SetApexBankStaffActivities(entity);
            SetAgeUKMidMerseyActivities(entity);
            SetBostonGNSActivities(entity);
        }        

    }
}
