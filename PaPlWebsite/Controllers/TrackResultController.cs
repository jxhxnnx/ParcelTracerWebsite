using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PaPlWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaPlWebsite.Controllers
{
    public class TrackResultController : Controller
    {
        // GET: TrackResult
        public ActionResult Index()
        {
            var data = TempData["data"].ToString();
            var model = GetModel(data);
            ViewBag.data = model;
            return View();
        }

        private TrackingInfo GetModel(string text)
        {
            return JsonConvert.DeserializeObject<TrackingInfo>(text);
        }
    }
}