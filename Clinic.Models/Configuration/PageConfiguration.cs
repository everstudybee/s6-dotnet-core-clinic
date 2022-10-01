using Clinic.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.Entities.Configuration;

public class PageConfiguration : IEntityTypeConfiguration<Page>
{
    public void Configure(EntityTypeBuilder<Page> builder)
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
                PageId = 1,
                PageLink = "/Home",
                PageAnchorText = "Home",
                PageLinkPosition = 1,
                WhenAdded = DateTime.Now
            }, new
            {
                PageId = 2,
                PageLink = "/Doctors",
                PageAnchorText = "Doctors",
                PageLinkPosition = 2,
                WhenAdded = DateTime.Now
            }, new
            {
                PageId = 3,
                PageLink = "/Services",
                PageAnchorText = "Services",
                PageLinkPosition = 3,
                WhenAdded = DateTime.Now
            }, new
            {
                PageId = 4,
                PageLink = "/Appointments",
                PageAnchorText = "Appointments",
                PageLinkPosition = 4,
                WhenAdded = DateTime.Now
            });
    }
}