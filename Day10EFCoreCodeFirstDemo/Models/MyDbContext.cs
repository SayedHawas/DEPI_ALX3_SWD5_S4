using Microsoft.EntityFrameworkCore;

namespace Day10EFCoreCodeFirstDemo.Models
{
    public class MyDbContext : DbContext
    {
        //Open Session With Database 
        //List<Employee> employees = new List<Employee>();
        //Tables  Table Entity 
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=SAYEDHAWAS\\DEPI2025R3;Database=EFCoreCodeFirstDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
