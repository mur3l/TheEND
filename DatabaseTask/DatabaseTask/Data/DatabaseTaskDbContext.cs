using DatabaseTask;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask
{
    public class DatabaseTaskDbContext : DbContext
    {

        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
        : base(options) { }


        public DbSet<Child> Child { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<Hint> Hint { get; set; }
        public DbSet<HRRequest> HRRequest { get; set; }
        public DbSet<IntranetId> IntranetId { get; set; }
        public DbSet<LoanableItem> LoanableItem { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<Vacation> Vacation { get; set; }

    }
}
