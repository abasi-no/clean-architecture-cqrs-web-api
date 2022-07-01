namespace CwkSocial.Api.Registrars
{
    public class MvcWebAppRegister : IWebApplicationRegistrar
    {
        public void RegisterPipeLineComponent(WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
