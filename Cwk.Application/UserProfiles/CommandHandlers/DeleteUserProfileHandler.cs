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
    internal class DeleteUserProfileHandler : IRequestHandler<DeleteUserProfileCommand>
    {
        private readonly DataContext _ctx;
        public DeleteUserProfileHandler(DataContext ctx)
        {
             _ctx = ctx;
        }
        public async Task<Unit> Handle(DeleteUserProfileCommand request, CancellationToken cancellationToken)
        {
            var userprofile = await _ctx.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserProfileId);
            _ctx.UserProfiles.Remove(userprofile);
            await _ctx.SaveChangesAsync();

            return new Unit();

        }
    }
}
