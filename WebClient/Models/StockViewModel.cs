using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class StockViewModel
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public List<ProductViewModel> ListPRoductModel { get; set; }//a verifier
        public List<StoreViewModel> ListStoreModel { get; set; }//a verifier
    }
}