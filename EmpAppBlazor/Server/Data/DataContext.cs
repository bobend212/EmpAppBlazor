namespace EmpAppBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workload>().HasData(
                new Workload()
                {
                    Id = 1,
                    DeliveryDate = DateTime.Now.AddDays(12),
                    RequiredDate = DateTime.Now.AddDays(45),
                    OrderPlaced = DateTime.Now.AddDays(4),
                    ProjectId = 1
                },
                new Workload()
                {
                    Id = 2,
                    DeliveryDate = DateTime.Now.AddDays(54),
                    RequiredDate = DateTime.Now.AddDays(25),
                    OrderPlaced = DateTime.Now.AddDays(62),
                    ProjectId = 2
                },
                new Workload()
                {
                    Id = 3,
                    DeliveryDate = DateTime.Now.AddDays(72),
                    RequiredDate = DateTime.Now.AddDays(55),
                    OrderPlaced = DateTime.Now.AddDays(6),
                    ProjectId = 3
                }
                );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Number = 17156,
                    Name = "Tomason",
                    Site = "Self-Build",
                    Status = ""
                },
                new Project
                {
                    Id = 2,
                    Number = 14104,
                    Name = "Ellesar",
                    Site = "Self-Build",
                    Status = ""
                },
                new Project
                {
                    Id = 3,
                    Number = 21201,
                    Name = "Clark",
                    Site = "KTS",
                    Status = ""
                }
            );

            modelBuilder.Entity<Project>()
                .HasOne(a => a.Workload)
                .WithOne(b => b.Project)
                .HasForeignKey<Workload>(b => b.ProjectId);

            modelBuilder.Entity<UserProject>()
                .HasKey(cs => new { cs.UserId, cs.ProjectId});
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Workload> Workloads { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }
    }
}