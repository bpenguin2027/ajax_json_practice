using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonWebApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetJsonData()
        {
            string str_file = "~/App_Data/ODwsvTravelFood.json";
            using (StreamReader sr = new StreamReader(Server.MapPath(str_file)))
            {
                var output = JsonConvert.DeserializeObject<List<ODwsvTravelFoodModel>>(sr.ReadToEnd());
                return Json(output, JsonRequestBehavior.AllowGet);
            }
        }
    }
}