using BethanysPieHRMSApp.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }

        private Employee? _employee;

        protected override void OnParametersSet()
        {
            _employee = Employee;
        }

        public void ClosePopup()
        {
            _employee = null;
        }
    }
}
