using BethanysPieHRMSApp.Services;
using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components.Pages
{
    public partial class EmployeeOverview:ComponentBase
    {

        private Employee? _selectedEmployee;
        public List<Employee> Employees { get; set; } = new List<Employee>();

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            Employees =  MockDataService.Employees;
        }

        public void ShowQuickView(Employee employee)
        {
            _selectedEmployee = employee;
        }



    }
}
