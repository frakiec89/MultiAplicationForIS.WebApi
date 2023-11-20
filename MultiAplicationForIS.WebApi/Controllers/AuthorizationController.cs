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

        [HttpPost]
        public ActionResult<UserRespons> GetUser (UserAuthorizationRequst requst)
        {
            try
            {
                var userCore = _userService.GetUser(requst.Emeil, requst.Password);
                return Ok(new UserRespons
                {
                    Password = userCore.Password
                ,
                    Email = userCore.Email,
                    Name = userCore.Name,
                    Id = userCore.Id
                });
            }
            catch (Exception ex)
            {
                return  BadRequest(ex.Message);
            }
        }
    }
}
