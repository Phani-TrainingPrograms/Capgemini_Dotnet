using CoreApiWithJwt.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreApiWithJwt.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) :base(options) { }    
        
        public DbSet<Employee> Employees { get; set; }
    }
}
