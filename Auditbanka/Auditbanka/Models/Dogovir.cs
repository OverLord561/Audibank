using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
   public class Dogovir
    {
        public int DogovirId { get; set; }
        public string TypeOfCredit { get; set; }
        public double AmountOfCredit {get;set;}
        public string Currency { get; set; }
        public double Rate { get; set; }
        public DateTime DateOfGetting { get; set; }
        public int Termin { get; set; }
        public string Target { get; set; }
        public bool IsPayed { get; set; }


        // один Договір - багато Забезпечень
        public List<Providing> Providing { get; set; }

        //один Договір - багато Перевірок
        public List<Audit> Audit { get; set; }


        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
