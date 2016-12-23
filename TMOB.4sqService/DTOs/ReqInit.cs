using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMOB._4sqService.Models;

namespace TMOB._4sqService.DTOs
{
    public class ReqInit
    {
        public Device deviceInfo { get; set; }
        public Transaction transactionInfo { get; set; }
    }
}