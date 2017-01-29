using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
    public  class Splata
    {
        public int SplataId { get; set; }
        public int NumberOfSplata { get; set; }
        public DateTime DateOfSplata { get; set; }
        public double SumOfSplata { get; set; }
        public double TotalSplata { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
