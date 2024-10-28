using BethanysPieHRMSApp.Services;
using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Components.Pages
{
    public partial class EmployeeOverview
    {

        public List<Employee> Employees { get; set; } = new List<Employee>();

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            Employees =  MockDataService.Employees;
        }
    }
}
