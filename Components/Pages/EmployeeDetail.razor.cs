using BethanysPieHRMSApp.Contracts.Services;
using BethanysPieHRMSApp.Services;
using BethanysPieHRMSApp.Shared.Domain;
using BethanysPieHRMSApp.Shared.Model;
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

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected async override Task OnInitializedAsync()
        {
            //Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
            Employee = await EmployeeService.GetEmployeeById(EmployeeId);

            if(Employee.Latitude.HasValue && Employee.Longitude.HasValue)
            {
                MapMarkers = new List<Marker>
                {
                    new Marker
                    {
                        Description=$"{Employee.FirstName} {Employee.LastName}",
                        ShowPopup=false,
                        X=(double)Employee.Longitude,
                        Y=(double)Employee.Latitude

                    }
                };
            }

        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }

    }
}
