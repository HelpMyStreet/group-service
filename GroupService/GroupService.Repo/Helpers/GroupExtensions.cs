﻿using GroupService.Repo.EntityFramework.Entities;
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
                Id = (int)Groups.FTLOS,
                GroupName = "For the Love of Scrubs",
                GroupKey = "ftlos",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GroupType = (byte)GroupTypes.National,
                FriendlyName = "For the Love of Scrubs",
                ShortName = "FTLOS"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKLSL,
                GroupName = "Age UK Lincoln & South Lincolnshire",
                GroupKey = "ageuklsl",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GroupType = (byte)GroupTypes.Regional,
                FriendlyName = "Age UK Lincoln & South Lincolnshire",
                LinkURL = "/ageuklsl",
                ShortName = "Age UK LSL"
            });            

            entity.HasData(new Group
            {
                Id = (int)Groups.Tankersley,
                GroupName = "Tankersley & Pilley",
                GroupKey = "tankersley",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Tankersley or Pilley",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Tankersley & Pilley Community Helpers",
                LinkURL = "/tankersley",
                ShortName = "Tankersley"
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
                Id = (int)Groups.AgeUKNottsBalderton,
                GroupName = "Balderton Community Support",
                GroupKey = "balderton",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Balderton",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Balderton Community Support",
                LinkURL = "/balderton",
                ShortName = "Balderton"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNorthWestKent,
                GroupName = "Age UK North West Kent",
                GroupKey = "ageuknwkent",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "North West Kent (Dartford, Swanley or Gravesend)",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Age UK North West Kent",
                LinkURL = "/northwestkent",
                ShortName = "Age UK NW Kent"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNottsNorthMuskham,
                GroupName = "North Muskham Community Support",
                GroupKey = "north-muskham",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "North Muskham",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "North Muskham Community Support",
                LinkURL = "/north-muskham",
                ShortName = "North Muskham"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKSouthKentCoast,
                GroupName = "Age UK South Kent Coast",
                GroupKey = "ageuk-southkentcoast",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Deal or Folkestone",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Age UK South Kent Coast",
                LinkURL = "/southkentcoast",
                ShortName = "South Kent Coast"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKFavershamAndSittingbourne,
                GroupName = "Age UK Faversham & Sittingbourne",
                GroupKey = "ageuk-favershamandsittingbourne",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Faversham or Sittingbourne",
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "Age UK Faversham & Sittingbourne",
                LinkURL = "/favershamandsittingbourne",
                ShortName = "Faversham & Sittingbourne"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnshireVolunteers,
                GroupName = "Lincolnshire Volunteers",
                GroupKey = "lincs-volunteers",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Lincolnshire Volunteers",
                GroupType = (byte)GroupTypes.Regional,
                FriendlyName = "Lincolnshire Volunteers",
                LinkURL = "/lincolnshirevolunteers",
                ShortName = "Lincs Vols"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.EastLindseyPCN,
                GroupName = "East Lindsey PCN",
                GroupKey = "east-lindsey-pcn",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true,
                TasksEnabled = false,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.Local
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.StamfordPCN,
                GroupName = "Four Counties PCN",
                GroupKey = "four-counties-pcn",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true,
                TasksEnabled = false,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.Local
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnPCN,
                GroupName = "APEX PCN",
                GroupKey = "apex-pcn-lincoln",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true,
                TasksEnabled = false,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.Local
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
                Id = (int)Groups.AgeConnectsCardiff,
                GroupName = "Age Connects Cardiff & the Vale",
                GroupKey = "ageconnects-cardiff",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                GeographicName = "Cardiff & the Vale",
                GroupType = (byte)GroupTypes.Regional,
                FriendlyName = "Age Connects Cardiff & the Vale",
                LinkURL = "/ageconnects-cardiff",
                ShortName = "Age Connects Cardiff",
                JoinGroupPopUpDetail = "Age Connects Cardiff & the Vale require two references, an Induction Session and (in most cases) a DBS check before you can start volunteering." + Environment.NewLine + Environment.NewLine + "You will also be expected to make a minimum commitment of six months."
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

            entity.HasData(new Group
            {
                Id = (int)Groups.ApexBankStaff,
                GroupName = "APEX PCN Bank Staff",
                GroupKey = "apex-pcn-bank-staff",
                ShiftsEnabled = true,
                TasksEnabled = false,
                HomepageEnabled = true,
                FriendlyName = "Apex PCN Bank Staff",
                LinkURL = "/apexpcnbankstaff",
                ShortName = "Apex Bank Staff"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKMidMersey,
                GroupName = "Age UK Mid Mersey",
                GroupKey = "ageuk-midmersey",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                FriendlyName = "Age UK Mid Mersey",
                LinkURL = "/ageukmidmersey",
                ShortName = "Age UK MM",
                GeographicName = "St Helens, Halton, Knowsley and Warrington",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.BostonGNS,
                GroupName = "Boston and Surrounding Areas",
                GroupKey = "boston",
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = true,
                FriendlyName = "Boston and Surrounding Areas",
                LinkURL = "/boston",
                ShortName = "Boston",
                GeographicName = "Boston or surrounding areas",
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnshireLCVS,
                GroupName = "LCVS",
                GroupKey = "lincolnshire-lcvs",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "LCVS",
                LinkURL = "/lincolnshire-lcvs",
                ShortName = "LCVS"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnshireVCS,
                GroupName = "VCS",
                GroupKey = "lincolnshire-vcs",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = false,
                TasksEnabled = true,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.Local,
                FriendlyName = "VCS",
                LinkURL = "/lincolnshire-vcs",
                ShortName = "VCS"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.NHSVRDemo,
                GroupName = "NHSVR Demo",
                GroupKey = "nhsvr-demo",
                ShiftsEnabled = true,
                TasksEnabled = true,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.National
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.NottinghamshireCountyCouncil,
                GroupName = "Nottinghamshire County Council",
                GroupKey = "nhsvr-group1",
                ParentGroupId = (int)Groups.NHSVRDemo,
                ShiftsEnabled = true,
                TasksEnabled = true,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.Local
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.NottinghamshireIntegratedCareBoard,
                GroupName = "NHS Nottingham & Nottinghamshire Integrated Care Board",
                GroupKey = "nhsvr-group2",
                ParentGroupId = (int)Groups.NHSVRDemo,
                ShiftsEnabled = true,
                TasksEnabled = true,
                HomepageEnabled = false,
                GroupType = (byte)GroupTypes.Regional
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
                GroupId = (int)Groups.FTLOS,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.FtLOS,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKLSL,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKLSL,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });
            
            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Tankersley,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Default,
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
                GroupId = (int)Groups.AgeUKNottsBalderton,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKNWK,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKNottsNorthMuskham,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKNottsBalderton,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKSKC,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKFandS,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.LincolnshireVolunteers,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeConnectsCardiff,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeConnectsCardiff,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.Southwell,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.Southwell,
                TargetGroups = (byte)TargetGroups.ThisGroupAndGenericGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.ApexBankStaff,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.ApexBankStaff,
                TargetGroups = (byte)TargetGroups.ThisGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKMidMersey,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKMidMersey,
                TargetGroups = (byte)TargetGroups.ThisGroup
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.BostonGNS,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.BostonGNS,
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
