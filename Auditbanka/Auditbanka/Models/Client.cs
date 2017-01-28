using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
   public class Client
    {
        public int ClientId { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PlaceOfJob { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
        public double AmountOfIncome { get; set; }
        public string Passport { get; set; }
        public DateTime DateOfPassport { get; set; }
        public string PassportIssuedBy { get; set; }
        public int Identification { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public int Experience { get; set; }
        public string Osvita { get; set; }
        public string IsMarried { get; set; }
        public int Children { get; set; }
        public string HasDeposit { get; set; }        
        public string Statistica { get; set; }




        // один Клієнт -одна Адреса
        public Adress Adress { get; set; }

        // один  Клієнт - багато Кредитних договорів
        public List<Dogovir> Dogovir { get; set; }
    }
}
