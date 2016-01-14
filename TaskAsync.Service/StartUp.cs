using System.Web.Http;
using Owin;

namespace TaskAsync.Service
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional});
            app.UseWebApi(config);
        }
    }
}