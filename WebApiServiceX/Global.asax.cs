using Microsoft.Practices.Unity;
using System;
using System.Diagnostics;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Unity.WebApi;
using WebApiServiceX.App_Start;
using WebApiServiceX.Controllers;
using WebApiServiceX.SvcTipoTelefone;

namespace WebApiServiceX
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //var container = new UnityContainer();
            //container
            //    .RegisterType<ISvcTipoTelefone, SvcTipoTelefoneClient>()
            //    .Configure<InjectedMembers>()
            //    .ConfigureInjectionFor<SvcTipoTelefoneClient>(new InjectionConstructor("*"));

            //UnityDependencyResolver resolver = new Unity.WebApi.UnityDependencyResolver(container);

            //DependencyResolver.SetResolver(resolver);


            //using (IUnityContainer container = new UnityContainer())
            //{
            //    container.RegisterType<ISvcTipoTelefone, SvcTipoTelefoneClient>()
            //    .Configure<InjectedMembers>()
            //    .ConfigureInjectionFor<SvcTipoTelefoneClient>(new InjectionConstructor("*"));

            //    //.RegisterType<IStockQuoteService, MoneyCentralStockQuoteService>()
            //    //.RegisterType<ILogger, ConsoleLogger>()
            //    //.RegisterType<ILogger, TraceSourceLogger>()
            //    var dependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            //    GlobalConfiguration.Configuration.DependencyResolver = dependencyResolver;
            //    DependencyResolver.SetResolver(dependencyResolver);
            //}
             

        }



        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST, PUT, DELETE");

                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
                HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
                HttpContext.Current.Response.End();
            }
        }

        //protected void Application_Start(object sender, EventArgs e)
        //{

        //}

        //protected void Application_Start()
        //{

        //    AreaRegistration.RegisterAllAreas();

        //    WebApiConfig.Register(GlobalConfiguration.Configuration);
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //}

        //protected void Session_Start(object sender, EventArgs e)
        //{

        //}

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    //Exception ex = Server.GetLastError();
        //    //if (ex != null)
        //    //{
        //    //    Trace.TraceError(ex.ToString());
        //    //}

        //    Exception exception = Server.GetLastError();
        //    Server.ClearError();

        //    var routeData = new RouteData();
        //    routeData.Values.Add("controller", "ErrorPage");
        //    routeData.Values.Add("action", "Error");
        //    routeData.Values.Add("exception", exception);

        //    if (exception.GetType() == typeof(HttpException))
        //    {
        //        routeData.Values.Add("statusCode", ((HttpException)exception).GetHttpCode());
        //    }
        //    else
        //    {
        //        routeData.Values.Add("statusCode", 500);
        //    }

        //    Response.TrySkipIisCustomErrors = true;
        //    IController controller = new ErrorPageController();
        //    controller.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
        //    Response.End();
        //}

        //protected void Session_End(object sender, EventArgs e)
        //{

        //}

        //protected void Application_End(object sender, EventArgs e)
        //{

        //}
    }
}