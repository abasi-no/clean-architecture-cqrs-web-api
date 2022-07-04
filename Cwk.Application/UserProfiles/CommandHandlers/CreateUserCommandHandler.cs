using Cwk.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Dal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkSocial.Application.UserProfiles.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>

    {
        public readonly DataContext _dtx;
        public CreateUserCommandHandler(DataContext dtx)
        {
            _dtx = dtx;
        }
        public async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName , request.LastName ,request.EmailAddress ,
                                                      request.Phone,request.DateOfBirth,request.CurrentCity);

            var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);
            _dtx.Add(userProfile);
            await _dtx.SaveChangesAsync();

            return userProfile;
          
        }
    }
}
