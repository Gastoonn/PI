using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class StockViewModel
    {
        [Key, Column(Order = 0)]
        public int idProduct { get; set; }

        [Key, Column(Order = 1)]
        public int idStore { get; set; }
        public int Quantity { get; set; }
    }
}