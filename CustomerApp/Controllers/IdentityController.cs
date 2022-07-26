using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApp.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("identity")]
    [Authorize]
    public class IdentityController : ControllerBase
    {
        [HttpGet(Name = "Identity")]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
