using DemoAppVar1.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<DetailModel> Details { get; set; }
        public DbSet<DeviceModel> Devices { get; set; }
        public DbSet<ServiceModel> Services { get; set; }
        public DbSet<StatusModel> Statuses { get; set; }
        public DbSet<StatusUpdateModel> StatusUpdates { get; set; }
        public DbSet<ServiceDetailModel> ServiceDetails { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public AppDbContext()
        {
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=demo2;Username=admin;Password=admin");
        }
    }
}
