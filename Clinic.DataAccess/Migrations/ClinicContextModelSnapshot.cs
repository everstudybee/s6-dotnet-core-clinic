﻿// <auto-generated />
using System;
using Clinic.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clinic.DataAccess.Migrations
{
    [DbContext(typeof(ClinicContext))]
    partial class ClinicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Clinic.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnOrder(7);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(10);

                    b.Property<string>("Certifications")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnOrder(6);

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnOrder(5);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.Property<string>("ImageSmall")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool?>("IsHomePage")
                        .HasColumnType("bit")
                        .HasColumnOrder(12);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnOrder(1);

                    b.Property<int>("Position")
                        .HasColumnType("int")
                        .HasColumnOrder(11);

                    b.Property<string>("ShortPresentation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(9);

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("WhenAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WhenModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WhenRemoved")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhoAdded")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.Property<string>("WhoModified")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.Property<string>("WhoRemoved")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            Area = "London, USA",
                            Biography = "<p>Biography</p>",
                            Certifications = "USA Board Neurological Surgery",
                            Education = "University of California, USA",
                            Experience = "15+ Years",
                            Image = "detail-dr1.jpg",
                            ImageSmall = "t1.jpg",
                            IsHomePage = true,
                            Name = "Dr. Micheal Anderson",
                            Position = 1,
                            ShortPresentation = "Short presentation",
                            Specialty = "Heart Surgery",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(7992)
                        },
                        new
                        {
                            DoctorId = 2,
                            Area = "London, USA",
                            Biography = "<p>Biography</p>",
                            Certifications = "USA Board Neurological Surgery",
                            Education = "University of California, USA",
                            Experience = "15+ Years",
                            Image = "detail-dr1.jpg",
                            ImageSmall = "t2.jpg",
                            IsHomePage = true,
                            Name = "Dr. Micheal Anderson",
                            Position = 1,
                            ShortPresentation = "Short presentation",
                            Specialty = "Heart Surgery",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(8004)
                        },
                        new
                        {
                            DoctorId = 3,
                            Area = "London, USA",
                            Biography = "<p>Biography</p>",
                            Certifications = "USA Board Neurological Surgery",
                            Education = "University of California, USA",
                            Experience = "15+ Years",
                            Image = "detail-dr1.jpg",
                            ImageSmall = "t3.jpg",
                            IsHomePage = true,
                            Name = "Dr. Micheal Anderson",
                            Position = 1,
                            ShortPresentation = "Short presentation",
                            Specialty = "Heart Surgery",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(8007)
                        },
                        new
                        {
                            DoctorId = 4,
                            Area = "London, USA",
                            Biography = "<p>Biography</p>",
                            Certifications = "USA Board Neurological Surgery",
                            Education = "University of California, USA",
                            Experience = "15+ Years",
                            Image = "detail-dr1.jpg",
                            ImageSmall = "t4.jpg",
                            IsHomePage = true,
                            Name = "Dr. Micheal Anderson",
                            Position = 1,
                            ShortPresentation = "Short presentation",
                            Specialty = "Heart Surgery",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(8009)
                        });
                });

            modelBuilder.Entity("Clinic.Models.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PageId"), 1L, 1);

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("PageAnchorText")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnOrder(1);

                    b.Property<string>("PageLink")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnOrder(2);

                    b.Property<int>("PageLinkPosition")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("WhenAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WhenModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WhenRemoved")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhoAdded")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.Property<string>("WhoModified")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.Property<string>("WhoRemoved")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.HasKey("PageId");

                    b.ToTable("Page");

                    b.HasData(
                        new
                        {
                            PageId = 1,
                            PageAnchorText = "Home",
                            PageLink = "/Home",
                            PageLinkPosition = 1,
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(6608)
                        },
                        new
                        {
                            PageId = 2,
                            PageAnchorText = "Doctors",
                            PageLink = "/Doctors",
                            PageLinkPosition = 2,
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(6645)
                        },
                        new
                        {
                            PageId = 3,
                            PageAnchorText = "Services",
                            PageLink = "/Services",
                            PageLinkPosition = 3,
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(6648)
                        },
                        new
                        {
                            PageId = 4,
                            PageAnchorText = "Appointments",
                            PageLink = "/Appointments",
                            PageLinkPosition = 4,
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(6650)
                        });
                });

            modelBuilder.Entity("Clinic.Models.Parameter", b =>
                {
                    b.Property<int>("ParameterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParameterId"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnOrder(1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnOrder(3);

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("WhenAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WhenModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WhenRemoved")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhoAdded")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.Property<string>("WhoModified")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.Property<string>("WhoRemoved")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Admin");

                    b.HasKey("ParameterId");

                    b.ToTable("Parameter");

                    b.HasData(
                        new
                        {
                            ParameterId = 1,
                            Code = "footerNote",
                            Content = "Nullam erat ametam arcu lorme pharetra id risus act sectetur ipsum luctus est ullam erat ametam arcu lorme pharetra id us act sectetur ipsum luctus est.",
                            Name = "Footer note",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(9084)
                        },
                        new
                        {
                            ParameterId = 2,
                            Code = "footerAddress",
                            Content = "134, Cornish Building, Some <br />Near by area, New York, <br />USA - 34556",
                            Name = "Footer address",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(9093)
                        },
                        new
                        {
                            ParameterId = 3,
                            Code = "hours",
                            Content = "8.00 AM - 6:00PM",
                            Name = "Open hours",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(9095)
                        },
                        new
                        {
                            ParameterId = 4,
                            Code = "phone",
                            Content = "1 (888) 123 4567",
                            Name = "Phone",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(9097)
                        },
                        new
                        {
                            ParameterId = 5,
                            Code = "email",
                            Content = "info@Medika.com",
                            Name = "Email",
                            WhenAdded = new DateTime(2022, 10, 1, 11, 18, 8, 857, DateTimeKind.Local).AddTicks(9099)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
