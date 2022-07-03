
using Cwk.Domain.Aggregates.PostAggregate;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route(ApiRoutes.Baseroute)]
    public class PostsController:ControllerBase
    {
        [HttpGet]
        [Route(ApiRoutes.Posts.GetById)]
        public IActionResult GetById(int id)
        {
            //var post = new Post();
            return Ok();
        }
    }
}
