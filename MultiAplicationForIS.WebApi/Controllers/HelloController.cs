using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MultiAplicationForIS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HellpController : ControllerBase
     {


        private string url = "/swagger/index.html";



        [HttpGet("hello")]
        public string Hello (string name )
        {
            return $"привет {name}!!! я  апи - Для  удобства  у  меня есть  документация по адресу host+{url} ";
        }

    }
}
