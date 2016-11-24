﻿using System.Web.Http;

namespace WebApiServiceX.App_Start
{
    public class WebApiConfig
    {
        public static void Configure(HttpConfiguration config)
        {
   
           // Web API configuration and services
           // Configure Web API to use only bearer token authentication.
           //config.SuppressHostPrincipal();//.SuppressDefaultHostAuthentication();
           //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            

           // Web API routes
           config.MapHttpAttributeRoutes();
            
           var json = config.Formatters.JsonFormatter;
                     json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
                     config.Formatters.Remove(config.Formatters.XmlFormatter);
            
           config.Routes.MapHttpRoute(
                   name: "DefaultApi",
                   routeTemplate: "api/{controller}/{id}",
                   defaults: new { id = RouteParameter.Optional }
            );
        }

    }
}