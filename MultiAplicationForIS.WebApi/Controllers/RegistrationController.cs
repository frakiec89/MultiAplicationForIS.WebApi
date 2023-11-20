using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiAplicationForIS.Core.Interfaces;

namespace MultiAplicationForIS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        IUserService _userService;
        public RegistrationController(IUserService service)
        {
          _userService = service;   
        }

        [HttpPost("Registration")]
        public ActionResult Registration (ModelApi.UserRegistrationRequst requst)
        {
            if (requst != null)
                return BadRequest("Пустой запрос");

            if (string.IsNullOrEmpty(requst.Email)) // todo -добавить проверку на  коректоность
                return BadRequest("Пустой емейл");

            if (string.IsNullOrEmpty(requst.Password))
                return BadRequest("Пустой пароль");

            if (string.IsNullOrEmpty(requst.Name))
                return BadRequest("Пустое  имя");

            try
            {
                _userService.AddUser(requst.Name, requst.Password, requst.Email);
                return Ok();
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }
        }
    }
}
