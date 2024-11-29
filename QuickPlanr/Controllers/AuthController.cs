using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace QuickPlanr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly Services.IUserService _userService;

        public AuthController(Services.IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            var isSuccess = await _userService.RegisterUserAsync(model.FirstName, model.LastName, model.Email, model.Password);
            if (!isSuccess)
            {
                return StatusCode(500, "An error occurred while registering the user.");
            }

            return Ok(new { message = "User registered successfully" });
        }
    }

    // Data transfer object (DTO) for the registration
    public class RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
