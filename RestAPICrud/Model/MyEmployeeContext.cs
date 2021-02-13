using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.Model
{
    public class MyEmployeeContext : DbContext
    {
        public MyEmployeeContext(DbContextOptions<MyEmployeeContext> options) : base(options)
        {
        }

        public DbSet<MyEmployee> Employees { get; set; }
    }
}
