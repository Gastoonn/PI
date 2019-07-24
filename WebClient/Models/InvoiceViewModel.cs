using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class InvoiceViewModel
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [ForeignKey("Client")]
        [Column(Order = 1)]
        public int idClient { get; set; }
        [ForeignKey("Product")]
        [Column(Order = 2)]
        public int idProduit { get; set; }
        public int Quantite { get; set; }

        [ForeignKey("Quotation")]
        [Column(Order = 3)]
        public int idQuotation { get; set; }
        public float SumInvoice { get; set; }
        public DateTime DateInvoice { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public Quotation Quotation { get; set; }
    }
}