using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.Models.Configuration;

public class ParameterConfiguration : IEntityTypeConfiguration<Parameter>
{
    public void Configure(EntityTypeBuilder<Parameter> builder)
    {
        builder.Property(b => b.WhoAdded)
                .HasDefaultValue("Admin");
        builder.Property(b => b.WhenAdded)
            .ValueGeneratedOnAdd();
        builder.Property(b => b.WhoModified)
            .HasDefaultValue("Admin");
        builder.Property(b => b.WhenAdded)
            .ValueGeneratedOnAddOrUpdate();
        builder.Property(b => b.WhoRemoved)
            .HasDefaultValue("Admin");
        builder.Property(b => b.WhenAdded)
            .ValueGeneratedOnAdd();
        builder.Property(b => b.IsActive)
        .HasDefaultValue(true);

        builder.HasData(
            new
            {
                ParameterId = 1,
                Code = "footerNote",
                Name = "Footer note",
                Content = "Nullam erat ametam arcu lorme pharetra id risus act sectetur ipsum luctus est ullam erat ametam arcu lorme pharetra id us act sectetur ipsum luctus est.",
                WhenAdded = DateTime.Now
            }, new
            {
                ParameterId = 2,
                Code = "footerAddress",
                Name = "Footer address",
                Content = "134, Cornish Building, Some <br />Near by area, New York, <br />USA - 34556",
                WhenAdded = DateTime.Now
            }, new
            {
                ParameterId = 3,
                Code = "hours",
                Name = "Open hours",
                Content = "8.00 AM - 6:00PM",
                WhenAdded = DateTime.Now
            }, new
            {
                ParameterId = 4,
                Code = "phone",
                Name = "Phone",
                Content = "1 (888) 123 4567",
                WhenAdded = DateTime.Now
            }, new
            {
                ParameterId = 5,
                Code = "email",
                Name = "Email",
                Content = "info@Medika.com",
                WhenAdded = DateTime.Now
            });
    }
}
