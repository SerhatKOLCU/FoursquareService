using System.Collections.Generic;

namespace TMOB._4sqService.Models
{
    public class Venue
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
    }

    public class Locations
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}