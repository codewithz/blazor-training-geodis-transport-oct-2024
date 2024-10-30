using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components.Pages
{
    public partial class EmployeeAdd
    {
        [SupplyParameterFromForm]
        public Employee Employee { get; set; }

        protected override void OnInitialized()
        {
            Employee ??= new();
        }

        private async Task OnSubmit()
        { 
        }


    }
}
