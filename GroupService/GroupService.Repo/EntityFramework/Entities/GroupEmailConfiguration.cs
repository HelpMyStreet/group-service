using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupEmailConfiguration
    {
        public int GroupId { get; set; }
        public byte CommunicationJobTypeId { get; set; }
        public string Configuration { get; set; }
        public virtual Group Group { get; set; }        
    }
}
