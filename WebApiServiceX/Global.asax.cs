using System;
using System.Diagnostics;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using WebApiServiceX.App_Start;
using WebApiServiceX.Controllers;

namespace WebApiServiceX
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
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