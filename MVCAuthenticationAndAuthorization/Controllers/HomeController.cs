using MVCAuthenticationAndAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthenticationAndAuthorization.Controllers
{
    public class HomeController : Controller
    {
        [TestAuthenticationAttribute]
        [TestAuthorizationAttribute("Admin","Manager")]
        public ActionResult Index()
        {
            return View();
        }
        [OutputCache(Duration =10)]
        public ActionResult ViewTime()
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
    }
}