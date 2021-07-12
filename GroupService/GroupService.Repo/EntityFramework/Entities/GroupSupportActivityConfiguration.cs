using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupSupportActivityConfiguration
    {
        public int GroupId { get; set; }
        public int SupportActivityId { get; set; }
        public short SupportActivityInstructionsId { get; set; }
        public double Radius { get; set; }

        public virtual Group Group { get; set; }
        public virtual SupportActivityInstructions SupportActivityInstructions { get; set; }
    }
}
