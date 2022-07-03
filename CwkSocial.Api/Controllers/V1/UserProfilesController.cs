using CwkSocial.Api.Contracts.UserProfiles.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route(ApiRoutes.Baseroute)]
    public class UserProfilesController : ControllerBase
    {
        public readonly IMediator _mediator;
        public UserProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult CreateUserProfile([FromBody] UserProfileCreate profile)
        {

            return Ok();
        }
    }
}
