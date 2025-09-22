using Microsoft.EntityFrameworkCore;

namespace WebAPIDay18Lab.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {

        }
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(s =>
            {
                s.HasKey(s => s.Id);
                s.Property(x => x.Name).IsRequired();
            });

        }
    }
}
