using Clinic.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.Entities.Configuration;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.Property(b => b.WhoAdded)
            .HasDefaultValue("Admin");
        builder.Property(b => b.WhenAdded)
            .ValueGeneratedOnAdd();
        builder.Property(b => b.IsActive)
            .HasDefaultValue(true);

        builder.HasData(
            new
            {
                ServiceId = 1,
                Name = "Dr. Micheal Anderson",
                ImageSmall = "t1.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "Short presentation",
                Biography = "<p>Biography</p>",
                Position = 1,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            },
            new
            {
                ServiceId = 2,
                Name = "Dr. Micheal Anderson",
                ImageSmall = "t2.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "Short presentation",
                Biography = "<p>Biography</p>",
                Position = 1,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            },
            new
            {
                ServiceId = 3,
                Name = "Dr. Micheal Anderson",
                ImageSmall = "t3.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "Short presentation",
                Biography = "<p>Biography</p>",
                Position = 1,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            },
            new
            {
                ServiceId = 4,
                Name = "Dr. Micheal Anderson",
                ImageSmall = "t4.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "Short presentation",
                Biography = "<p>Biography</p>",
                Position = 1,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            });
    }
}
