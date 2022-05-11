using DemoWeb.Areas.Admin.Models;
using Models_SVOnline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoWeb.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected override void OnActionExecuted(ActionExecutedContext filtercontext)
        {
            var session = (loginModal)Session[Contants.USER_SESSION];
            if (session == null)
            {
                filtercontext.Result= new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index", Areas = "Admin" }));
            }
            base.OnActionExecuted(filtercontext);
        }
    }
}