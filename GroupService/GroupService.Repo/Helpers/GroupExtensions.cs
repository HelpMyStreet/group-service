using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GroupService.Repo.Helpers
{
    public static class GroupExtensions
    {
        public static void SetDefaultGroup(this EntityTypeBuilder<Group> entity)
        {
            entity.HasData(new Group
            {
                Id = (int)Groups.Generic,
                GroupName = "HelpMyStreet",
                GroupKey = "Generic",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.FTLOS,
                GroupName = "For the Love of Scrubs",
                GroupKey = "ftlos",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKLSL,
                GroupName = "Age UK Lincoln & South Lincolnshire",
                GroupKey = "ageuklsl",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.HLP,
                GroupName = "Healthy London Partnership",
                GroupKey = "hlp",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.Tankersley,
                GroupName = "Tankersley & Pilley",
                GroupKey = "tankersley",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.Ruddington,
                GroupName = "Ruddington",
                GroupKey = "ruddington",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKWirral,
                GroupName = "Age UK Wirral",
                GroupKey = "ageukwirral",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNottsBalderton,
                GroupName = "Balderton Community Support",
                GroupKey = "balderton"
            });
        }

        public static void RegistrationJourney(this EntityTypeBuilder<RegistrationJourney> entity)
        {
            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Generic,
                Source = "",
                RegistrationFormVariant = (byte) RegistrationFormVariant.Default

            });

            entity.HasData(new RegistrationJourney

            {
                GroupId = (int)Groups.Generic,
                Source = "face-masks",
                RegistrationFormVariant = (byte)RegistrationFormVariant.FaceMasks
            });


            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.FTLOS,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.FtLOS
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKLSL,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKLSL
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.HLP,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.HLP
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Tankersley,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Default
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Ruddington,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Default
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKWirral,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKWirral
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKNottsBalderton,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKNottsBalderton
            });
        }

        public static void RequestHelpJourney(this EntityTypeBuilder<RequestHelpJourney> entity)
        {
            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Generic,
                Source = "DIY",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.DIY,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Generic,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Default,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Generic,
                Source = "face-masks",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.FaceMasks,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.FTLOS,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.FtLOS,
                TargetGroups = (byte)TargetGroups.ThisGroupAndChildren,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKLSL,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.VitalsForVeterans,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.HLP,
                Source = "connected-together-service-directory",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.HLP_CommunityConnector,
                TargetGroups = (byte)TargetGroups.ThisGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Tankersley,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Default,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Ruddington,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Ruddington,
                TargetGroups = (byte)TargetGroups.ThisGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKWirral,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKWirral,
                TargetGroups = (byte)TargetGroups.ThisGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKNottsBalderton,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKNottsBalderton,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false
            });
        }

        public static void RequestorDetails(this EntityTypeBuilder<RequestorDetails> entity)
        {
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.AgeUKWirral,
                FirstName = "Age UK",
                LastName = "Wirral",
                OtherPhone = "0151 482 3456",
                EmailAddress = "h&cadminteam@ageukwirral.org.uk",
                AddressLine1 = "Age UK Wirral",
                AddressLine2 = "Devonshire Resource Centre",
                AddressLine3 = "141 Park Road North",
                Locality = "Birkenhead",
                Postcode = "CH41 0DD"
            });
        }
    }
}
