﻿// <auto-generated />
using System;
using EmployeeManagmentSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagmentSystem.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241027164127_data-seeding")]
    partial class dataseeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagmentSystem.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Email = "mohamed.ali@example.com",
                            FirstName = "Mohamed",
                            HireDate = new DateOnly(2020, 1, 15),
                            JobTitle = "Software Developer",
                            LastName = "Ali",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Email = "fatima.hassan@example.com",
                            FirstName = "Fatima",
                            HireDate = new DateOnly(2019, 6, 10),
                            JobTitle = "Project Manager",
                            LastName = "Hassan",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Email = "amina.hussein@example.com",
                            FirstName = "Amina",
                            HireDate = new DateOnly(2021, 3, 22),
                            JobTitle = "Business Analyst",
                            LastName = "Hussein",
                            PhoneNumber = "2345678901"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Email = "omar.khaled@example.com",
                            FirstName = "Omar",
                            HireDate = new DateOnly(2022, 8, 30),
                            JobTitle = "UX Designer",
                            LastName = "Khaled",
                            PhoneNumber = "3456789012"
                        },
                        new
                        {
                            EmployeeId = 5,
                            Email = "sara.mohamed@example.com",
                            FirstName = "Sara",
                            HireDate = new DateOnly(2023, 2, 12),
                            JobTitle = "Data Scientist",
                            LastName = "Mohamed",
                            PhoneNumber = "4567890123"
                        },
                        new
                        {
                            EmployeeId = 6,
                            Email = "youssef.ibrahim@example.com",
                            FirstName = "Youssef",
                            HireDate = new DateOnly(2020, 5, 19),
                            JobTitle = "System Administrator",
                            LastName = "Ibrahim",
                            PhoneNumber = "5678901234"
                        },
                        new
                        {
                            EmployeeId = 7,
                            Email = "layla.said@example.com",
                            FirstName = "Layla",
                            HireDate = new DateOnly(2021, 7, 14),
                            JobTitle = "Marketing Specialist",
                            LastName = "Said",
                            PhoneNumber = "6789012345"
                        },
                        new
                        {
                            EmployeeId = 8,
                            Email = "hassan.nasser@example.com",
                            FirstName = "Hassan",
                            HireDate = new DateOnly(2019, 11, 1),
                            JobTitle = "HR Manager",
                            LastName = "Nasser",
                            PhoneNumber = "7890123456"
                        },
                        new
                        {
                            EmployeeId = 9,
                            Email = "salma.fathy@example.com",
                            FirstName = "Salma",
                            HireDate = new DateOnly(2022, 4, 25),
                            JobTitle = "QA Engineer",
                            LastName = "Fathy",
                            PhoneNumber = "8901234567"
                        },
                        new
                        {
                            EmployeeId = 10,
                            Email = "khaled.samir@example.com",
                            FirstName = "Khaled",
                            HireDate = new DateOnly(2023, 1, 30),
                            JobTitle = "Sales Associate",
                            LastName = "Samir",
                            PhoneNumber = "9012345678"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
