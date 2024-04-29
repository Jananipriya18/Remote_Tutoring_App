﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetapp.Models;

#nullable disable

namespace dotnetapp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dotnetapp.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("TimeSlot")
                        .HasColumnType("time");

                    b.Property<int?>("TurfID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("TurfID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("dotnetapp.Models.Turf", b =>
                {
                    b.Property<int>("TurfID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TurfID"), 1L, 1);

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurfID");

                    b.ToTable("Turfs");

                    b.HasData(
                        new
                        {
                            TurfID = 1,
                            Availability = true,
                            Capacity = 4,
                            Name = "Green Cricket Meadow"
                        },
                        new
                        {
                            TurfID = 2,
                            Availability = true,
                            Capacity = 6,
                            Name = "Sunny Football Fields"
                        },
                        new
                        {
                            TurfID = 3,
                            Availability = true,
                            Capacity = 2,
                            Name = "Golden Golf Garden"
                        },
                        new
                        {
                            TurfID = 4,
                            Availability = true,
                            Capacity = 10,
                            Name = "Silver Tennis Oasis"
                        },
                        new
                        {
                            TurfID = 5,
                            Availability = true,
                            Capacity = 2,
                            Name = "Blue Basketball Arena"
                        });
                });

            modelBuilder.Entity("dotnetapp.Models.Booking", b =>
                {
                    b.HasOne("dotnetapp.Models.Turf", "Turf")
                        .WithMany("Bookings")
                        .HasForeignKey("TurfID");

                    b.Navigation("Turf");
                });

            modelBuilder.Entity("dotnetapp.Models.Turf", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
