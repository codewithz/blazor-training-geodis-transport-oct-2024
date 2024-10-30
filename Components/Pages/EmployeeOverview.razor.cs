using BethanysPieHRMSApp.Contracts.Services;
using BethanysPieHRMSApp.Services;
using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components.Pages
{
    public partial class EmployeeOverview : ComponentBase
    {

        private Employee? _selectedEmployee;
        public List<Employee> Employees { get; set; } = new List<Employee>();

        private string Title = "Employee Overview";

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            //await Task.Delay(1000);
            //Employees =  MockDataService.Employees;
            Employees = (await EmployeeService.GetAllEmployees()).ToList();
        }

        public void ShowQuickView(Employee employee)
        {
            _selectedEmployee = employee;
        }



    }
}
