using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Core.Domains
{
    public class UserRoleSummary
    {
        public GroupAction GroupAction { get; set; }
        public DateTime DateRequested { get; set; }
        public GroupRoles Roles { get; set; }
        public bool IsAdmin
        {
            get
            {
                return Roles.IsAdmin();
            }
        }
    }
}
