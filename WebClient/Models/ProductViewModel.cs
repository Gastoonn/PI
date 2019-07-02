using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public List<ShoppingCartModel> ListPanierModel { get; set; }
        public List<PackViewModel> ListPack { get; set; }
        public List<Stock> Stock { get; set; }

    }
}