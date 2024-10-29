using Microsoft.AspNetCore.Components;

namespace BethanysPieHRMSApp.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
