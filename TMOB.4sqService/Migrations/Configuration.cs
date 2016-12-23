namespace TMOB._4sqService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TMOB._4sqService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TMOB._4sqService.Models.TMOB_4sqServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TMOB._4sqService.Models.TMOB_4sqServiceContext";
        }

        protected override void Seed(TMOB._4sqService.Models.TMOB_4sqServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Devices.AddOrUpdate(d => d.ID,
                new Device() { ID = 1, Manufacturer = "Apple", Model = "6S", OS = "iOS", OSVersion = "9.1.3" },
                new Device() { ID = 2, Manufacturer = "LG", Model = "G4", OS = "Android", OSVersion = "6.0" }
                );

            context.Venues.AddOrUpdate(v => v.ID,
                new Venue()
                {
                    ID = 1,
                    Name = "Bahar Market",
                    Country = "Turkey",
                    City = "Ýstanbul",
                    Location = new Locations { Latitude = 40.99, Longitude = 28.83 },
                    PeopleHereNow = 24,
                    URL = "http://www.google.com",
                    Likes = 24,
                    Like = true,
                    Dislike = false,
                },
                new Venue()
                {
                    ID = 2,
                    Name = "TMob Mobile Technology",
                    Country = "Turkey",
                    City = "Ýstanbul",
                    Location = new Locations { Latitude = 41.09, Longitude = 29.00 },
                    PeopleHereNow = 56,
                    URL = "http://www.thinksmobility.com",
                    Likes = 108,
                    Like = true,
                    Dislike = false,
                },
                new Venue()
                {
                    ID = 3,
                    Name = "Sakarya University",
                    Country = "Turkey",
                    City = "Sakarya",
                    Location = new Locations { Latitude = 40.74, Longitude = 30.33 },
                    PeopleHereNow = 28534,
                    URL = "http://www.sakarya.edu.tr",
                    Likes = 3200,
                    Like = true,
                    Dislike = false,
                }
                );

           
        }
    }
}
