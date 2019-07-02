using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Stock
    {
        //[Key, Column(Order = 0)]
        public int idProduct { get; set; }

        //[Key, Column(Order = 1)]
        public int idStore { get; set; }
        public int Quantity { get; set; }

    }
}
