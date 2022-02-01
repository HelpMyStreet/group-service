using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Core.Domains
{
    public class UserRoleSummary
    {
        public DateTime DateRequested { get; set; }
        public GroupRoles Role { get; set; }
        public int UserId { get; set; }
        public bool IsAdmin
        {
            get
            {
                return Role.IsAdmin();
            }
        }
    }
}
