using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerApp.Controllers
{
    [Route("identity")]
    [Authorize]
    public class IdentityController
    {
        [HttpGet]
        public IActionResult Get()
        {
            //return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
            return new JsonResult(new List<string>
            {
                "a", "b", "c"
            });
        }
    }
}
