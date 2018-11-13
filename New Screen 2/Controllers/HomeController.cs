using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using New_Screen_2.Models;
namespace New_Screen_2.Controllers
{
    public class HomeController : Controller
    {
        DemoTeam12Entities db = new DemoTeam12Entities();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
               public ActionResult Newtask()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
