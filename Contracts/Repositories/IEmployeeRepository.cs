using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);

        Task<Employee> AddEmployee(Employee employee);
    }
}
