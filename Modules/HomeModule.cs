using Nancy;

namespace NancyAPI.Module
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => "Hello World from Nancy!");
        }
    }
}