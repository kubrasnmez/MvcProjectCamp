using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Istatistik

        Context context = new Context();
        public ActionResult Index()
        {

            var categoryCount = context.Categories.Count();
            ViewBag.categoryCount = categoryCount;

            var headingOfYazilim = context.Headings.Count(h => h.CategoryId == 18);
            ViewBag.headingOfYazilim = headingOfYazilim;

            var writer = context.Writers.Where(w => w.WriterName.Contains("a")).Count();
            ViewBag.writer = writer;

            var categoryName = context.Categories.Where(c => c.CategoryId == context.Headings.GroupBy(h => h.CategoryId).OrderByDescending(h => h.Count())
            .Select(h => h.Key).FirstOrDefault()).Select(c => c.CategoryName).FirstOrDefault();
            ViewBag.categoryName = categoryName;

            var categoryStatusTrue = context.Categories.Where(c => c.CategorySatatus == true).Count();
            var cateoryStatusFalse = context.Categories.Where(c => c.CategorySatatus == false).Count();

            var categoryStatus = categoryStatusTrue - cateoryStatusFalse;
            ViewBag.categoryStatus = categoryStatus;


            return View();
        }
    }
}