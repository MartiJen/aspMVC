using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace Roomy.Filters
{
    public class AuthenticationFilter : ActionFilterAttribute //on filtre une action sous forme d'attribut
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["USER_BO"] == null)
            {

                filterContext.Result = new RedirectResult("\\BackOffice\\Authentification\\Login");
                //filterContext.Result = new RedirectToRouteResult(new { controller = "Authentication", action = "Login", area = "BackOffice" });
            }
        }
    }
}