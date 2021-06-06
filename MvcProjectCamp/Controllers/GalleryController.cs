﻿using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager imageFileManager = new ImageFileManager(new EfImageFileDal());

        // GET: Gallery
        public ActionResult Index()
        {
            var files = imageFileManager.GetList();
            return View(files);
        }
    }
}