using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Contracts.CommunicationService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $"<p>If you haven’t done it already, you may like to complete your online ID verification now. We’ve made it as quick and easy as possible with the help of our partner, Yoti. Click here to launch your profile and get verified.</p>" +
                                                                        $"<p>Most requests on our platform require ID verification to give people in need of help the confidence you are who you say you are. Some of our partner organisations may also require additional checks, if this is the case we’ll let you know when you click to accept a request.</p>"
                                                      ));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", "P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need."));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_FTLOS()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "1"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Default()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_HLP()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "1"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Tankersley()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", $"<p>Questions? Email us at tankersley@helpmystreet.org</p>" +
                                                                   $"<p>P.S.Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about.Complete our Request Help form and let us know what they need.</p>"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Balderton()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", $"<p>Questions? Email us at baldertoncs@helpmystreet.org</p>" +
                                                                   $"<p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>"));

            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_NorthMuskham()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", $"<p>Questions? Email us at northmuskham@helpmystreet.org" +
                                                                   $"<p>P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our Request Help form and let us know what they need.</p>"));

            return config;
        }

        public static void PopulateGroupEmailConfiguration(this EntityTypeBuilder<GroupEmailConfiguration> entity)
        {
            Populate(entity, Groups.Generic, GetWelcomeEmailConfiguration_HelpMyStreet());
            Populate(entity, Groups.FTLOS, GetWelcomeEmailConfiguration_FTLOS());
            Populate(entity, Groups.AgeUKLSL, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.HLP, GetWelcomeEmailConfiguration_HLP());
            Populate(entity, Groups.Tankersley, GetWelcomeEmailConfiguration_Tankersley());
            Populate(entity, Groups.Ruddington, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.AgeUKWirral, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.AgeUKNottsBalderton, GetWelcomeEmailConfiguration_Balderton());
            Populate(entity, Groups.AgeUKNorthWestKent, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.AgeUKNottsNorthMuskham, GetWelcomeEmailConfiguration_NorthMuskham());
            Populate(entity, Groups.AgeUKSouthKentCoast, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.LincolnshireVolunteers, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.StamfordPCN, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.LincolnPCN, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.Sandbox, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.AgeConnectsCardiff, GetWelcomeEmailConfiguration_Default());
            Populate(entity, Groups.MeadowsCommunityHelpers, GetWelcomeEmailConfiguration_Default());
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
