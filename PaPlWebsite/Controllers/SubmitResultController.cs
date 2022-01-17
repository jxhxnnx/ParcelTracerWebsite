using Newtonsoft.Json.Linq;
using PaPlWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaPlWebsite.Controllers
{
    public class SubmitResultController : Controller
    {
        // GET: SubmitResult
        public ActionResult Index()
        {
            var data = TempData["data"].ToString();
            var model = GetModel(data);
            ViewBag.data = model;
            return View();
        }

        private TrackingId GetModel(string text)
        {
            var model = new TrackingId();
            model.Id = JObject.Parse(text)["trackingId"].ToString();
            return model;
        }
    }
}