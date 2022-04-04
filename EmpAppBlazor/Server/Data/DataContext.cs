using Microsoft.EntityFrameworkCore;

namespace EmpAppBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workload>().HasData(
                new Workload() { Id = 1, DueDate = DateTime.Now.AddDays(100), Stage = "active" },
                new Workload() { Id = 2, DueDate = DateTime.Now.AddDays(150), Stage = "hold" },
                new Workload() { Id = 3, DueDate = DateTime.Now.AddDays(200), Stage = "done" }
                );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Number = 17156,
                    Name = "Tomason",
                    Site = "Self-Build",
                    Description = "",
                    DeliveryDate = DateTime.Now.AddDays(5),
                    WorkloadId = 1
                },
                new Project
                {
                    Id = 2,
                    Number = 14104,
                    Name = "Ellesar",
                    Site = "Self-Build",
                    Description = "",
                    DeliveryDate = DateTime.Now.AddDays(35),
                    WorkloadId = 2
                },
                new Project
                {
                    Id = 3,
                    Number = 21201,
                    Name = "Clark",
                    Site = "KTS",
                    Description = "This project is on hold now.",
                    DeliveryDate = DateTime.Now.AddDays(4),
                    WorkloadId = 3
                }
            );
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Workload> Workloads { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
