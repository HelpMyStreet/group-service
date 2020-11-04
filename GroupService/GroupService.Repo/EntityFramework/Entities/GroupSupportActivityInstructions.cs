using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupSupportActivityInstructions
    {
        public int GroupId { get; set; }
        public int SupportActivityId { get; set; }
        public short SupportActivityInstructionsId { get; set; }

        public virtual Group Group { get; set; }
        public virtual SupportActivityInstructions SupportActivityInstructions { get; set; }
    }
}
