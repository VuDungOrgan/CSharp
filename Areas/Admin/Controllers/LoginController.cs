using DemoWeb.Areas.Admin.Models;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OpenIdConnect;
using Models_SVOnline;
using Models_SVOnline.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWeb.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(loginModal loginModal)
        {
            if (ModelState.IsValid)
            {
                var user = new UserDao();
                var result = user.login(loginModal.username,Common.GetMD5(loginModal.password));
                if(result != null)
                {
                    loginModal.username = result.Username;
                    loginModal.fullname = result.FullName;
                    //ModelState.AddModelError("","Dang Nhap Thanh Cong");
                    Session.Add(Contants.USER_SESSION,loginModal);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("", "Dang Nhap That Bai");
                }
            }
            return View("Index");
        }

        public void LoginOutlook()
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "/Admin/Home/" },
                    OpenIdConnectAuthenticationDefaults.AuthenticationType);
                new HttpUnauthorizedResult();
            }
            else
            {
          
            }
        }
    }
}