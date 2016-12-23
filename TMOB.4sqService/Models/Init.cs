using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMOB._4sqService.Models
{
    public class Init
    {
        public static bool needsUpdate { get; set; }
        public Device deviceInfo { get; set; }
        public Transaction transactionInfo { get; set; }
        //public ICollection<Venue> Venues { get; set; }
    }
}