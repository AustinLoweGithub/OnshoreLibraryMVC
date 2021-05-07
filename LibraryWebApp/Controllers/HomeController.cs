using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var _v = View();
            return _v;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var _v = View();
            return _v;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            // var _code = new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            return View();
        }



    }
}