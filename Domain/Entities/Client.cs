using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom{ get; set; }
        public string telephone{ get; set; }
        public string email{ get; set; }
        public string adresse { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        
        public int idPanier { get; set; }
        

    }
}
