using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class ShoppingCartModel
    {
        [Key]
        public int Id { get; set; }
        public int idCLient { get; set; }
        public List<ProductViewModel> ListProductModel { get; set; }
        public List<PackViewModel> ListPackModel { get; set; }
        public int idQuotation { get; set; }
    }
}