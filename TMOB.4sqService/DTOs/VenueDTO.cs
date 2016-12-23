using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMOB._4sqService.Models;

namespace TMOB._4sqService.DTOs
{
    public class VenueDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Locations Location { get; set; }
        public int PeopleHereNow { get; set; }
        public string URL { get; set; }
        public int Likes { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public static Modes Mode { get; set; }
    }
}