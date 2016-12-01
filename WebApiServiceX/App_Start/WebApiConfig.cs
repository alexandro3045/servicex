using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiServiceX.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            EnableCrossSiteRequests(config);


            //config.MapHttpAttributeRoutes();

            // Convention-based routing.
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "servicex/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //     name: "TipoTelefones",
            //     routeTemplate: "api/tipotelefones/{userName}",
            //     defaults: new { controller = "TipoTelefone", userName = RouteParameter.Optional }
            // );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //Replace the controller configuration selector
            //config.Services.Replace(typeof(IHttpControllerSelector), new TipoTelefoneControllerSelector((config)));

#if !DEBUG
            //force HTTPs
            config.Filters.Add(new ForceHttpsAttribute());
#endif


        }

        private static void EnableCrossSiteRequests(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute(
                origins: "*",
                headers: "*",
                methods: "*");
            config.EnableCors(cors);

            //var cors = new EnableCorsAttribute("http://localhost:5901", "*", "*");
            //config.EnableCors(cors);
        }

    }

}