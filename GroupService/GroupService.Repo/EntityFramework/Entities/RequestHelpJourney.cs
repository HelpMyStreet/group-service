using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class RequestHelpJourney
    {
        public int GroupId { get; set; }
        public string Source { get; set; }
        public byte RequestHelpFormVariant { get; set; }
        public byte TargetGroups { get; set; }
        public bool AccessRestrictedByRole { get; set; }
        public bool RequestorDefinedByGroup { get; set; }

        public virtual Group Group { get; set; }
    }
}
