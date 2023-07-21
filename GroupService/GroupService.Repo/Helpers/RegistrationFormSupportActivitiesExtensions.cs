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
                SupportActivities.Accommodation => "Providing accommodation",
                SupportActivities.AdvertisingRoles => "Longer-term volunteering opportunities",
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

        public static void SetRegistrationFormSupportActivitiesExtensionsData(this EntityTypeBuilder<RegistrationFormSupportActivity> entity)
        {
            SetDefaultSupportActivities(entity);            
            SetAgeUKWirralSupportActivities(entity);            
            SetRuddingtonSupportActivities(entity);
            SetSouthwellActivities(entity);
        }        

    }
}
