using Justo.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Justo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;
        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        [HttpGet]
        public string Get()
        {
            return $"Account Controller :: {DateTime.Now.ToShortDateString()}";
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserToken>> Register([FromBody] UserInfo model)
        {
            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {

                return GenerateToken(model);
            }
            else
            {
                var errors = result.Errors.Select(e => e.Description);
                var errorMessage = string.Join(", ", errors);

                return BadRequest(new { message = $"Erro ao registrar usuário: {errorMessage}" });
            }
        }


        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] UserInfo userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.Email
                , userInfo.Password, isPersistent: false, lockoutOnFailure: false);

            //salva email
            //salva senha
            //nao persistir os cookies se fechar o browser
            //não travar o usuaário caso ele não consiga logar

            if (result.Succeeded)
            {

                return GenerateToken(userInfo);
            }
            else
            {
                return BadRequest(new { message = "Senha ou usuário incorreto" });
            }
        }

        private UserToken GenerateToken(UserInfo userInfo)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
                new Claim(ClaimTypes.Name, userInfo.Email),
                new Claim("Yann", "yann_cardozo.com"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));

            //tipo de criptografia utilizada no token. SHA256 no caso
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            //tempo de validade do token
            var expiration = DateTime.Now.AddHours(2);
            var message = "Token JWT criado com sucesso";


            JwtSecurityToken token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: creds);


            //cria o objeto UserToken com data de validade, messagem de validação
            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration,
                Message = message
            };
        }
    }
}