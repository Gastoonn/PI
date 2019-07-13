using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class ShoppingCartModel
    {
        public int Id { get; set; }
        public int idCLient { get; set; }
        public int idProduct { get; set; }
        public bool IsAPack { get; set; }
        public int Quantite { get; set; } 
        public int idQuotation { get; set; }
    }
}