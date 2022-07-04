using CwkSocial.Application.UserProfiles.Queries;
using MediatR;

namespace CwkSocial.Api.Registrars
{
    public class BogardRegister : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program) , typeof(GetAllUserProfile));
            builder.Services.AddMediatR(typeof(GetAllUserProfile));
        }
    }
}
