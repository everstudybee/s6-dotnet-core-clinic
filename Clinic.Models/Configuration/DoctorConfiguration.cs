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
                Name = "Dr. Micheal Anderson 1",
                ImageSmall = "t1.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (1)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 1,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            }, new
            {
                DoctorId = 2,
                Name = "Dr. Micheal Anderson 2",
                ImageSmall = "t2.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (2)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 2,
                IsHomePage = false,
                WhenAdded = DateTime.Now
            }, new
            {
                DoctorId = 3,
                Name = "Dr. Micheal Anderson 3",
                ImageSmall = "t3.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (3)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 3,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            }, new
            {
                DoctorId = 4,
                Name = "Dr. Micheal Anderson 4",
                ImageSmall = "t4.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (4)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 4,
                IsHomePage = false,
                WhenAdded = DateTime.Now
            }, new
            {
                DoctorId = 5,
                Name = "Dr. Micheal Anderson 5",
                ImageSmall = "t1.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (5)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 5,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            }, new
            {
                DoctorId = 6,
                Name = "Dr. Micheal Anderson 6",
                ImageSmall = "t2.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (6)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 6,
                IsHomePage = false,
                WhenAdded = DateTime.Now
            }, new
            {
                DoctorId = 7,
                Name = "Dr. Micheal Anderson 7",
                ImageSmall = "t3.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (7)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 7,
                IsHomePage = true,
                WhenAdded = DateTime.Now
            }, new
            {
                DoctorId = 8,
                Name = "Dr. Micheal Anderson 8",
                ImageSmall = "t4.jpg",
                Image = "detail-dr1.jpg",
                Specialty = "Heart Surgery",
                Experience = "15+ Years",
                Education = "University of California, USA",
                Area = "London, USA",
                Certifications = "USA Board Neurological Surgery",
                ShortPresentation = "You can relay on our amazing features list and also our customer services will be great.",
                Biography = "<p class=\"text-muted mt-4 font-weight-normal lh-29\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. (8)</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Aliquam velit velit, faucibus vel egestas sit amet, ultricies nec elit. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit.</p><p class=\"text-muted mt-4 font-weight-normal lh-29\">Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt. Ut molestie nisi vitae nulla scelerisque, quis finibus ante posuere. Phasellus aliquet at turpis pretium blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent tristique vehicula porta. Nullam quis nulla et leo consequat tincidunt.</p>",
                Position = 8,
                IsHomePage = false,
                WhenAdded = DateTime.Now
            });
    }
}
