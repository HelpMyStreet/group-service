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
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.FTLOS,
                GroupName = "For the Love of Scrubs",
                GroupKey = "ftlos",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKLSL,
                GroupName = "Age UK Lincoln & South Lincolnshire",
                GroupKey = "ageuklsl",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.HLP,
                GroupName = "Healthy London Partnership",
                GroupKey = "hlp",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.Tankersley,
                GroupName = "Tankersley & Pilley",
                GroupKey = "tankersley",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.Ruddington,
                GroupName = "Ruddington",
                GroupKey = "ruddington",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKWirral,
                GroupName = "Age UK Wirral",
                GroupKey = "ageukwirral",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNottsBalderton,
                GroupName = "Balderton Community Support",
                GroupKey = "balderton",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNorthWestKent,
                GroupName = "AgeUK North West Kent",
                GroupKey = "ageuknwkent",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKNottsNorthMuskham,
                GroupName = "North Muskham Community Support",
                GroupKey = "north-muskham",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKSouthKentCoast,
                GroupName = "Age UK South Kent Coast",
                GroupKey = "ageuk-southkentcoast",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.AgeUKFavershamAndSittingbourne,
                GroupName = "Age UK Faversham & Sittingbourne",
                GroupKey = "ageuk-favershamandsittingbourne",
                ShiftsEnabled = false
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnshireVolunteers,
                GroupName = "Lincolnshire Volunteers",
                GroupKey = "lincs-volunteers",
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LouthPCN,
                GroupName = "PCN Louth",
                GroupKey = "pcn-louth",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.GranthamPCN,
                GroupName = "PCN Grantham",
                GroupKey = "pcn-grantham",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.SouthLincolnPCN,
                GroupName = "PCN South Lincoln",
                GroupKey = "pcn-southlincoln",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.StamfordPCN,
                GroupName = "PCN Stamford",
                GroupKey = "pcn-stamford",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.SpilsbyPCN,
                GroupName = "PCN Spilsby",
                GroupKey = "pcn-spilsby",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.BostonPCN,
                GroupName = "PCN Boston",
                GroupKey = "pcn-boston",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnPCN,
                GroupName = "APEX PCN",
                GroupKey = "apex-pcn-lincoln",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
            });

            entity.HasData(new Group
            {
                Id = (int)Groups.LincolnPortlandPCN,
                GroupName = "PCN Lincoln Portland",
                GroupKey = "pcn-lincoln-portland",
                ParentGroupId = (int)Groups.LincolnshireVolunteers,
                ShiftsEnabled = true
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
                GroupId = (int)Groups.LouthPCN,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.GranthamPCN,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.SouthLincolnPCN,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.StamfordPCN,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.SpilsbyPCN,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.BostonPCN,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.LincolnPCN,
                Source = REQUEST_SUBMITTER_SOURCE,
                RequestHelpFormVariant = (byte)RequestHelpFormVariant.LincolnshireVolunteers,
                TargetGroups = (byte)TargetGroups.GenericGroup,
                AccessRestrictedByRole = true,
                RequestorDefinedByGroup = true,
                RequestsRequireApproval = false,
            });

            entity.HasData(new RequestHelpJourney
            {
                GroupId = (int)Groups.LincolnPortlandPCN,
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
                GroupId = (int)Groups.LouthPCN,
                FirstName = "Louth Community", //TODO Need to pass the correct details in
                LastName = "Hospital",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Louth County Hospital",
                AddressLine2 = "High Holme Rd",
                AddressLine3 = "Louth",
                Locality = "Lincolnshire",
                Postcode = "LN11 0EU"
            });
            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.GranthamPCN,
                FirstName = "Grantham",//TODO Need to pass the correct details in
                LastName = "PCN",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Grantham Meres Leisure Centre Table Tennis Club",
                AddressLine2 = "Trent Road",
                AddressLine3 = "Grantham",
                Locality = "",
                Postcode = "NG31 7XQ"
            });

            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.SouthLincolnPCN,
                FirstName = "South Lincoln",//TODO Need to pass the correct details in
                LastName = "PCN",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Cliff Villages Medical Practice",
                AddressLine2 = "Mere Rd",
                AddressLine3 = "Waddington",
                Locality = "Lincoln",
                Postcode = "LN5 9NX"
            });

            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.StamfordPCN,
                FirstName = "Stamford",//TODO Need to pass the correct details in
                LastName = "PCN",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Lakeside Healthcare at Stamford",
                AddressLine2 = "Wharf Rd",
                AddressLine3 = "Stamford",
                Locality = "",
                Postcode = "PE9 2DH"
            });

            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.SpilsbyPCN,
                FirstName = "Spilsby",//TODO Need to pass the correct details in
                LastName = "PCN",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Franklin Hall",
                AddressLine2 = "Halton Rd",
                AddressLine3 = "Spilsby",
                Locality = "",
                Postcode = "PE23 5LA"
            });

            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.BostonPCN,
                FirstName = "Boston",//TODO Need to pass the correct details in
                LastName = "PCN",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Sidings Medical Practice",
                AddressLine2 = "14 Sleaford Rd",
                AddressLine3 = "Boston",
                Locality = "",
                Postcode = "PE21 8EG"
            });

            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.LincolnPCN,
                FirstName = "Practice",
                LastName = "Manager",
                OtherPhone = "07340 066491",
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Ruston Sports & Social Club",
                AddressLine2 = "Newark Road",
                AddressLine3 = "Lincoln",
                Locality = "",
                Postcode = "LN6 8RN"
            });

            entity.HasData(new RequestorDetails
            {
                GroupId = (int)Groups.LincolnPortlandPCN,
                FirstName = "Lincoln Portland",//TODO Need to pass the correct details in
                LastName = "PCN",//TODO Need to pass the correct details in
                OtherPhone = "",//TODO Need to pass the correct details in
                EmailAddress = "laura@factor-50.co.uk",//TODO Need to pass the correct details in
                AddressLine1 = "Portland Medical Practice",
                AddressLine2 = "60 Portland St",
                AddressLine3 = "Lincoln",
                Locality = "",
                Postcode = "LN5 7LB"
            });
        }
    }
}
