using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
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

            entity.HasData(new Group
            {
                Id = (int)-2,
                GroupName = "For the Love of Scrubs",
                GroupKey = "ftlos"
            });

            entity.HasData(new Group
            {
                Id = (int)-3,
                GroupName = "Age UK Lincoln & South Lincolnshire",
                GroupKey = "ageuklsl"
            });

            entity.HasData(new Group
            {
                Id = (int)-4,
                GroupName = "Healthy London Partnership",
                GroupKey = "hlp"
            });

            entity.HasData(new Group
            {
                Id = (int)-5,
                GroupName = "Tankersley & Pilley",
                GroupKey = "tankersley"
            });
        }

        public static void RegistrationJourney(this EntityTypeBuilder<RegistrationJourney> entity)
        {
            entity.HasData(new RegistrationJourney
            {
                GroupId = -1,
                Source = "",
                RegistrationFormVariant = (byte) RegistrationFormVariant.Default

            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = -1,
                Source = "face-masks",
                RegistrationFormVariant = (byte)RegistrationFormVariant.FaceMasks
            });


            entity.HasData(new RegistrationJourney
            {
                GroupId = -2,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.FtLOS
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = -3,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKLSL
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = -4,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.HLP
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = -5,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Default
            });
        }

        public static void RequestHelpJourney(this EntityTypeBuilder<RequestHelpJourney> entity)
        {
            entity.HasData(new RequestHelpJourney
            {
                GroupId = -1,
                Source = "DIY",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.DIY,
                TargetGroups = (byte)TargetGroups.GenericGroup,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = -1,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Default,
                TargetGroups = (byte)TargetGroups.GenericGroup,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = -1,
                Source = "face-masks",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.FaceMasks,
                TargetGroups = (byte)TargetGroups.GenericGroup,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = -2,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.FtLOS,
                TargetGroups = (byte)TargetGroups.ThisGroupAndChildren,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = -3,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.VitalsForVeterans,
                TargetGroups = (byte)TargetGroups.GenericGroup,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = -4,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Default,
                TargetGroups = (byte)TargetGroups.ThisGroup,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = -5,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Default,
                TargetGroups = (byte)TargetGroups.GenericGroup,
            });
        }
    }
}
