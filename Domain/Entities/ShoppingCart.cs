﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public int idCLient { get; set; }
        public List<Product> ListProduct { get; set; }
        public List<Pack> ListPack { get; set; }
        public int idQuotation { get; set; }
    }
}