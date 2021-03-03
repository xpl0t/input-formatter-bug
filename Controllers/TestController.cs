using CustomValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomValidation.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
      [HttpPost]
      [ValidationFilter()]
      public string Test([FromBody] User user)
      {
        return user.Email;
      }
    }
}
