using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace GroupService.Repo.Helpers
{
    public static class GroupExtensions
    {

        private const string REQUEST_SUBMITTER_SOURCE = "a";

        public static void SetDefaultGroup(this EntityTypeBuilder<Group> entity)
        {
            entity.HasData(new Group
            {
                Id = (int)Groups.Generic,
                GroupName = "HelpMyStreet",
                GroupKey = "Generic",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.HelpMyStreet,
                ShortName = "HelpMyStreet"
            });           

            entity.HasData(new Group
            {
                Id = (int)Groups.Ruddington,
                GroupName = "Ruddington",
                GroupKey = "ruddington",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Ruddington",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Ruddington Community Response Team",
                LinkURL = "/ruddington",
                ShortName = "Ruddington"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKWirral,
                GroupName = "Age UK Wirral",
                GroupKey = "ageukwirral",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Age UK Wirral",
                LinkURL = "/ageukwirral",
                ShortName = "Wirral"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.Sandbox,
                GroupName = "Sandbox",
                GroupKey = "hms-sandbox",
                ShiftsEnabled = true,
                TasksEnabled = true,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.National
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.Southwell,
                GroupName = "Southwell Torpedos",
                GroupKey = "southwell",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Southwell or surrounding areas",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Southwell Torpedos",
                LinkURL = "/southwell",
                ShortName = "Southwell"
            });           
        }

        public static void RegistrationJourney(this EntityTypeBuilder<RegistrationJourney> entity)
        {
            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Generic,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Default,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup

            });

            entity.HasData(new RegistrationJourney

            {
                GroupId = (int)Groups.Generic,
                Source = "face-masks",
                RegistrationFormVariant = (byte)RegistrationFormVariant.FaceMasks,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });
            
            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Ruddington,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Ruddington,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKWirral,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKWirral,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Southwell,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Southwell,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });
        }

        public static void RequestHelpJourney(this EntityTypeBuilder<RequestHelpJourney> entity)
        {
            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Generic,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Default,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
                SuppressRecipientPersonalDetails = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Generic,
                Source = "face-masks",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.FaceMasks,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
                SuppressRecipientPersonalDetails = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Ruddington,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Ruddington,
                TargetGroups = (byte)TargetGroups.ThisGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
                SuppressRecipientPersonalDetails = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKWirral,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKWirral,
                TargetGroups = (byte)TargetGroups.ThisGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
                SuppressRecipientPersonalDetails = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Sandbox,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Sandbox_RequestSubmitter,
                TargetGroups = (byte)TargetGroups.ThisGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
                SuppressRecipientPersonalDetails = false
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Southwell,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Soutwell_Public,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
                SuppressRecipientPersonalDetails = false
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
                EmailAddress = "practicalsupportteam@ageukwirral.org.uk",
                AddressLine1 = "Age UK Wirral",
                AddressLine2 = "Devonshire Resource Centre",
                AddressLine3 = "141 Park Road North",
                Locality = "Birkenhead",
                Postcode = "CH41 0DD"
            });            
        }

        public static void AddGroupMapDetails(this EntityTypeBuilder<GroupMapDetails> entity)
        {
            entity.HasData(new GroupMapDetails
            {
                MapLocationId = (byte)MapLocation.Landing,
                GroupId = (int)Groups.Ruddington,
                Latitude = 52.8925M,
                Longitude = -1.150M,
                ZoomLevel = 14.6M
            });

            entity.HasData(new GroupMapDetails
            {
                MapLocationId = (byte)MapLocation.HomePage,
                GroupId = (int)Groups.Ruddington,
                Latitude = 52.8925M,
                Longitude = -1.150M,
                ZoomLevel = 14.6M
            });

            entity.HasData(new GroupMapDetails
            {
                MapLocationId = (byte)MapLocation.HomePage,
                GroupId = (int)Groups.AgeUKWirral,
                Latitude = 53.37M,
                Longitude = -3.05M,
                ZoomLevel = 9M
            });

            entity.HasData(new GroupMapDetails
            {
                MapLocationId = (byte)MapLocation.Landing,
                GroupId = (int)Groups.AgeUKWirral,
                Latitude = 53.37M,
                Longitude = -3.05M,
                ZoomLevel = 11.15M
            });

            entity.HasData(new GroupMapDetails
            {
                MapLocationId = (byte)MapLocation.Landing,
                GroupId = (int)Groups.Southwell,
                Latitude = 53.0779128M,
                Longitude = -0.973649M,
                ZoomLevel = 13.5M
            });
        }
    }
}
