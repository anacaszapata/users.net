using Microsoft.AspNetCore.Mvc;
using userAsp.Services;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(
            Summary = "Obtiene todos los usuarios.",
            Description = "Este endpoint devuelve una lista de todos los usuarios en el sistema."
        )]
        [SwaggerResponse(200, "La lista de usuarios fue recuperada exitosamente.")]
        [SwaggerResponse(500, "Error interno del servidor.")]
        public IActionResult Get()
        {
            var users = _userService.Get();
            return Ok(users);
        }
    }
}


