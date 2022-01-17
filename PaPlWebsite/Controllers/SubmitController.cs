using Newtonsoft.Json;
using PaPlWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PaPlWebsite.Controllers
{
    public class SubmitController : Controller
    {
        // GET: Submit
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Parcel parcel)
        {

            using (var client = new HttpClient())
            {
                string content = "{\"weight\":" + parcel.Weight.ToString() +
                ",\"recipient\":{\"name\":\"" + parcel.RecipientName +
                    "\",\"street\":\"" + parcel.RecipientStreet +
                    "\",\"postalCode\":\"" + parcel.RecipientPostalCode +
                    "\",\"city\":\"" + parcel.RecipientCity +
                    "\",\"country\":\"" + parcel.RecipientCountry +
                "\"},\"sender\":{\"name\":\"" + parcel.SenderName +
                    "\",\"street\":\"" + parcel.SenderStreet +
                    "\",\"postalCode\":\"" + parcel.SenderPostalCode +
                    "\",\"city\":\"" + parcel.SenderCity +
                    "\",\"country\":\"" + parcel.SenderCountry + "\"}}";
                
                var response = await client.PostAsync("https://papl.azurewebsites.net" + "/parcel",
                    new StringContent(content, Encoding.UTF8, "application/json"));
                var jsonResult = await response.Content.ReadAsStringAsync();
                TempData["data"] = jsonResult;
                //return jsonResult;
                return RedirectToAction("Index", "SubmitResult");
            }
                
        }

        private TrackingId GetModel(string text)
        {
            return JsonConvert.DeserializeObject<TrackingId>(text);      
        }

    }
}