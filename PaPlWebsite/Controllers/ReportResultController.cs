using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaPlWebsite.Controllers
{
    public class ReportResultController : Controller
    {
        // GET: ReportResult
        public ActionResult Index()
        {
            var data = TempData["data"].ToString();
            ViewBag.data = data;
            return View();
        }
    }
}