using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class RequestorDetails
    {
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Locality { get; set; }
        public string Postcode { get; set; }
        public string EmailAddress { get; set; }
        public string MobilePhone { get; set; }
        public string OtherPhone { get; set; }

        public virtual Group Group { get; set; }
    }
}
