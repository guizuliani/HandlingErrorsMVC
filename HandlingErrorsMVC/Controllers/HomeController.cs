using System;
using System.Web.Mvc;

namespace HandlingErrorsMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new NotImplementedException();
        }

    }
}