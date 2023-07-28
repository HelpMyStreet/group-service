using GroupService.Repo.EntityFramework.Entities;
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
        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_HelpMyStreet()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>HelpMyStreet has partnered with organisations across the country to help make volunteering easier. To find out who we’re working with go to <a href=\"www.helpmystreet.org\">www.helpmystreet.org</a> and search our interactive map.</p>" +
                                                                        $"<p>Most requests will need you to verify your ID before you start helping -  this is to make things as safe as possible for everyone using our site.</p>"
                                                      ));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
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
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>Before you start volunteering with us we need to do a couple of checks. You will need to verify your ID - which you can do in just a couple of minutes online - and register a DBS check with us. If you’re having trouble verifying your ID or need to register a DBS check email <a href=\"mailto:volunteers@ageukwirral.org.uk\">volunteers@ageukwirral.org.uk</a>.</p>"));
            config.Add(new KeyValuePair<string, string>("GroupSignature", "Best wishes,</p><p>Age UK Wirral"));
            config.Add(new KeyValuePair<string, string>("GroupPS", "Questions? Drop us an email at <a href=\"mailto:volunteers@ageukwirral.org.uk\">volunteers@ageukwirral.org.uk</a>."));
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
            Populate(entity, Groups.Ruddington, GetWelcomeEmailConfiguration_Ruddington());
            Populate(entity, Groups.AgeUKWirral, GetWelcomeEmailConfiguration_AgeUKWirral());
            Populate(entity, Groups.Sandbox, GetWelcomeEmailConfiguration_Sandbox());       
            Populate(entity, Groups.Southwell, GetWelcomeEmailConfiguration_Southwell());
        }

        private static void Populate(this EntityTypeBuilder<GroupEmailConfiguration> entity, Groups group, List<KeyValuePair<string, string>> keyValuePairs)
        {
            entity.HasData(new GroupEmailConfiguration
            {
                GroupId = (int)group,
                CommunicationJobTypeId = (byte)CommunicationJobTypes.GroupWelcome,
                Configuration = JsonConvert.SerializeObject(keyValuePairs)
            });
        }
    }
}
