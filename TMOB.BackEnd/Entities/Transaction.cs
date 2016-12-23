using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMOB.BackEnd.Entities
{
    public enum Mode { Test, Product }
    public class Transaction
    {
        public int ID { get; set; }

        public string ApplicationVersion { get; set; }
        public Mode Mode { get; set; }
        public bool NeedsToUpdate { get; set; }

        public ICollection<Device> Device { get; set; }
        public ICollection<Venue> Venue { get; set; }
    }
}
