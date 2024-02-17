using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Justo.Auth
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(1000);
            //indicamos se o usuário esta autenticado e os seus claims tb
            //

            //aqui é fornecida a autenticação e autorização para o usuário.

            //o role será atribuído ao usuário e o blazor irá entender como exatamente o perfil.
            var usuario = new ClaimsIdentity(new List<Claim>()
            {
                new Claim("Chave", "Valor"),
                new Claim(ClaimTypes.Name, "Yann"),
                new Claim(ClaimTypes.Role, "Admin")
            });


            //este método vai ser executado quando o usuário executar a aplicação.
            //aqui é  verificado a identidade do usuário
            return await Task.FromResult(new AuthenticationState(
                new ClaimsPrincipal(usuario)));
        
        }
    }
}
