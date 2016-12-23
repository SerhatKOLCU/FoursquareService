using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TMOB._4sqService.Models
{
    public class TMOB_4sqServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TMOB_4sqServiceContext() : base("name=TMOB_4sqServiceContext")
        {
        }

        public System.Data.Entity.DbSet<TMOB._4sqService.Models.Transaction> Transactions { get; set; }
        public System.Data.Entity.DbSet<TMOB._4sqService.Models.Device> Devices { get; set; }
        public System.Data.Entity.DbSet<TMOB._4sqService.Models.Venue> Venues { get; set; }

        public System.Data.Entity.DbSet<TMOB._4sqService.Models.SearchVenue> SearchVenues { get; set; }
    }
}
