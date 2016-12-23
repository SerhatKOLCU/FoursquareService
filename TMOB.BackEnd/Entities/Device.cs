using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMOB.BackEnd.Entities
{
    public class Device
    {
        public int ID { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string OSVersion { get; set; }
        public string AppVersion { get; set; }
    }
}
