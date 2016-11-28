using System;

namespace WebApiServiceX.Filters
{

    using System.Web.Mvc;
    using System.Web.Routing;

    namespace ServiceX.Filters
    {
        public class LoggingAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {

                RegistrarLog("OnActionExecuting", filterContext.RouteData);

                base.OnActionExecuting(filterContext);
            }

            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                RegistrarLog("OnActionExecuted", filterContext.RouteData);

                base.OnActionExecuted(filterContext);
            }

            private void RegistrarLog(
                string metodo, RouteData routeData)
            {
                string controller =
                    routeData.Values["controller"].ToString();
                string action =
                    routeData.Values["action"].ToString();
                DateTime dataHoraAtuais = DateTime.Now;

                // A partir deste ponto as informações podem ser 
                // gravadas em um banco de dados, um arquivo físico
                // ou ainda, exibidas em tela (ou qualquer outro dispositivo
                // de saída: um exemplo é a janela Output, usada
                // durante atividades de debug no Visual Studio).

            }
   
          }
        
    }
}