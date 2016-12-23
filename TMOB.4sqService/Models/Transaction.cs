using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMOB._4sqService.Models
{
    public enum Modes { Test = 1, Production = 2 }
    public class Transaction
    {
        public string ApplicationVersion { get; set; }
        public Modes Mode { get; set; }

    }
}