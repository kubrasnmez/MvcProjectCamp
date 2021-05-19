using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class HeadingsController : Controller
    {
        // GET: Headings
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        public ActionResult Index()
        {
            var headingValues = headingManager.GetAll();
            return View(headingValues);
        }
    }
}