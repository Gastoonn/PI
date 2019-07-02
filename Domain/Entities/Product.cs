using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public List<ShoppingCart> ListPanier { get; set; }
        public List<Pack> ListPack { get; set; }
        public List<Stock> Stock { get; set; } 
    }
}
