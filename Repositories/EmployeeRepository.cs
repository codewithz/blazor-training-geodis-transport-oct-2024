using BethanysPieHRMSApp.Contracts.Repositories;
using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
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
