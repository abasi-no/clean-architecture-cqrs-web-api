namespace CwkSocial.Api.Registrars
{
    public interface IWebApplicationRegistrar :IRegistrar
    {
        public void RegisterPipeLineComponent(WebApplication app);
    }
}
