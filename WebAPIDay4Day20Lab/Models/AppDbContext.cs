using Microsoft.EntityFrameworkCore;

namespace WebAPIDay4Day20Lab.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed Data
            modelBuilder.Entity<Teacher>().HasData(new Teacher() { TeacherId = 1, Name = "Tammer Ali ", Subject = "Arabic" });
            modelBuilder.Entity<Class>().HasData(new Class() { ClassId = 1, ClassName = "Class A", TeacherId = 1 });
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Class>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Classes)
                .HasForeignKey(c => c.TeacherId);

            modelBuilder.Entity<Class>()
                .HasMany(c => c.Students)
                .WithMany(s => s.Classes)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentClass",
                    r => r.HasOne<Student>().WithMany().HasForeignKey("StudentId"),
                    l => l.HasOne<Class>().WithMany().HasForeignKey("ClassId"));
        }

    }
}
