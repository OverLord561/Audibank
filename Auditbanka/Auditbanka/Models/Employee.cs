using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }

        public int PersonalNumber { get; set; }
        public string Position { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        //один Працівник - багато Кредитних операцій
        public List<Dogovir> Dogovir { get; set; }

    }

}