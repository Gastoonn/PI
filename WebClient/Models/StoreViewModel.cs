using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class StoreViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public DateTime Horaire_ouverture { get; set; }
        public StockViewModel idStock { get; set; } //a verifier
    }
}