using AutoMapper;
using CwkSocial.Api.Contracts.UserProfiles.Requests;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Application.UserProfiles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route(ApiRoutes.Baseroute)]
    public class UserProfilesController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public UserProfilesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserProfile()
        {
            //return HandleErrors();
            var response = await _mediator.Send(new GetAllUserProfile());
            var Result = _mapper.Map<List<UserProfileResponse>>(response);
            return Ok(Result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUserProfileById(string id)
        {
            var query = new GetUserProfileById() { UserProfileId = Guid.Parse(id) };
            var response = await _mediator.Send(query);
            var Result = _mapper.Map<UserProfileResponse>(response);
            return Ok(Result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreate profile)
        {
            var command = _mapper.Map<CreateUserCommand>(profile);
            var userProfile = await _mediator.Send(command);
            var user = _mapper.Map<UserProfileResponse>(userProfile);
            return CreatedAtAction(nameof(GetUserProfileById), new { id = user.UserProfileId }, user);
        }

        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUserprofile(string id, UserProfileCreate profile)
        {
            var command = _mapper.Map<UpdateUserprofileCommand>(profile);
            command.UserProfileId = Guid.Parse(id);
            var response = await _mediator.Send(command);
            if(response.IsError) return NotFound();

            return NoContent();

        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUserprofile(string id)
        {
            var command = new DeleteUserProfileCommand() { UserProfileId = Guid.Parse(id) };
            var Response = await _mediator.Send(command);
            return NoContent();
        }
    }
}
