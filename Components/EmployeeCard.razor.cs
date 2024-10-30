using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        protected override void OnInitialized()
        {
            //if (string.IsNullOrEmpty(Employee.LastName))
            //{
            //    throw new Exception("Last name is required");
            //}
        }
    }
}
