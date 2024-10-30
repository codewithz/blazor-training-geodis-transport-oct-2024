using BethanysPieHRMSApp.Contracts.Services;
using BethanysPieHRMSApp.Services;
using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components.Pages
{
    public partial class EmployeeDetail:ComponentBase
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } =new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
            Employee = await EmployeeService.GetEmployeeById(EmployeeId);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }

    }
}
