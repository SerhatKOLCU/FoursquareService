using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMOB._4sqService.Models
{
    public class Device
    {
        public int ID { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string OSVersion { get; set; }
    }
}