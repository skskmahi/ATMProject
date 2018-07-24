using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            var str = filterContext.HttpContext.GetType();
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