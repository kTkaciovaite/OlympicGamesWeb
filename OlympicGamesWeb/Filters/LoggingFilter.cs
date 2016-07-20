using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;
using OlympicGames.DataAccess;
using OlympicGames.Domain;

namespace OlympicGamesWeb.Filters
{
    public class LoggingFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            var actionName = routeData.Values["action"];
            var dateTime = DateTime.Now;
            var message = $"Method: {methodName}, action: {actionName}, time: {dateTime.ToString("yyyyMMddTHHmmss")}";

            Debug.WriteLine(message);
        }
    }
}