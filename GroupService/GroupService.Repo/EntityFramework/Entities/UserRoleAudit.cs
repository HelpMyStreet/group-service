using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class UserRoleAudit
    {
        public int Id { get; set; }
        public int AuthorisedByUserId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public DateTime DateRequested { get; set; }
        public byte ActionId { get; set; }
        public bool Success { get; set; }
    }
}
