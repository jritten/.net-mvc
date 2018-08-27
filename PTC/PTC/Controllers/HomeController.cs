using PTCData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TrainingProductViewModel vm = new TrainingProductViewModel();
            vm.HandleRequest();
            return View(vm);
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
    }
}