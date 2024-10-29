using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BethanysPieHRMSApp.Migrations
{
    /// <inheritdoc />
    public partial class NewEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "ImageName", "IsOnHoliday", "JobCategoryId", "JoinedDate", "LastName", "Latitude", "Longitude", "MaritalStatus", "PhoneNumber", "Smoker", "Street", "Zip" },
                values: new object[,]
                {
                    { 2, new DateTime(1983, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amsterdam", "Experienced Software Engineer", 2, "john@company.com", null, "John", 0, null, false, 2, new DateTime(2018, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doe", 52.367600000000003, 4.9040999999999997, 0, "31234567890", false, "Damrak 20", "1012" },
                    { 3, new DateTime(1991, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paris", "Marketing Specialist", 3, "sarah@company.com", null, "Sarah", 1, null, false, 3, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connor", 48.8566, 2.3521999999999998, 1, "33456789012", true, "Champs-Élysées 55", "75008" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);
        }
    }
}
