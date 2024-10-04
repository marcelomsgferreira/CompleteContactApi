﻿// <auto-generated />
using System;
using App.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Database.Migrations
{
    [DbContext(typeof(ContactsDbContext))]
    partial class ContactsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressType = "Home",
                            City = "New York",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(4792),
                            PostalCode = "10001",
                            State = "NY",
                            Street = "123 Main Street"
                        },
                        new
                        {
                            Id = 2,
                            AddressType = "Work",
                            City = "Los Angeles",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(4845),
                            PostalCode = "90001",
                            State = "CA",
                            Street = "456 Oak Avenue"
                        },
                        new
                        {
                            Id = 3,
                            AddressType = "Billing",
                            City = "Chicago",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(4848),
                            PostalCode = "60601",
                            State = "IL",
                            Street = "789 Pine Road"
                        });
                });

            modelBuilder.Entity("App.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5049),
                            DateOfBirth = new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "(123) 456-7890"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5052),
                            DateOfBirth = new DateTime(1985, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Phone = "(234) 567-8901"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5055),
                            DateOfBirth = new DateTime(1995, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michael.brown@example.com",
                            FirstName = "Michael",
                            LastName = "Brown",
                            Phone = "(345) 678-9012"
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 1,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5059),
                            DateOfBirth = new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emily.davis@example.com",
                            FirstName = "Emily",
                            LastName = "Davis",
                            Phone = "(456) 789-0123"
                        },
                        new
                        {
                            Id = 5,
                            AddressId = 2,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5062),
                            DateOfBirth = new DateTime(1987, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "david.miller@example.com",
                            FirstName = "David",
                            LastName = "Miller",
                            Phone = "(567) 890-1234"
                        },
                        new
                        {
                            Id = 6,
                            AddressId = 3,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5064),
                            DateOfBirth = new DateTime(1993, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarah.wilson@example.com",
                            FirstName = "Sarah",
                            LastName = "Wilson",
                            Phone = "(678) 901-2345"
                        },
                        new
                        {
                            Id = 7,
                            AddressId = 1,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5066),
                            DateOfBirth = new DateTime(1989, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "christopher.moore@example.com",
                            FirstName = "Christopher",
                            LastName = "Moore",
                            Phone = "(789) 012-3456"
                        });
                });

            modelBuilder.Entity("App.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ContactsGroup");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5003),
                            Description = "Family members and relatives",
                            Name = "Family"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5007),
                            Description = "Close and personal friends",
                            Name = "Friends"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5009),
                            Description = "Colleagues from work",
                            Name = "Work"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5011),
                            Description = "Business clients and partners",
                            Name = "Clients"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 10, 2, 18, 6, 5, 131, DateTimeKind.Local).AddTicks(5015),
                            Description = "Suppliers and vendors for business",
                            Name = "Suppliers"
                        });
                });

            modelBuilder.Entity("ContactGroup", b =>
                {
                    b.Property<int>("ContactsId")
                        .HasColumnType("int");

                    b.Property<int>("GroupsId")
                        .HasColumnType("int");

                    b.HasKey("ContactsId", "GroupsId");

                    b.HasIndex("GroupsId");

                    b.ToTable("ContactGroup");
                });

            modelBuilder.Entity("App.Entities.Contact", b =>
                {
                    b.HasOne("App.Entities.Address", "Address")
                        .WithMany("Contacts")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("ContactGroup", b =>
                {
                    b.HasOne("App.Entities.Contact", null)
                        .WithMany()
                        .HasForeignKey("ContactsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Entities.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Entities.Address", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
