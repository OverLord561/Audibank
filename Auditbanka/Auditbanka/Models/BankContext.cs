using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka.Models
{
    public class BankContext : DbContext
    {
        public BankContext() : base("BankContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Dogovir> Dogovirs { get; set; }
        public DbSet<Providing> Providings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}
