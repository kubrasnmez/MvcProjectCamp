using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjectCamp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Context context = new Context();
            var adminUserInfo = context.Admins.FirstOrDefault(x=>x.UserName == admin.UserName && x.Password == admin.Password);
            if(adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.UserName,false);
                Session["UserName"] = adminUserInfo.UserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
               return RedirectToAction("Index");
            }
            return View();
        }
    }
}