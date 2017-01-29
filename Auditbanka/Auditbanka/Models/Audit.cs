using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
    public class Audit
    {
        public int AuditId { get; set; }
        public DateTime DateofAudit { get; set; }
        public string Result { get; set; }


        public int DogovirId { get; set; }
        public Dogovir Dogovir { get; set; }
    }
}
