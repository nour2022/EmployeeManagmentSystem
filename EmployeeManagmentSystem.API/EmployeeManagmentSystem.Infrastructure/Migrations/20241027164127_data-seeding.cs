using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagmentSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "FirstName", "HireDate", "JobTitle", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "mohamed.ali@example.com", "Mohamed", new DateOnly(2020, 1, 15), "Software Developer", "Ali", "1234567890" },
                    { 2, "fatima.hassan@example.com", "Fatima", new DateOnly(2019, 6, 10), "Project Manager", "Hassan", "0987654321" },
                    { 3, "amina.hussein@example.com", "Amina", new DateOnly(2021, 3, 22), "Business Analyst", "Hussein", "2345678901" },
                    { 4, "omar.khaled@example.com", "Omar", new DateOnly(2022, 8, 30), "UX Designer", "Khaled", "3456789012" },
                    { 5, "sara.mohamed@example.com", "Sara", new DateOnly(2023, 2, 12), "Data Scientist", "Mohamed", "4567890123" },
                    { 6, "youssef.ibrahim@example.com", "Youssef", new DateOnly(2020, 5, 19), "System Administrator", "Ibrahim", "5678901234" },
                    { 7, "layla.said@example.com", "Layla", new DateOnly(2021, 7, 14), "Marketing Specialist", "Said", "6789012345" },
                    { 8, "hassan.nasser@example.com", "Hassan", new DateOnly(2019, 11, 1), "HR Manager", "Nasser", "7890123456" },
                    { 9, "salma.fathy@example.com", "Salma", new DateOnly(2022, 4, 25), "QA Engineer", "Fathy", "8901234567" },
                    { 10, "khaled.samir@example.com", "Khaled", new DateOnly(2023, 1, 30), "Sales Associate", "Samir", "9012345678" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);
        }
    }
}
