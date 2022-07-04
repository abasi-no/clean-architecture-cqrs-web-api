using AutoMapper;
using Cwk.Domain.Aggregates.UserProfileAggregate;
using CwkSocial.Api.Contracts.UserProfiles.Requests;
using CwkSocial.Api.Contracts.UserProfiles.Responses;
using CwkSocial.Application.UserProfiles.Commands;

namespace CwkSocial.Api.UserProfileMapping
{
    public class UserProfileMapper : Profile
    {
        public UserProfileMapper()
        {
            CreateMap<UserProfile , UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
            CreateMap<UserProfileCreate, CreateUserCommand>();
            CreateMap<UserProfileCreate, UpdateUserprofileCommand>();
        }
    }
}
