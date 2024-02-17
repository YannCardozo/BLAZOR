using Microsoft.JSInterop;

namespace Justo.Utils
{
    public static class IJSRuntimeExtensions
    {
        //insere o token dentro do localstorage do usuário
        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content) => js.InvokeAsync<object>("localStorage.setItem",key, content);

        //obtêm o token
        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key) => js.InvokeAsync<string>("localstorage.getItem", key);

        //remove o token
        public static ValueTask<object> RemoveFromLocalStorage(this IJSRuntime js, string key) => js.InvokeAsync<object>("localstorage.removeItem", key);
    }
}
