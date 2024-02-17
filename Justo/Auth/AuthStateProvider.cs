using Justo.Utils;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace Justo.Auth
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        //private readonly IJSRuntime js;
        //private readonly HttpClient http;
        //public static readonly string tokenKey = "tokenKey";

        //public AuthStateProvider(IJSRuntime jSRuntime , HttpClient httpClient)
        //{
        //    js = jSRuntime;
        //    http = httpClient;

        //}
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

        //private AuthenticationState notAuthenticate => new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

        //public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    //obtem o token de authenticacao do usuario
        //    var token = await js.GetFromLocalStorage(tokenKey);
        //    if(string.IsNullOrEmpty(token))
        //    {
        //        return notAuthenticate;
        //    }

        //    //caso não exista, criamos um
        //    return CreateAuthenticationState(token);
        //}

        //public AuthenticationState CreateAuthenticationState(string TOKEN)
        //{
        //    //token obtido no localstorage no header do request
        //    //na seção authorization assim autenticando cada
        //    //requisição http enviada ao servidor
        //    http.DefaultRequestHeaders.Authorization =
        //        new AuthenticationHeaderValue("bearer", TOKEN);

        //    //extrair as claims do token

        //    return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(
        //        ParseClaimsFromJwt(TOKEN), "jwt")));
        //}

        //private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        //{
        //    var claims = new List<Claim>();
        //    var payload = jwt.Split('.')[1];
        //    var jsonBytes = ParseBase64WithoutPadding(payload);
        //    var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

        //    keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);
        //    if(roles != null)
        //    {
        //        if(roles.ToString().Trim().StartsWith("["))
        //        {
        //            var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());
        //            foreach(var parsedRole in parsedRoles)
        //            {
        //                claims.Add(new Claim(ClaimTypes.Role, parsedRole));
        //            }
        //        }
        //        else
        //        {
        //            claims.Add(new Claim(ClaimTypes.Role,roles.ToString()));
        //        }
        //        keyValuePairs.Remove(ClaimTypes.Role);
        //    }

        //    claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
        //    return claims;

        //}


        //private byte[] ParseBase64WithoutPadding(string base64)
        //{
        //    switch (base64.Length % 4)
        //    {

        //        case 2: base64 += "==";break;
        //        case 3: base64 += "="; break;
            
        //    }
        //    return Convert.FromBase64String(base64);

        //}
    }
}
