using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiAplicationForIS.Core.Interfaces;
using MultiAplicationForIS.WebApi.ModelApi;

namespace MultiAplicationForIS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        IUserService _userService;
        public AuthorizationController(IUserService service)
        {
            _userService = service;
        }


        [HttpPatch]
        public ActionResult<UserRespons> GetUser (UserAuthorizationRequst requst)
        {

        }


    }
}
