using BethanysPieHRMSApp.Contracts.Repositories;
using BethanysPieHRMSApp.Contracts.Services;
using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
