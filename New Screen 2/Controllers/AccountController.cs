using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using New_Screen_2.Models;
namespace New_Screen_2.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        DemoTeam12Entities db = new DemoTeam12Entities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.Users.FirstOrDefault(x => x.Username == username);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    Session["Username"] = user.Username;
                    Session["UserID"] = user.id;
                   
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
           
              
            }
            else
            {
                ViewBag.mgs = "User chưa đăng kí, vui lòng đăng kí !";
            }
           
            return View();
        }

    }
}
