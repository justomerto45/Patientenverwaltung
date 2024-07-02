﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPatientManager;

#nullable disable

namespace MyPatientManager.Migrations
{
    [DbContext(typeof(MyPatientManagerDbContext))]
    partial class MyPatientManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyPatientManager.Model.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Germany",
                            HouseNumber = "123",
                            PostalCode = "12345",
                            Street = "Main Street"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Germany",
                            HouseNumber = "456",
                            PostalCode = "67890",
                            Street = "Second Street"
                        },
                        new
                        {
                            Id = 3,
                            Country = "Austria",
                            HouseNumber = "457",
                            PostalCode = "6800",
                            Street = "hard bodensee"
                        });
                });

            modelBuilder.Entity("MyPatientManager.Model.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Aspirin",
                            Producer = "Pharma Inc."
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ibuprofen",
                            Producer = "MediCorp"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hustensaft",
                            Producer = "Pfizer Inc."
                        });
                });

            modelBuilder.Entity("MyPatientManager.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsUser")
                        .HasColumnType("bit");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SVN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TreatmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FName = "John",
                            IsUser = true,
                            LName = "Doe",
                            Phone = "1234567890",
                            SVN = "1111111111",
                            TreatmentId = 0
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            BirthDate = new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.doe@example.com",
                            FName = "Jane",
                            IsUser = false,
                            LName = "Doe",
                            Phone = "0987654321",
                            SVN = "2222222222",
                            TreatmentId = 0
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            BirthDate = new DateTime(2003, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "musti.oe@hotmail.com",
                            FName = "Mustafa",
                            IsUser = false,
                            LName = "Öztürk",
                            Phone = "0668494979",
                            SVN = "1231314134",
                            TreatmentId = 0
                        });
                });

            modelBuilder.Entity("MyPatientManager.Model.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MedicationId")
                        .HasColumnType("int");

                    b.Property<int>("TreatmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicationId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 10,
                            MedicationId = 1,
                            TreatmentId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 20,
                            MedicationId = 2,
                            TreatmentId = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 500,
                            MedicationId = 3,
                            TreatmentId = 1
                        });
                });

            modelBuilder.Entity("MyPatientManager.Model.Treatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Treatments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 7, 2, 14, 47, 3, 659, DateTimeKind.Local).AddTicks(8667),
                            Notes = "Treatment memo",
                            PersonId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 7, 2, 14, 47, 3, 659, DateTimeKind.Local).AddTicks(8745),
                            Notes = "Anschlag auf Kopf",
                            PersonId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 7, 2, 14, 47, 3, 659, DateTimeKind.Local).AddTicks(8747),
                            Notes = "Erkältung",
                            PersonId = 3
                        });
                });

            modelBuilder.Entity("MyPatientManager.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Pw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Pw = "$2a$11$eI6pQ90TUtrNVmaf4z0GVOSPceWAIEglQ81VFJA8tAqOReIwfu.lW",
                            Username = "johndoe"
                        });
                });

            modelBuilder.Entity("MyPatientManager.Model.Person", b =>
                {
                    b.HasOne("MyPatientManager.Model.Adress", "Adress")
                        .WithMany("Persons")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("MyPatientManager.Model.Prescription", b =>
                {
                    b.HasOne("MyPatientManager.Model.Medication", "Medication")
                        .WithMany("Recipes")
                        .HasForeignKey("MedicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyPatientManager.Model.Treatment", "Treatment")
                        .WithMany("Prescriptions")
                        .HasForeignKey("TreatmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medication");

                    b.Navigation("Treatment");
                });

            modelBuilder.Entity("MyPatientManager.Model.Treatment", b =>
                {
                    b.HasOne("MyPatientManager.Model.Person", "Person")
                        .WithMany("Treatments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MyPatientManager.Model.Adress", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("MyPatientManager.Model.Medication", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("MyPatientManager.Model.Person", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("MyPatientManager.Model.Treatment", b =>
                {
                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}