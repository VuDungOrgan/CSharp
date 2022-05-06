using Models_SVOnline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWeb.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            if(Session[Contants.USER_SESSION] == null )
                return RedirectToAction("Index", "Login");
            return View();
        }
        public ActionResult Logout()
        {
            
                Session[Contants.USER_SESSION] = null;
           
            return RedirectToAction("Index","Login");
        }
    }
}