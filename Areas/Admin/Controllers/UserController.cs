using DemoWeb.Areas.Admin.Models;
using Models_SVOnline;
using Models_SVOnline.DAO;
using Models_SVOnline.EF;
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

        [HttpPost]
        public ActionResult Index(string keyword)
        {
            var user = new UserDao();
            var userList = user.ListWhere(keyword);
            ViewBag.SearchKeyword = keyword;
            return View(userList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User ent_User )
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.findUser(ent_User.Username, ent_User.Email) != null)
                {
                    SetAlert("Người dùng đã tồn tại","warning");
                    return RedirectToAction("Create", "User");
                }
                var pass = Common.GetMD5(ent_User.Password);
                ent_User.Password = pass;
                string result = dao.Insert(ent_User);
                if (!string.IsNullOrEmpty(result))
                {
                    
                    SetAlert("Tạo mới người dùng thành công","success");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    SetAlert("Tạo mới người dùng không thành công","error");
                    //ModelState.AddModelError("", "Tạo mới người dùng không thành công");
                }

            }
            return View();
        }
    }
}