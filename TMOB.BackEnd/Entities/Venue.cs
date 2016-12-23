using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMOB.BackEnd.Entities
{
    public class Venue
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<Locations> Location { get; set; }
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
