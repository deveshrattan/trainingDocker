using System;
using System.Collections.Generic;
using ShoppingTraining.Models;
using System.Linq;
using System.Web;
using ShoppingTraining.Data;
using System.Web.Mvc;

namespace ShoppingTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ProductContext.Products);
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