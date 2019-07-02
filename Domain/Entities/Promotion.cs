using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Promotion
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_deb { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_expiration{ get; set; }
    }
}
