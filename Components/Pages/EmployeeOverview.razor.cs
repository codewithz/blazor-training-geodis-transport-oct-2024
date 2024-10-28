using BethanysPieHRMSApp.Services;
using BethanysPieHRMSApp.Shared.Domain;

namespace BethanysPieHRMSApp.Components.Pages
{
    public partial class EmployeeOverview
    {

        public List<Employee> Employees { get; set; }=default!;

        protected override async Task OnInitializedAsync()
        {
            Employees =  MockDataService.Employees;
        }
    }
}
