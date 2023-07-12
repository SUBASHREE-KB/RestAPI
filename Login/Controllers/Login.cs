using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private const string Username = "Subashree";
        private const string Password = "password";

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (user.Username == Username && user.Password == Password)
            {
                return StatusCode(201,"Ok");
            }

            return StatusCode(404,"Incorrect username or password");
        }
    }
}