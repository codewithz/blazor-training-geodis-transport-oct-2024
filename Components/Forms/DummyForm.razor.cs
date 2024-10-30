using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components.Forms
{
    public partial class DummyForm:ComponentBase
    {
        public Employee Employee { get; set; } 

        protected override async Task OnInitializedAsync()
        {
            Employee = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
            };
          
        }

        public void Save()
        {
            Employee.FirstName = "Zartab";
        }
    }
}
