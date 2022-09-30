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
        public DbSet<Doctor> Doctor { get; set; } = null!;
        public DbSet<Parameter> Parameter { get; set; } = null!;

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

            #endregion

            #region ParameterDafaultAndSeeds

            modelBuilder.Entity<Parameter>()
                .Property(b => b.WhoAdded)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Parameter>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Parameter>()
                .Property(b => b.WhoModified)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Parameter>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Parameter>()
                .Property(b => b.WhoRemoved)
                .HasDefaultValue("Admin");
            modelBuilder.Entity<Parameter>()
                .Property(b => b.WhenAdded)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Parameter>()
                .Property(b => b.IsActive)
                .HasDefaultValue(true);

            modelBuilder.Entity<Parameter>().HasData(
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

            #endregion

        }
    }
}
