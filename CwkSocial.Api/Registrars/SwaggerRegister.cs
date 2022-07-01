using CwkSocial.Api.Options;

namespace CwkSocial.Api.Registrars
{
    public class SwaggerRegister : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
