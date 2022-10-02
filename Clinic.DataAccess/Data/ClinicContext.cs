using Clinic.Entities.Configuration;
using Clinic.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Clinic.DataAccess.Data;

internal class ClinicContextFactory : IDesignTimeDbContextFactory<ClinicContext>
{
    public ClinicContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ClinicContext>();
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Clinic.Database;Trusted_Connection=True;MultipleActiveResultSets=true");
        return new ClinicContext(optionsBuilder.Options);
    }
}

public class ClinicContext : DbContext
{
    public ClinicContext(DbContextOptions<ClinicContext> options)
        : base(options)
    {
    }

    public DbSet<Page> Page { get; set; } = null!;
    public DbSet<Doctor> Doctor { get; set; } = null!;
    public DbSet<Parameter> Parameter { get; set; } = null!;
    public DbSet<Service> Service { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PageConfiguration());
        modelBuilder.ApplyConfiguration(new ParameterConfiguration());
        modelBuilder.ApplyConfiguration(new DoctorConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceConfiguration());
    }
}
