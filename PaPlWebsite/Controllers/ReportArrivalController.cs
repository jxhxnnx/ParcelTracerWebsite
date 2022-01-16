using PaPlWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PaPlWebsite.Controllers
{
    public class ReportArrivalController : Controller
    {
        // GET: ReportArrival
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> Index(ReportHop reportHop)
        {
            using (var client = new HttpClient())
            {
                string content = "";

                var response = await client.PostAsync("https://papl.azurewebsites.net/parcel/" + reportHop.ParcelId
                    + "/reportDelivery",
                    new StringContent(content, Encoding.UTF8, "application/json"));
                var jsonResult = await response.Content.ReadAsStringAsync();
                return jsonResult;
            }

        }
    }
}