using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; } 
        public string Tel { get; set; }
        public DateTime Horaire_ouverture { get; set; }
        public List<Stock> Stock { get; set; }

    }
}
