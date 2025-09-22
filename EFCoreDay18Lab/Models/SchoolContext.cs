using Microsoft.EntityFrameworkCore;

namespace EFCoreDay18Lab.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=SAYEDHAWAS\\DEPI2025R3;Initial Catalog=TrackChangeDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
