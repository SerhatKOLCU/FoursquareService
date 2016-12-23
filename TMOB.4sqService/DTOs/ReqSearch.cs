using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TMOB._4sqService.Models;

namespace TMOB._4sqService.DTOs
{
    public class ReqSearch
    {
        [Required]
        public string searchKeyword { get; set; }
        public string City { get; set; }
        public Locations Location { get; set; }
    }
}