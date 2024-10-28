using EmployeeManagmentSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
       public DbSet<Employee> Employees { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeId)
                .ValueGeneratedOnAdd();



            modelBuilder.Entity<Employee>().HasData(
         new Employee
         {
             EmployeeId = 1,
             FirstName = "Mohamed",
             LastName = "Ali",
             Email = "mohamed.ali@example.com",
             PhoneNumber = "1234567890",
             JobTitle = "Software Developer",
             HireDate = new DateOnly(2020, 1, 15)
         },
         new Employee
         {
             EmployeeId = 2,
             FirstName = "Fatima",
             LastName = "Hassan",
             Email = "fatima.hassan@example.com",
             PhoneNumber = "0987654321",
             JobTitle = "Project Manager",
             HireDate = new DateOnly(2019, 6, 10)
         },
         new Employee
         {
             EmployeeId = 3,
             FirstName = "Amina",
             LastName = "Hussein",
             Email = "amina.hussein@example.com",
             PhoneNumber = "2345678901",
             JobTitle = "Business Analyst",
             HireDate = new DateOnly(2021, 3, 22)
         },
         new Employee
         {
             EmployeeId = 4,
             FirstName = "Omar",
             LastName = "Khaled",
             Email = "omar.khaled@example.com",
             PhoneNumber = "3456789012",
             JobTitle = "UX Designer",
             HireDate = new DateOnly(2022, 8, 30)
         },
         new Employee
         {
             EmployeeId = 5,
             FirstName = "Sara",
             LastName = "Mohamed",
             Email = "sara.mohamed@example.com",
             PhoneNumber = "4567890123",
             JobTitle = "Data Scientist",
             HireDate = new DateOnly(2023, 2, 12)
         },
         new Employee
         {
             EmployeeId = 6,
             FirstName = "Youssef",
             LastName = "Ibrahim",
             Email = "youssef.ibrahim@example.com",
             PhoneNumber = "5678901234",
             JobTitle = "System Administrator",
             HireDate = new DateOnly(2020, 5, 19)
         },
         new Employee
         {
             EmployeeId = 7,
             FirstName = "Layla",
             LastName = "Said",
             Email = "layla.said@example.com",
             PhoneNumber = "6789012345",
             JobTitle = "Marketing Specialist",
             HireDate = new DateOnly(2021, 7, 14)
         },
         new Employee
         {
             EmployeeId = 8,
             FirstName = "Hassan",
             LastName = "Nasser",
             Email = "hassan.nasser@example.com",
             PhoneNumber = "7890123456",
             JobTitle = "HR Manager",
             HireDate = new DateOnly(2019, 11, 1)
         },
         new Employee
         {
             EmployeeId = 9,
             FirstName = "Salma",
             LastName = "Fathy",
             Email = "salma.fathy@example.com",
             PhoneNumber = "8901234567",
             JobTitle = "QA Engineer",
             HireDate = new DateOnly(2022, 4, 25)
         },
         new Employee
         {
             EmployeeId = 10,
             FirstName = "Khaled",
             LastName = "Samir",
             Email = "khaled.samir@example.com",
             PhoneNumber = "9012345678",
             JobTitle = "Sales Associate",
             HireDate = new DateOnly(2023, 1, 30)
         }
     );
            base.OnModelCreating(modelBuilder);

        }
    }
    }
