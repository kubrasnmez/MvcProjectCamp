using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class WritersController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        WriterValidator validationRules = new WriterValidator();
        // GET: Writers
        public ActionResult Index()
        {
            var writerValues = writerManager.GetList();
            return View(writerValues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {

            ValidationResult validationResult = validationRules.Validate(writer);
            if (validationResult.IsValid)
            {
                writerManager.Add(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writerValue = writerManager.GetById(id);
            return View(writerValue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer writer)
        {

            ValidationResult validationResult = validationRules.Validate(writer);
            if (validationResult.IsValid)
            {

                writerManager.Update(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        
        }
    }
}