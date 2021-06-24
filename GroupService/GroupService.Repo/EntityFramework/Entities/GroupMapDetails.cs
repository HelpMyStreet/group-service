using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class GroupMapDetails
    {
        public int GroupId { get; set; }
        public byte MapLocationId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal ZoomLevel { get; set; }

        public virtual Group Group { get; set; }
    }
}
