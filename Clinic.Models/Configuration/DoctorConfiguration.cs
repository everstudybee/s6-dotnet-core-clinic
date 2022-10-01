using Clinic.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.Entities.Configuration;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
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
                DoctorId = 1,
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
                DoctorId = 2,
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
                DoctorId = 3,
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
                DoctorId = 4,
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
