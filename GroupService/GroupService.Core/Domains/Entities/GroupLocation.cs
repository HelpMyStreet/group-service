using HelpMyStreet.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Core.Domains.Entities
{
    public class GroupLocation
    {
        public int GroupID { get; set; }
        public Location Location { get; set; }
    }
}
