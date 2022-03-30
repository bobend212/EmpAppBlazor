using Microsoft.EntityFrameworkCore;

namespace EmpAppBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Number = 17156,
                    Name = "Tomason",
                    Site = "Self-Build",
                    Description = "",
                    DeliveryDate = DateTime.Now.AddDays(5),
                },
                new Project
                {
                    Id = 2,
                    Number = 14104,
                    Name = "Ellesar",
                    Site = "Self-Build",
                    Description = "",
                    DeliveryDate = DateTime.Now.AddDays(35),
                },
                new Project
                {
                    Id = 3,
                    Number = 21201,
                    Name = "Clark",
                    Site = "KTS",
                    Description = "This project is on hold now.",
                    DeliveryDate = DateTime.Now.AddDays(4),
                }
            );
        }

        public DbSet<Project> Projects { get; set; }
    }
}
