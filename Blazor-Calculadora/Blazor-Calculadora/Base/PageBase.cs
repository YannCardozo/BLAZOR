using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor_Calculadora.Base.PageBase;

public class PageBase : ComponentBase
{
    [Inject] public IJSRuntime JSRuntime { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }
}