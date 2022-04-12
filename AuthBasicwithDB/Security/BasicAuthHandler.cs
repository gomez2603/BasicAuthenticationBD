using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Net.Http.Headers;

namespace AuthBasicwithDB.Security
{
    public class BasicAuthHandler :AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IUserService _userService;
        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IUserService userService):base(options, logger, encoder, clock)
        {
            _userService = userService;
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(AuthenticateResult.Fail("No viene el Header"));
            }
            bool result = false;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var creditialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credenciales = Encoding.UTF8.GetString(creditialBytes).Split(new[] { ':' }, 2);
                var email = credenciales[0];
                var password = credenciales[1];
                result =  _userService.IsUser(email, password);
      
                

            }
            catch (Exception ex)
            {
                return Task.FromResult(AuthenticateResult.Fail("Ocurrio Algo"));
            }
            if (!result)
            {
                return Task.FromResult(AuthenticateResult.Fail("Usuario o Contraseña Invalido"));
            }
            var Claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier,"Id"),
                new Claim(ClaimTypes.Name, "User")
            };
            var identity = new ClaimsIdentity(Claims, Scheme.Name);
            var principal  = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return Task.FromResult(AuthenticateResult.Success(ticket));
        }

      
    }
}
