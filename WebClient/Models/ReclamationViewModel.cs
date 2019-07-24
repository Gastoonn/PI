using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class ReclamationViewModel
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