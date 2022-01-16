using Newtonsoft.Json;
using PaPlWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PaPlWebsite.Controllers
{
    public class TrackController : Controller
    {
        // GET: Track
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> Index(TrackingId trackingId)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent("");

                var response = await client.GetAsync("https://papl.azurewebsites.net/parcel/" + trackingId.Id);
                var jsonResult = await response.Content.ReadAsStringAsync();
                var model = GetModel(jsonResult);
                return jsonResult;
                //return View(model);
            }

        }

        private TrackingInfo GetModel(string text)
        {
            return JsonConvert.DeserializeObject<TrackingInfo>(text);
        }


    }
}