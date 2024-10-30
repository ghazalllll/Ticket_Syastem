using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ticket_System.Models;

namespace Ticket_System.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityUser> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<IdentityUser> userManager, RoleManager<IdentityUser> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }



        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Register model)
        {
            var user = new IdentityUser { UserName = model.Username, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            
            return Ok("User Registered successful");
        }



        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
                return Unauthorized("Invalid login");

            //var token = new JwtSecurityToken(
            //    );
            //return Ok(new { Token = token });
        }
    }
    
}
