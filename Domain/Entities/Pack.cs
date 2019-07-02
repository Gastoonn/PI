using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pack
    {
        [Key]
        public int Id { get; set; }
        public float Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime date_deb { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime date_expiration { get; set; }
    }
}
