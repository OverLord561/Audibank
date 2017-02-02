using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
    public class Adress
    {
        [ForeignKey("Client")]
        public int AdressId { get; set; }
        public string Country { get; set; }//
        public string Region { get; set; }//
        public string City { get; set; }//
        public string Street { get; set; }//
        public int Building { get; set; }//
        public int BuildingNumber { get; set; }   //         
        
        // один клієнт - одна адреса
        public Client Client { get; set; }
    }
}


