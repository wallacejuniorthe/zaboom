using Microsoft.AspNetCore.Mvc;
using WebApi.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TesteController : BaseController
    {
        [HttpGet("hello")]
        public String Hello()
        {
            return this.Account.Name;
        }
        
        [HttpGet("hello2")]
        [AllowAnonymous]
        public String Hello2()
        {
            return "teste heloo";
        }
    }
}
