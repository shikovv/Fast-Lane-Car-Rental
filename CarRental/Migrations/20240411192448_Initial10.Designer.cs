﻿// <auto-generated />
using System;
using CarRental.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRental.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240411192448_Initial10")]
    partial class Initial10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarRental.Data.Domain.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "18c4b810-f4cf-4703-9b00-86ec2085f1c9",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Stefan",
                            LastName = "Shikov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAENMsYK3cU4YkyPGQavSwM3u6JIdY0tOFO0HQbnHwNsAo77KIvPDKp63aSh8r479g/g==",
                            PhoneNumber = "0988360889",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "215ae6d9-7462-4ea6-83fe-f53314b48f7f",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc14491b-310a-4b47-8bd6-b9885ae15d15",
                            Email = "ivan.ivanov@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            LockoutEnabled = false,
                            NormalizedEmail = "IVAN.IVANOV@GMAIL.COM",
                            NormalizedUserName = "IVAN IVANOV",
                            PasswordHash = "AQAAAAEAACcQAAAAEBxltIVXIBp+4qeQgnNoylObGXFIwcNR+DFKmyruwGGjTyRXvHnomXmsw4uULF0WWA==",
                            PhoneNumber = "0899999999",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "66d93f64-5c26-4585-ae62-3c6461d200f8",
                            TwoFactorEnabled = false,
                            UserName = "Ivan Ivanov"
                        },
                        new
                        {
                            Id = new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1796e3e8-cf33-4cf6-8571-62bbcbcb484f",
                            Email = "pesho_petrov@yahoo.com",
                            EmailConfirmed = false,
                            FirstName = "Pesho",
                            LastName = "Petrov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PESHO_PETROV@YAHOO.COM",
                            NormalizedUserName = "PESHO_PETROV",
                            PasswordHash = "AQAAAAEAACcQAAAAEMVGyCSTmA3qMqiY4DGVRYIdJ7u+oTXC9lIOFMDMW/wDV7ukr/U1BaoTDL7V1sTMSA==",
                            PhoneNumber = "0877777777",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4747394c-3e11-4395-b3cc-ddfa99b7b58b",
                            TwoFactorEnabled = false,
                            UserName = "pesho_petrov"
                        });
                });

            modelBuilder.Entity("CarRental.Data.Domain.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AccelerationTo100")
                        .HasColumnType("float");

                    b.Property<int>("BodyType")
                        .HasColumnType("int");

                    b.Property<double>("ConsumptionPer100Km")
                        .HasColumnType("float");

                    b.Property<int>("CylindersNumber")
                        .HasColumnType("int");

                    b.Property<int>("Displacement")
                        .HasColumnType("int");

                    b.Property<int>("EngineAspirationType")
                        .HasColumnType("int");

                    b.Property<int>("EngineFuelType")
                        .HasColumnType("int");

                    b.Property<int>("EngineStructureType")
                        .HasColumnType("int");

                    b.Property<int>("Horsepower")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeakHorsepowerAtRPM")
                        .HasColumnType("int");

                    b.Property<int>("PeakTorqueAtRPM")
                        .HasColumnType("int");

                    b.Property<double>("PricePerDay")
                        .HasColumnType("float");

                    b.Property<Guid?>("RenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("SafetyRating")
                        .HasColumnType("float");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<int>("TopSpeed")
                        .HasColumnType("int");

                    b.Property<int>("Torque")
                        .HasColumnType("int");

                    b.Property<int>("TransmissionType")
                        .HasColumnType("int");

                    b.Property<int>("YearOfProduction")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RenterId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bdf5c65f-4470-4139-8ec3-8c3baf0e34d6"),
                            AccelerationTo100 = 14.1,
                            BodyType = 2,
                            ConsumptionPer100Km = 6.2999999999999998,
                            CylindersNumber = 4,
                            Displacement = 1300,
                            EngineAspirationType = 0,
                            EngineFuelType = 0,
                            EngineStructureType = 0,
                            Horsepower = 70,
                            ImageURL = "https://parkers-images.bauersecure.com/wp-images/2148/cut-out/930x620/st05.jpg",
                            IsActive = false,
                            Make = "Ford",
                            Mileage = 260000,
                            Model = "Fiesta MK5",
                            PeakHorsepowerAtRPM = 5000,
                            PeakTorqueAtRPM = 2800,
                            PricePerDay = 59.0,
                            SafetyRating = 5.9000000000000004,
                            Seats = 5,
                            TopSpeed = 180,
                            Torque = 106,
                            TransmissionType = 0,
                            YearOfProduction = 2004
                        },
                        new
                        {
                            Id = new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4817"),
                            AccelerationTo100 = 8.6999999999999993,
                            BodyType = 0,
                            ConsumptionPer100Km = 8.6999999999999993,
                            CylindersNumber = 4,
                            Displacement = 2000,
                            EngineAspirationType = 0,
                            EngineFuelType = 0,
                            EngineStructureType = 0,
                            Horsepower = 122,
                            ImageURL = "https://i.pinimg.com/736x/bd/f1/67/bdf167075cbba99b9eeed9393ba24d65.jpg",
                            IsActive = false,
                            Make = "Mercedes",
                            Mileage = 460000,
                            Model = "190E",
                            PeakHorsepowerAtRPM = 5300,
                            PeakTorqueAtRPM = 3500,
                            PricePerDay = 239.0,
                            SafetyRating = 9.0999999999999996,
                            Seats = 5,
                            TopSpeed = 230,
                            Torque = 178,
                            TransmissionType = 1,
                            YearOfProduction = 1991
                        },
                        new
                        {
                            Id = new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2076"),
                            AccelerationTo100 = 9.8000000000000007,
                            BodyType = 0,
                            ConsumptionPer100Km = 7.5,
                            CylindersNumber = 4,
                            Displacement = 2000,
                            EngineAspirationType = 1,
                            EngineFuelType = 3,
                            EngineStructureType = 0,
                            Horsepower = 140,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG/1280px-VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG",
                            IsActive = false,
                            Make = "Volkswagen",
                            Mileage = 120000,
                            Model = "Passat B7",
                            PeakHorsepowerAtRPM = 4200,
                            PeakTorqueAtRPM = 2500,
                            PricePerDay = 99.0,
                            SafetyRating = 7.2000000000000002,
                            Seats = 5,
                            TopSpeed = 211,
                            Torque = 320,
                            TransmissionType = 1,
                            YearOfProduction = 2014
                        });
                });

            modelBuilder.Entity("CarRental.Data.Domain.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StarsRating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                            CreatedOn = new DateTime(2024, 4, 11, 22, 24, 47, 622, DateTimeKind.Local).AddTicks(9621),
                            CreatorId = new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                            Description = "Exceptional service from Fast Lane Car Rental! The rental process was seamless, and the car exceeded my expectations. Will definitely be using their services again!",
                            StarsRating = 5,
                            Title = "Reccomend it!"
                        },
                        new
                        {
                            Id = new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                            CreatedOn = new DateTime(2024, 4, 11, 22, 24, 47, 622, DateTimeKind.Local).AddTicks(9672),
                            CreatorId = new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                            Description = "Fast Lane Car Rental made my trip an absolute breeze! Their extensive selection of vehicles ensured I found the perfect ride for my adventure. The seamless rental process and friendly staff made the experience top-notch. Highly recommend!",
                            StarsRating = 4,
                            Title = "The best in the business!"
                        },
                        new
                        {
                            Id = new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                            CreatedOn = new DateTime(2024, 4, 11, 22, 24, 47, 622, DateTimeKind.Local).AddTicks(9678),
                            CreatorId = new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                            Description = "My experience with Fast Lane Car Rental exceeded all expectations. From booking to drop-off, everything was flawless. The quality of their vehicles and the professionalism of their team truly set them apart. Will definitely be returning for my future rental needs!",
                            StarsRating = 4,
                            Title = "Awesome!"
                        });
                });

            modelBuilder.Entity("CarRental.Data.Domain.Rental", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Deposit")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("CarRental.Data.Domain.UserRental", b =>
                {
                    b.Property<Guid>("RentalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RentalId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("UserRentals");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                            ConcurrencyStamp = "3f6b1ba5-efe1-4b13-bdc9-02f70b20b61c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                            RoleId = new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CarRental.Data.Domain.Car", b =>
                {
                    b.HasOne("CarRental.Data.Domain.ApplicationUser", "Renter")
                        .WithMany()
                        .HasForeignKey("RenterId");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("CarRental.Data.Domain.Comment", b =>
                {
                    b.HasOne("CarRental.Data.Domain.ApplicationUser", "Creator")
                        .WithMany("Comments")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("CarRental.Data.Domain.Rental", b =>
                {
                    b.HasOne("CarRental.Data.Domain.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarRental.Data.Domain.UserRental", b =>
                {
                    b.HasOne("CarRental.Data.Domain.ApplicationUser", "ApplicationUser")
                        .WithMany("UserRentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental.Data.Domain.Rental", "Rental")
                        .WithMany("UserRentals")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("CarRental.Data.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("CarRental.Data.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental.Data.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("CarRental.Data.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRental.Data.Domain.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("UserRentals");
                });

            modelBuilder.Entity("CarRental.Data.Domain.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("CarRental.Data.Domain.Rental", b =>
                {
                    b.Navigation("UserRentals");
                });
#pragma warning restore 612, 618
        }
    }
}
