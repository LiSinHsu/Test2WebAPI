using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using Test2WebAPI.Models;
using Newtonsoft.Json;
using System.Data;

namespace Test2WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //string apiUrl = "https://od.moi.gov.tw/api/v1/rest/datastore/301110000A-001859-001";
            string apiUrl = "https://localhost:44352/api/report";
            WebRequest request = WebRequest.Create(apiUrl);
            request.Method = "GET";

            using (var httpResponse = (HttpWebResponse)request.GetResponse())

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                //var table = (DataTable)JsonConvert.DeserializeObject(result, (typeof(DataTable)));
                var model = JsonConvert.DeserializeObject<IEnumerable<Report>>(result);
                //Newtonsoft.Json.Linq.JObject obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(result);
                //var zone = obj["result"]["records"].ToString();
                //var collection = JsonConvert.DeserializeObject<IEnumerable<DisbursedAmt>>(obj["result"]["records"].ToString());
                //var table = JsonConvert.DeserializeObject<System.Data.DataTable>(obj["result"]["records"].ToString());
                //var table = JsonConvert.DeserializeObject(result);
                //var handler = new APIHandler();
                //handler.CreateData(table);


                return View(model);  
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}