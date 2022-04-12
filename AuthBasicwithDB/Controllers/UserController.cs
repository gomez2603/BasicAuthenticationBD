using AuthBasicwithDB.Models;
using AuthBasicwithDB.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthBasicwithDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Register([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Insert(user);
                return Ok("Se Registro el ususario " + user.Email);

            }
            return BadRequest("Formato Invalido");

        }


     
    }
}
