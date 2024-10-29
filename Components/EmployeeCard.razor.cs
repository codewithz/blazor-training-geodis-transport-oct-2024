using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; }
    }
}
