using Cwk.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Application.UserProfiles.Queries;
using CwkSocial.Dal;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkSocial.Application.UserProfiles.QueryHandlers
{
    internal class GetAllUserProfileHandler : IRequestHandler<GetAllUserProfile, IEnumerable<UserProfile>>
    {
        private readonly DataContext _ctx;
        public GetAllUserProfileHandler(DataContext ctx)
        {
            _ctx = ctx;
         }
        public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfile request, CancellationToken cancellationToken)
        {
          return  await  _ctx.UserProfiles.ToListAsync();
        }
    }
}
