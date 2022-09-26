using Microsoft.EntityFrameworkCore;

namespace Clinic.Database.Data
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options)
            : base(options)
        {
        }

        public DbSet<Page> Page { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region PageDafaultAndSeeds

            modelBuilder.Entity<Page>()
                .Property(b => b.WhoAdded)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Page>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Page>()
                .Property(b => b.WhoModified)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Page>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Page>()
                .Property(b => b.WhoRemoved)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Page>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Page>()
                .Property(b => b.IsActive)
                .HasDefaultValue(true);

            modelBuilder.Entity<Page>().HasData(
                new
                {
                    PageId = 1,
                    PageLink = "/Home",
                    PageAnchorText = "Home Page",
                    PageLinkPosition = 1,
                    WhenAdded = DateTime.Now
                }, new
                {
                    PageId = 2,
                    PageLink = "/Services",
                    PageAnchorText = "Services",
                    PageLinkPosition = 2,
                    WhenAdded = DateTime.Now
                }, new
                {
                    PageId = 3,
                    PageLink = "/Doctors",
                    PageAnchorText = "Doctors",
                    PageLinkPosition = 3,
                    WhenAdded = DateTime.Now
                }, new
                {
                    PageId = 4,
                    PageLink = "/Appointments",
                    PageAnchorText = "Appointments",
                    PageLinkPosition = 4,
                    WhenAdded = DateTime.Now
                }); ;

            #endregion

            #region DoctorDafaultAndSeeds

            modelBuilder.Entity<Doctor>()
                .Property(b => b.WhoAdded)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Doctor>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Doctor>()
                .Property(b => b.WhoModified)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Doctor>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Doctor>()
                .Property(b => b.WhoRemoved)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Doctor>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Doctor>()
                .Property(b => b.IsActive)
                .HasDefaultValue(true);

            modelBuilder.Entity<Doctor>().HasData(
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
                });

            #endregion


        }
    }
}
