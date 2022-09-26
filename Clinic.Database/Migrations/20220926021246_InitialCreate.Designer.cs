﻿// <auto-generated />
using System;
using Clinic.Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clinic.Database.Migrations
{
    [DbContext(typeof(ClinicContext))]
    [Migration("20220926021246_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Clinic.Database.Data.Doctor", b =>
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
                            WhenAdded = new DateTime(2022, 9, 26, 4, 12, 46, 435, DateTimeKind.Local).AddTicks(7688)
                        });
                });

            modelBuilder.Entity("Clinic.Database.Data.Page", b =>
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
                            PageAnchorText = "Home Page",
                            PageLink = "/Home",
                            PageLinkPosition = 1,
                            WhenAdded = new DateTime(2022, 9, 26, 4, 12, 46, 432, DateTimeKind.Local).AddTicks(9799)
                        },
                        new
                        {
                            PageId = 2,
                            PageAnchorText = "Services",
                            PageLink = "/Services",
                            PageLinkPosition = 2,
                            WhenAdded = new DateTime(2022, 9, 26, 4, 12, 46, 432, DateTimeKind.Local).AddTicks(9840)
                        },
                        new
                        {
                            PageId = 3,
                            PageAnchorText = "Doctors",
                            PageLink = "/Doctors",
                            PageLinkPosition = 3,
                            WhenAdded = new DateTime(2022, 9, 26, 4, 12, 46, 432, DateTimeKind.Local).AddTicks(9844)
                        },
                        new
                        {
                            PageId = 4,
                            PageAnchorText = "Appointments",
                            PageLink = "/Appointments",
                            PageLinkPosition = 4,
                            WhenAdded = new DateTime(2022, 9, 26, 4, 12, 46, 432, DateTimeKind.Local).AddTicks(9848)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
