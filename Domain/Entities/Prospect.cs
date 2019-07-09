using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prospect
    {
        [Key]
        public int ProspectNumber { get; set; }
        public string Address { get; set; }
        public List<string> Vehicules { get; set; }
        public List<int> MatriculeAgents { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
    }
}
