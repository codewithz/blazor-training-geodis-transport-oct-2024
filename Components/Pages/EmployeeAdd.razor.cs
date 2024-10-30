using BethanysPieHRMSApp.Contracts.Services;
using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components.Pages
{
    public partial class EmployeeAdd
    {
        [SupplyParameterFromForm]
        public Employee Employee { get; set; }

        [Inject]
        public IEmployeeService? EmployeeService { get; set; }

        public bool IsSaved = false;

        public string Message=string.Empty;

        protected override void OnInitialized()
        {
            Employee ??= new();
        }

        private async Task OnSubmit()
        {
            await EmployeeService.AddEmployee(Employee);
            IsSaved = true;
            Message = "Employee added successfully!";

        }


    }
}
