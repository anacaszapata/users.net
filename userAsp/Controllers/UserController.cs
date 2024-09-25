using Microsoft.AspNetCore.Mvc;
using userAsp.Services;

namespace userAsp.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.Get();
            return Ok(users);
        }
    }
}


