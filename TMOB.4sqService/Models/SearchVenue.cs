using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMOB._4sqService.Models
{
    public class SearchVenue
    {
        [Key]
        [Required]
        public string searchKeyword { get; set; }
        public string city { get; set; }
        public Locations Location { get; set; }
    }
}