using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMMachine.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Actionfiltersample]
        public ActionResult Serial(string Lettercase)
        {
            var str = "ASPMVCATM";
            if(Lettercase == "lower")
            {
                return Content(str.ToLower());
            }
            return new HttpStatusCodeResult(403);
        }
    }
}