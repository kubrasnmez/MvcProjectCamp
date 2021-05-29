using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            var contectValues = contactManager.GetList();
            return View(contectValues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactValues = contactManager.GetById(id);
            return View(contactValues);
        }
    }
}