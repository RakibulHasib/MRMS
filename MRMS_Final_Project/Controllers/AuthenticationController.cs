using Microsoft.AspNetCore.Mvc;
using MRMS.Model.Authentication;
using MRMS_Final_Project.Services;

namespace MRMS_Final_Project.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticateService _authenticateService;
        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            var user = _authenticateService.Authenticate(model.UserName, model.Password);
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(user);
            }
        }
    }
}
