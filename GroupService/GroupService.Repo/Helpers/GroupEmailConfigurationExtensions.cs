﻿using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Contracts.CommunicationService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using SupportActivityInstructionsEnum = HelpMyStreet.Utils.Enums.SupportActivityInstructions;

namespace GroupService.Repo.Helpers
{
    public static class GroupEmailConfigurationExtensions
    {
        private static List<KeyValuePair<string,string>> GetWelcomeEmailConfiguration_HelpMyStreet()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>HelpMyStreet has partnered with organisations across the country to help make volunteering easier. To find out who we’re working with go to <a href=\"www.helpmystreet.org\">www.helpmystreet.org</a> and search our interactive map.</p>" +
                                                                        $"<p>Most requests will need you to verify your ID before you start helping -  this is to make things as safe as possible for everyone using our site.</p>"
                                                      ));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_FTLOS()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help."));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>For the Love of Scrubs"));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_AgeUKLSL()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"Before you start volunteering with us we need to verify your ID – " +
                $"this is to make things as safe as possible for you and the people we help. You can verify your ID online, " +
                $"or if you’re having trouble email us at <a href=\"mailto:volunteering@ageuklsl.org.uk\">volunteering@ageuklsl.org.uk</a>."));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Age UK Lincoln & South Lincolnshire"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:volunteering@ageuklsl.org.uk\">volunteering@ageuklsl.org.uk</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }


        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Default()
        {
            return GetWelcomeEmailConfiguration_Default(false, string.Empty);
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Default(bool showGroupLogo)
        {
            return GetWelcomeEmailConfiguration_Default(showGroupLogo, string.Empty);
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Default(bool showGroupLogo, string signature)
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", signature));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", showGroupLogo.ToString()));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_HLP()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help."));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Healthy London Partnership"));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Tankersley()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help."));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Tankersley & Pilley Community Helpers"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:tankersley@helpmystreet.org\">tankersley@helpmystreet.org</a>."));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Ruddington()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help."));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Ruddington Community Response Team"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:ruddington@helpmystreet.org\">ruddington@helpmystreet.org</a>."));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_AgeUKWirral()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to do a couple of checks. You will need to verify your ID - which you can do in just a couple of minutes online - and register a DBS check with us. If you’re having trouble verifying your ID or need to register a DBS check email <a href=\"mailto:volunteers@ageukwirral.org.uk\">volunteers@ageukwirral.org.uk</a>.</p>" +
                $"<p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Age UK Wirral"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:ruddington@helpmystreet.org\">ruddington@helpmystreet.org</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Balderton()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Balderton Community Support"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:baldertoncs@helpmystreet.org\">baldertoncs@helpmystreet.org</a>."));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_AgeUKNorthWest()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\"mailto:contactus@ageuknorthwestkent.org.uk\">contactus@ageuknorthwestkent.org.uk</a>.</p>" +
                $"<p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Age UK North West Kent"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:contactus@ageuknorthwestkent.org.uk\">contactus@ageuknorthwestkent.org.uk</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_NorthMuskham()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>" +
                $"<p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>North Muskham Community Support"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:northmuskham@helpmystreet.org.\">northmuskham@helpmystreet.org</a>."));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_AgeUKSouthKent()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\"mailto:contactus@ageukskc.org.uk\">contactus@ageukskc.org.uk</a>.</p>" +
                $"<p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Age UK South Kent Coast"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:contactus@ageukskc.org.uk.\">contactus@ageukskc.org.uk</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_LincolnshireVolunteers()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>The Lincolnshire Volunteers Team"));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_AgeUKFaversham()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help. You can verify your ID online, or if you’re having trouble email us at <a href=\"mailto:volunteering@ageukfaversham.org.uk\">volunteering@ageukfaversham.org.uk</a>.</p>" +
                $"<p>For some activities we will also need a DBS check. Please email us on the email address above to request or register your DBS check.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Age UK Faversham & Sittingbourne"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:volunteering@ageukfaversham.org.uk.\">volunteering@ageukfaversham.org.uk</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Sandbox()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>" +
                $"<p>For some roles, we may also require additional checks or training – we will let you know if any additional checks are needed before you accept a request.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:contact@helpmystreet.org\">contact@helpmystreet.org</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_AgeConnectsCardiff()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID and collect two references – this is to make things as safe as possible for you and the people we help. Your referees need to have known you for at least year, be over 18 and not related to you. Download our references form <a href=\"{{{{BaseUrl}}}}/forms/ageconnect/cardiff/Age-Connects-Cardiff-and-the-Vale-References-Form.docx\">here</a> for more details.</p>" +
                $"<p>We also ask all volunteers to complete our volunteer induction. This is a short web-session which gives us a chance to run through our policies and procedures. It also gives you a chance to meet other volunteers and ask any questions. We will contact you with the next available date when we receive your references. We may also require a DBS check; we’ll be in touch with more information about this if required.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Age Connects Cardiff & the Vale"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:info@ageconnectscardiff.org.uk\">info@ageconnectscardiff.org.uk</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Meadows()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID – this is to make things as safe as possible for you and the people we help.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>The Meadows Community Helpers"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:meadows-community-helpers@helpmystreet.org\">meadows-community-helpers@helpmystreet.org</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Southwell()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to verify your ID and ensure you consent to our volunteer agreement – this is to make things as safe as possible for you and the people we help.</p>" +
                $"<p>Please read the public documents found on our website (<a href=\"https://www.thetorpedos.org/publicdocuments\">here</a>) and drop us an email at <a href=\"mailto:info@thetorpedos.org\">info@thetorpedos.org</a> to confirm you’ve read and agree to our policies and volunteer agreement.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Southwell Torpedos"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:info@thetorpedos.org\">info@thetorpedos.org</a>."));
            config.Add(new KeyValuePair<string, string>("ShowGroupLogo", "true"));
            return config;
        }


        public static void PopulateGroupEmailConfiguration(this EntityTypeBuilder<GroupEmailConfiguration> entity)
        {
            Populate(entity, Groups.Generic, GetWelcomeEmailConfiguration_HelpMyStreet());
            Populate(entity, Groups.FTLOS, GetWelcomeEmailConfiguration_FTLOS());
            Populate(entity, Groups.AgeUKLSL, GetWelcomeEmailConfiguration_AgeUKLSL());
            Populate(entity, Groups.HLP, GetWelcomeEmailConfiguration_HLP());
            Populate(entity, Groups.Tankersley, GetWelcomeEmailConfiguration_Tankersley());
            Populate(entity, Groups.Ruddington, GetWelcomeEmailConfiguration_Ruddington());
            Populate(entity, Groups.AgeUKWirral, GetWelcomeEmailConfiguration_AgeUKWirral());
            Populate(entity, Groups.AgeUKNottsBalderton, GetWelcomeEmailConfiguration_Balderton());
            Populate(entity, Groups.AgeUKNorthWestKent, GetWelcomeEmailConfiguration_AgeUKNorthWest());
            Populate(entity, Groups.AgeUKNottsNorthMuskham, GetWelcomeEmailConfiguration_NorthMuskham());
            Populate(entity, Groups.AgeUKSouthKentCoast, GetWelcomeEmailConfiguration_AgeUKSouthKent());
            Populate(entity, Groups.LincolnshireVolunteers, GetWelcomeEmailConfiguration_LincolnshireVolunteers());
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, GetWelcomeEmailConfiguration_AgeUKFaversham());
            Populate(entity, Groups.EastLindseyPCN, GetWelcomeEmailConfiguration_Default(true));
            Populate(entity, Groups.GranthamPCN, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.SouthLincolnPCN, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.StamfordPCN, GetWelcomeEmailConfiguration_Default(true));
            Populate(entity, Groups.SpilsbyPCN, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.BostonPCN, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.LincolnPCN, GetWelcomeEmailConfiguration_Default(true));
            Populate(entity, Groups.LincolnPortlandPCN, GetWelcomeEmailConfiguration_Default(true));
            Populate(entity, Groups.Sandbox, GetWelcomeEmailConfiguration_Sandbox());
            Populate(entity, Groups.AgeConnectsCardiff, GetWelcomeEmailConfiguration_AgeConnectsCardiff());
            Populate(entity, Groups.MeadowsCommunityHelpers, GetWelcomeEmailConfiguration_Meadows());
            Populate(entity, Groups.MansfieldCVS, GetWelcomeEmailConfiguration_Default(true, "Best wishes,</p><p>Mansfield CVS</p>"));
            Populate(entity, Groups.GamstonCommunityHall, GetWelcomeEmailConfiguration_Default(true, "Best wishes,</p><p>Mansfield CVS</p>"));
            Populate(entity, Groups.RichardHerrodCentre, GetWelcomeEmailConfiguration_Default(true, "Best wishes,</p><p>Mansfield CVS</p>"));
            Populate(entity, Groups.KingsMeadowCampus, GetWelcomeEmailConfiguration_Default(true, "Best wishes,</p><p>Mansfield CVS</p>"));
            Populate(entity, Groups.ForestRecreationGround, GetWelcomeEmailConfiguration_Default(true, "Best wishes,</p><p>Mansfield CVS</p>"));
            Populate(entity, Groups.Southwell, GetWelcomeEmailConfiguration_Southwell());
        }

        private static void Populate(this EntityTypeBuilder<GroupEmailConfiguration> entity, Groups group, List<KeyValuePair<string, string>> keyValuePairs)
        {
            entity.HasData(new GroupEmailConfiguration
            {
                GroupId = (int)group,
                CommunicationJobTypeId = (byte) CommunicationJobTypes.GroupWelcome,
                Configuration = JsonConvert.SerializeObject(keyValuePairs)
            });
        }
    }
}
