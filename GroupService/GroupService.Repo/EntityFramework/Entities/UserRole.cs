using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
