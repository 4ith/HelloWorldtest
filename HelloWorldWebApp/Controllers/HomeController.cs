using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldDLL;
using System.Configuration;

namespace HelloWorldWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = new HelloWorldImp().GetHelloWorld(ConfigurationManager.AppSettings["Text"].ToString());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = new HelloWorldImp().GetHelloWorld(ConfigurationManager.AppSettings["Text"].ToString());

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}