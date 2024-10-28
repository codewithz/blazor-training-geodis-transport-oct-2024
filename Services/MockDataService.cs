using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Services
{
    public class MockDataService
    {
        private static List<Employee>? _employees = default!;
        private static List<JobCategory> _jobCategories = default!;
        private static List<Country> _countries = default!;

        public static List<Employee>? Employees
        {
            get
            {
                _countries ??= InitializeMockCountries();

                _jobCategories ??= InitializeMockJobCategories();

                _employees ??= InitializeMockEmployees();

                return _employees;
            }
        }

        private static List<Employee> InitializeMockEmployees()
        {
            var e1 = new Employee
            {
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategory = _jobCategories[2],
                JobCategoryId = _jobCategories[2].JobCategoryID,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),
                Country = _countries[0],
                CountryId = _countries[0].CountryID,
                IsOnHoliday = false
            };

            var e2 = new Employee
            {
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Antwerp",
                Email = "gill@bethanyspieshop.com",
                EmployeeId = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
                Gender = Gender.Female,
                PhoneNumber = "33999909923",
                Smoker = false,
                Street = "New Street",
                Zip = "2000",
                JobCategory = _jobCategories[1],
                JobCategoryId = _jobCategories[1].JobCategoryID,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24),
                Country = _countries[1],
                CountryId = _countries[1].CountryID,
                IsOnHoliday = false
            };

            return [e1, e2];
        }

        private static List<JobCategory> InitializeMockJobCategories() => [
                new JobCategory{JobCategoryID = 1, JobCategoryName = "Pie research"},
            new JobCategory{JobCategoryID = 2, JobCategoryName = "Sales"},
            new JobCategory{JobCategoryID = 3, JobCategoryName = "Management"},
            new JobCategory{JobCategoryID = 4, JobCategoryName = "Store staff"},
            new JobCategory{JobCategoryID = 5, JobCategoryName = "Finance"},
            new JobCategory{JobCategoryID = 6, JobCategoryName = "QA"},
            new JobCategory{JobCategoryID = 7, JobCategoryName = "IT"},
            new JobCategory{JobCategoryID = 8, JobCategoryName = "Cleaning"},
            new JobCategory{JobCategoryID = 9, JobCategoryName = "Bakery"},
            new JobCategory{JobCategoryID = 9, JobCategoryName = "Bakery"}
            ];

        private static List<Country> InitializeMockCountries() => [
                new Country {CountryID = 1, Name = "Belgium"},
            new Country {CountryID = 2, Name = "Netherlands"},
            new Country {CountryID = 3, Name = "USA"},
            new Country {CountryID = 4, Name = "Japan"},
            new Country {CountryID = 5, Name = "China"},
            new Country {CountryID = 6, Name = "UK"},
            new Country {CountryID = 7, Name = "France"},
            new Country {CountryID = 8, Name = "Brazil"}
            ];
    }
}
