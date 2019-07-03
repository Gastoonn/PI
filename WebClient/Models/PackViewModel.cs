using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class PackViewModel
    {
        [Key]
        public int Id { get; set; }
        public float Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime date_deb { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime date_expiration { get; set; }
        public List<ShoppingCart> ListPanierModel { get; set; }
        public List<Product> ListProduct { get; set; }
    }
}