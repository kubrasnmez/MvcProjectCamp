using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class AboutsController : Controller
    {
        // GET: Abouts
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutValues = aboutManager.GetList();
            
            return View(aboutValues);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            aboutManager.Add(about);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public ActionResult StatusActiveAndPassive(int id)
        {
            var aboutValue = aboutManager.GetById(id);
            if(aboutValue.AboutStatus == true)
            {
                aboutValue.AboutStatus = false;
            }
            else
            {
                aboutValue.AboutStatus = true;
            }
            aboutManager.Update(aboutValue);
            return RedirectToAction("Index");
        }
    }
}