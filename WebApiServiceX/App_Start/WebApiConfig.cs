using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using WebApiServiceX.Services;

namespace WebApiServiceX.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Routes.MapHttpRoute(
                 name: "TipoTelefones",
                 routeTemplate: "api/tipotelefones/{userName}",
                 defaults: new { controller = "TipoTelefone", userName = RouteParameter.Optional }
             );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //Replace the controller configuration selector
            config.Services.Replace(typeof(IHttpControllerSelector), new TipoTelefoneControllerSelector((config)));

#if !DEBUG
            //force HTTPs
            config.Filters.Add(new ForceHttpsAttribute());
#endif


        }
     
    }

}