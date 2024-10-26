using DemoAppVar1.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAppVar1.Data
{
    public interface IAppDbContext
    {
        DbSet<ClientModel> Clients { get; set; }
        DbSet<EmployeeModel> Employees { get; set; }
        DbSet<ServiceModel> Services { get; set; }
        DbSet<StatusModel> Statuses { get; set; }
        DbSet<StatusUpdateModel> StatusUpdates { get; set; }

        int SaveChanges();
    }
}
