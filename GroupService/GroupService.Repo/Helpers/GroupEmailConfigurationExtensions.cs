using GroupService.Repo.EntityFramework.Entities;
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
        public static void SetEnumGroupEmailVariantExtensionsData(this EntityTypeBuilder<EnumGroupEmailVariant> entity)
        {
            var groupEmailVariant = Enum.GetValues(typeof(GroupEmailVariant)).Cast<GroupEmailVariant>();

            foreach (var variant in groupEmailVariant)
            {
                entity.HasData(new EnumGroupEmailVariant { Id = (int)variant, Name = variant.ToString() });
            }
        }

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

        public static void PopulateGroupEmailConfiguration(this EntityTypeBuilder<GroupEmailConfiguration> entity)
        {
            entity.HasData(new GroupEmailConfiguration
            {
                GroupId = (int)Groups.Generic,
                GroupEmailVariantId = (byte)GroupEmailVariant.Welcome,
                Configuration = JsonConvert.SerializeObject(GetWelcomeEmailConfiguration_HelpMyStreet())
            });
        }
    }
}
