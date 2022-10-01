using Clinic.Entities.Configuration;
using Clinic.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataAccess.Data;

public class ClinicContext : DbContext
{
    public ClinicContext(DbContextOptions<ClinicContext> options)
        : base(options)
    {
    }

    public DbSet<Page> Page { get; set; } = null!;
    public DbSet<Doctor> Doctor { get; set; } = null!;
    public DbSet<Parameter> Parameter { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PageConfiguration());
        modelBuilder.ApplyConfiguration(new ParameterConfiguration());
        modelBuilder.ApplyConfiguration(new DoctorConfiguration());
    }
}
