using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Lista_de_Tarefas_Blazor.Base
{
    public class PageBase : ComponentBase
    {
        [Inject] public IJSRuntime JSRuntime { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
    }
}
