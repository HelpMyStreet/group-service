using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNorthWestKent,
                GroupName = "AgeUK North West Kent",
                GroupKey = "ageuknwkent"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNottsNorthMuskham,
                GroupName = "North Muskham Community Support",
                GroupKey = "north-muskham"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKSouthKentCoast,
                GroupName = "Age UK South Kent Coast",
                GroupKey = "ageuk-southkentcoast"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKFavershamAndSittingbourne,
                GroupName = "Age UK Faversham & Sittingbourne",
                GroupKey = "ageuk-favershamandsittingbourne"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnshireVolunteers,
                GroupName = "Lincolnshire Volunteers",
                GroupKey = "lincs-volunteers"
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.PilgramHospitalBolton,
                GroupName = "Pilgram Hospital Boston",
                GroupKey = "boston-pilgramhospital",
                ParentGroupId = (int)Groups.LincolnshireVolunteers
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnCountyHospital,
                GroupName = "Lincoln County Hospital",
                GroupKey = "lincs-countyhospital",
                ParentGroupId = (int)Groups.LincolnshireVolunteers
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

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKNWK
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKNottsNorthMuskham,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKNottsBalderton
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKSKC
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.AgeUKFandS
            });

            entity.HasData(new RegistrationJourney
            {
                GroupId = (int)Groups.LincolnshireVolunteers,
                Source = "",
                RegistrationFormVariant = (byte)RegistrationFormVariant.LincolnshireVolunteers
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
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.FTLOS,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.FtLOS,
                TargetGroups = (byte)TargetGroups.ThisGroupAndChildren,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKLSL,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.VitalsForVeterans,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.HLP,
                Source = "connected-together-service-directory",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.HLP_CommunityConnector,
                TargetGroups = (byte)TargetGroups.ThisGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.Tankersley,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.Default,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
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
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKNottsBalderton,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKNottsBalderton,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKNorthWestKent_Public,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = true,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKNorthWestKent_RequestSubmitter,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKNottsNorthMuskham,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKNottsNorthMuskham,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKSouthKentCoast_Public,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = true,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKSouthKentCoast_RequestSubmitter,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                Source = "",
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKFavershamAndSittingbourne_Public,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = false,
                RequestorDefinedByGroup = false,
                RequestsRequireApproval = true,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.AgeUKFavershamAndSittingbourne_RequestSubmitter,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.PilgramHospitalBolton,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.LincolnCountyHospital,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
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
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.AgeUKLSL,
                FirstName = "Age UK",
                LastName = "Lincoln & South Lincolnshire",
                OtherPhone = "03455 564 144",
                EmailAddress = "volunteering@ageuklsl.org.uk",
                AddressLine1 = "Age UK Lincoln & South Lincolnshire",
                AddressLine2 = "36 Park Street",
                AddressLine3 = "",
                Locality = "Lincoln",
                Postcode = "LN1 1UQ"
            });
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                FirstName = "Age UK",
                LastName = "South Kent Coast",
                OtherPhone = "01304 372608",
                EmailAddress = "volunteering@ageukskc.org.uk",
                AddressLine1 = "Age UK South Kent Coast",
                AddressLine2 = "3 Park Street",
                AddressLine3 = "Deal",
                Locality = "Kent",
                Postcode = "CT14 6AG"
            });
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                FirstName = "Age UK",
                LastName = "North West Kent",
                OtherPhone = "01474 564898",
                EmailAddress = "contactus@ageuknorthwestkent.org.uk",
                AddressLine1 = "Age UK North West Kent",
                AddressLine2 = "The Fleming Resource Centre",
                AddressLine3 = "Gravesend",
                Locality = "Kent",
                Postcode = "DA12 1HJ"
            });
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                FirstName = "Age UK",
                LastName = "Faversham and Sittingbourne",
                OtherPhone = "01795 532766",
                EmailAddress = "volunteering@ageukfaversham.org.uk",
                AddressLine1 = "Age UK Faversham and Sittingbourne",
                AddressLine2 = "The Old Fire Station",
                AddressLine3 = "Crescent Rd",
                Locality = "Faversham",
                Postcode = "ME13 7GU"
            });
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.LincolnCountyHospital,
                FirstName = "Lincoln County", //TODO Need to pass the correct details in
                LastName = "Hospital",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "jawwad@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Lincoln County Hospital",
                AddressLine2 = "Greetwell Road",
                AddressLine3 = "Lincoln",
                Locality = "Lincolnshire",
                Postcode = "LN2 5QY"
            });
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.PilgramHospitalBolton,
                FirstName = "Pilgram Hospital",//TODO Need to pass the correct details in
                LastName = "Boston",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "jawwad@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Pilgram Hospital",
                AddressLine2 = "Sibsey Road",
                AddressLine3 = "Boston",
                Locality = "Lincolnshire",
                Postcode = "PE21 9QS"
            });
        }
    }
}
