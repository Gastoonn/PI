using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClient.Models
{
    public class ProspectViewModel
    {
        public int id { get; set; }
        public string Address { get; set; }
        public string MatriculeVehicule { get; set; }
        public int MatriculeChefCampagne { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
    }
}