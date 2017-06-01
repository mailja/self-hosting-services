using System.Web.Http;
using Owin;

namespace StatelessWebApiProd
{
  public class Startup
  {
    public static void ConfigureApp(IAppBuilder appBuilder) {
      HttpConfiguration config = new HttpConfiguration();

      config.Routes.MapHttpRoute(
        name: "DefaultApi",
        routeTemplate: "api/{controller}/{id}",
        defaults: new { id = RouteParameter.Optional }
      );

      appBuilder.UseWebApi(config);
    }
  }
}
