using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Security.Claims;

namespace ATMMachine.Controllers
{
    public class Actionfiltersample:ActionFilterAttribute
    {
   
        
        //
        // Summary:
        //     Called by the ASP.NET MVC framework after the action method executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var str = filterContext.ActionDescriptor.ActionName + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Controllers/TextFile1.txt"), str);
        }
        //
        // Summary:
        //     Called by the ASP.NET MVC framework before the action method executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        //public virtual void OnActionExecuting(ActionExecutingContext filterContext);

    }
}