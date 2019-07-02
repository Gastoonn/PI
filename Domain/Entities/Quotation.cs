using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Quotation
    {
        [Key]
        public int Id { get; set; }
        public float Total { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_expiration { get; set; }
        public float TVA { get; set; }
        public string QuoteNo { get; set; }
    }
}
