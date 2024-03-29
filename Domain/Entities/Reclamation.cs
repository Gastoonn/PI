﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Reclamation
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        public DateTime dateReclamation { get; set; }
        public Client Client { get; set; }
        public string CategorieReclamation { get; set; }
        public string SujetReclamation { get; set; }
        public string textReclamation { get; set; }
        [ForeignKey("Client")]
        [Column(Order = 1)]
        public int idClient { get; set; }
        public string EtatReclamation { get; set; }
    }
}
