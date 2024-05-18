using System.Reflection;
using HackathonEarthquake.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HackathonEarthquake.Repository.Context;

public class EarthquakeDbContext : DbContext
{
    public EarthquakeDbContext(DbContextOptions<EarthquakeDbContext> options) : base(options)
    {
        
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Neighbourhood> Neighbourhoods { get; set; }
    public DbSet<Street> Streets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}

public class EarthquakeDbContextFactory : IDesignTimeDbContextFactory<EarthquakeDbContext>
{
    public EarthquakeDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<EarthquakeDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost;Database=EarthquakeDb;User ID=SA;Password=Muhammet.evkaya.1;Trusted_Connection=False;Encrypt=False;");

        return new EarthquakeDbContext(optionsBuilder.Options);
    }
}