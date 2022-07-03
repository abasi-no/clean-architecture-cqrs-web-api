namespace CwkSocial.Api
{
    public class ApiRoutes
    {
        public const string Baseroute = "api/v{version:apiVersion}/[controller]";    

        public class Posts
        {
            public const string GetById = "{id}";  
        }
    }
}
