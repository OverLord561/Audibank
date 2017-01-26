using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditbanka
{
    public class BankContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
