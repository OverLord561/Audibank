using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string LegalAdress { get; set; }

        public List<Employee> Employee { get; set; }
    }

   

}
