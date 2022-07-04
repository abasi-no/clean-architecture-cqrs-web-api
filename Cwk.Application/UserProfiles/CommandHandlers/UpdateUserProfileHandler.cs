using Cwk.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Dal;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkSocial.Application.UserProfiles.CommandHandlers
{
    internal class UpdateUserProfileHandler : IRequestHandler<UpdateUserprofileCommand>
    {
        private readonly DataContext _ctx;
        public UpdateUserProfileHandler(DataContext ctx)
        {
             _ctx = ctx;
        }
        public async Task<Unit> Handle(UpdateUserprofileCommand request, CancellationToken cancellationToken)
        {
            var userprofile = await _ctx.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserProfileId);
            var info = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            userprofile.UpdateBasicInfo(info);

            _ctx.UserProfiles.Update(userprofile);
            await _ctx.SaveChangesAsync();

            return new Unit();

        }
    }
}
