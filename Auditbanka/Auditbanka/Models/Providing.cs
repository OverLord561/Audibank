using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
   public class Providing
    {
        public int ProvidingId { get; set; }
        public string TypeOfProviding { get; set; }
        public double Total { get; set; }

        public int DogovirId { get; set; }
        public Dogovir Dogovir { get; set; }
    }
}
