using BethanysPieHRMSApp.Contracts.Repositories;
using BethanysPieHRMSApp.Contracts.Services;
using BethanysPieHRMSApp.Data;
using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        public Task<Employee> GetEmployeeById(int employeeId)
        {
            return _employeeRepository.GetEmployeeById(employeeId); 
        }
    }
}
