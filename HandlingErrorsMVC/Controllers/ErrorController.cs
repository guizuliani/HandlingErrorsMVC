﻿using System.Net;
using System.Web.Mvc;

namespace HandlingErrorsMVC.Controllers
{
    public class ErrorController : Controller
    {

        public ActionResult Generic()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

    }
}
