
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route(ApiRoutes.Baseroute)]
    public class PostsController:ControllerBase
    {
        [HttpGet]
        [Route(ApiRoutes.Posts.GetById)]
        public IActionResult GetById(int id)
        {
           // var post = new Post() { Id = 1, Text = "hello world" };
            return Ok();
        }
    }
}
