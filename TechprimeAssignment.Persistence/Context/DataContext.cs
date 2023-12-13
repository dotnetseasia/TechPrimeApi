using TruckLotParking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using TechprimeAssignment.Domain.Entities;

namespace TruckLotParking.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<TblProject> tblProjects { get; set; }
}