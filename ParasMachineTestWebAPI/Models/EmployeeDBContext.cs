using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParasMachineTestWebAPI.Models
{
    public class EmployeeDBContext :DbContext
    {
        public EmployeeDBContext(DbContextOptions options):base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
