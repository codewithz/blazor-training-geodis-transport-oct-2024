using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieHRMSApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; } 

        public DbSet<JobCategory> JobCategories { get; set; } 

        public DbSet<Country> Countries { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);


            //seed categories
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 1, Name = "Belgium" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 2, Name = "Germany" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 3, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 4, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 5, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 6, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 7, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 8, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryID = 9, Name = "Brazil" });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 1, JobCategoryName = "Pie research" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 2, JobCategoryName = "Sales" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 3, JobCategoryName = "Management" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 4, JobCategoryName = "Store staff" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 5, JobCategoryName = "Finance" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 6, JobCategoryName = "QA" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 7, JobCategoryName = "IT" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 8, JobCategoryName = "Cleaning" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryID = 9, JobCategoryName = "Bakery" });


       
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    CountryId = 1,
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1979, 1, 16),
                    City = "Brussels",
                    Email = "bethany@bethanyspieshop.com",
                    FirstName = "Bethany",
                    LastName = "Smith",
                    Gender = Gender.Female,
                    PhoneNumber = "324777888773",
                    Smoker = false,
                    Street = "Grote Markt 1",
                    Zip = "1000",
                    JobCategoryId = 1,
                    Comment = "Lorem Ipsum",
                    ExitDate = null,
                    JoinedDate = new DateTime(2015, 3, 1),
                    Latitude = 50.8503,
                    Longitude = 4.3517
                },
                new Employee
                {
                    EmployeeId = 2,
                    CountryId = 2,
                    MaritalStatus = MaritalStatus.Married,
                    BirthDate = new DateTime(1983, 5, 21),
                    City = "Amsterdam",
                    Email = "john@company.com",
                    FirstName = "John",
                    LastName = "Doe",
                    Gender = Gender.Male,
                    PhoneNumber = "31234567890",
                    Smoker = false,
                    Street = "Damrak 20",
                    Zip = "1012",
                    JobCategoryId = 2,
                    Comment = "Experienced Software Engineer",
                    ExitDate = null,
                    JoinedDate = new DateTime(2018, 7, 15),
                    Latitude = 52.3676,
                    Longitude = 4.9041
                },
                new Employee
                {
                    EmployeeId = 3,
                    CountryId = 3,
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1991, 2, 12),
                    City = "Paris",
                    Email = "sarah@company.com",
                    FirstName = "Sarah",
                    LastName = "Connor",
                    Gender = Gender.Female,
                    PhoneNumber = "33456789012",
                    Smoker = true,
                    Street = "Champs-Élysées 55",
                    Zip = "75008",
                    JobCategoryId = 3,
                    Comment = "Marketing Specialist",
                    ExitDate = null,
                    JoinedDate = new DateTime(2020, 1, 20),
                    Latitude = 48.8566,
                    Longitude = 2.3522
                }
            
            );
        }


    }
}
