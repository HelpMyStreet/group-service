﻿using GroupService.Repo.EntityFramework.Entities;
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
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", $"P.S. Don’t forget that you can submit a request for help at any time if there’s someone far away from home that you’re worried about. Complete our <a href=\"{{{{BaseUrl}}}}/request-help\">Request Help form</a> and let us know what they need."));
            config.Add(new KeyValuePair<string, string>("ShowLinkToProfile", "true"));            
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

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_AgeConnectCardiff()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("GroupPS", ""));
            config.Add(new KeyValuePair<string, string>("GroupLogo", "ageconnectcardifflogo.png"));

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
            config.Add(new KeyValuePair<string, string>("ShowGroupRequestFormLink", "true"));
            config.Add(new KeyValuePair<string, string>("GroupPS", $"<p>Questions? Email us at <a href=\"mailto:tankersley@helpmystreet.org\">tankersley@helpmystreet.org</a></p>"));
            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_Balderton()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("ShowGroupRequestFormLink", "true"));            
            config.Add(new KeyValuePair<string, string>("GroupPS", $"<p>Questions? Email us at <a href=\"mailto:baldertoncs@helpmystreet.org\">baldertoncs@helpmystreet.org</a></p>"));

            return config;
        }

        private static List<KeyValuePair<string, string>> GetWelcomeEmailConfiguration_NorthMuskham()
        {
            List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();
            config.Add(new KeyValuePair<string, string>("HeaderRequired", "0"));
            config.Add(new KeyValuePair<string, string>("GroupContent", $""));
            config.Add(new KeyValuePair<string, string>("GroupSignature", ""));
            config.Add(new KeyValuePair<string, string>("ShowGroupRequestFormLink", "true"));            
            config.Add(new KeyValuePair<string, string>("GroupPS", $"<p>Questions? Email us at <a href=\"mailto:northmuskham@helpmystreet.org\">northmuskham@helpmystreet.org</a>"));

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
            Populate(entity, Groups.AgeConnectsCardiff, GetWelcomeEmailConfiguration_AgeConnectCardiff());
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
