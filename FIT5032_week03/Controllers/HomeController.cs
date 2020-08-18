using FIT5032_week03.Models.Excercise;
using FIT5032_week03.Models.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_week03.Controllers
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
            Hello hello = new Hello();

            ViewBag.Message = hello.GetHello();

            ExampleDictionary ed = new ExampleDictionary();

            ed.Example();

            ed.displayExample();


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}