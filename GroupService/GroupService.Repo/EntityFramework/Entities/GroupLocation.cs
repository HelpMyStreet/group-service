using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupLocation
    {
        public int GroupId { get; set; }
        public int LocationId { get; set; }

        public virtual Group Group { get; set; }
    }
}
