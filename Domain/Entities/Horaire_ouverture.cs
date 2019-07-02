using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Horaire_ouverture
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_ouvert{ get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Ferme { get; set; }
        public List<Store> Stores{ get; set; }
    }
}
