using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1
{
    public class BaseController : ControllerBase
    {
        protected IActionResult HandleErrors()
        {
            // Return Needed Errors 
            return NotFound("not found");
        }
    }
}
