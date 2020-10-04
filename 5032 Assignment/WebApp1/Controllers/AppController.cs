using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult AppMain()
        {
            return View();
        }

        public ActionResult WelcomePage(string Name)
        {
            ViewBag.Message = "Hello" + Name + "<br/> your upcoming classes";
            return View();
        }
    }
}