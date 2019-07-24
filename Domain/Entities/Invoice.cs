using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public float Total { get; set; }
       // [DataType(DataType.DateTime)]
        public DateTime Date_invoice { get; set; }
    }
}
