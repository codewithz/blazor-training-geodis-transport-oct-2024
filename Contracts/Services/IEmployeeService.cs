using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Contracts.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
