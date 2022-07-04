using Cwk.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Application.Models;
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
    internal class UpdateUserProfileHandler : IRequestHandler<UpdateUserprofileCommand , OperationResult<UserProfile>>
    {
        private readonly DataContext _ctx;
        public UpdateUserProfileHandler(DataContext ctx)
        {
             _ctx = ctx;
        }
        public async Task<OperationResult<UserProfile>> Handle(UpdateUserprofileCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserProfile>(); 
            try
            {
                var userprofile = await _ctx.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserProfileId);

                if(userprofile == null)
                {
                    result.IsError = true;
                    result.Errors.Add(new Error() { Code = EnumCode.NotFound, Message = "Not Found" });
                    return result;
                }
                var info = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

                userprofile.UpdateBasicInfo(info);

                _ctx.UserProfiles.Update(userprofile);
                await _ctx.SaveChangesAsync();

                result.Payload = userprofile;
                return result;
            }
            catch (Exception ex)
            {
                result.IsError = true;
                result.Errors.Add(new Error() { Code = EnumCode.Exeception, Message = ex.Message });
                return result;
            }
    

        }
    }
}
