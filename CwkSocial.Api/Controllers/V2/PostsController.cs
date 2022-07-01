
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PostsController:ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
           // var post = new Post() { Id = 1, Text = "hello world" };
            return Ok();
        }
    }
}
