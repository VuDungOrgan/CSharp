using DemoWeb.Areas.Admin.Models;
using Models_SVOnline;
using Models_SVOnline.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWeb.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            var user = new UserDao();
            var userList = user.ListAll();
            return View(userList);
        }
    }
}