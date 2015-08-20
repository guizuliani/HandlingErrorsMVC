using System.Net;
using System.Web.Mvc;

namespace HandlingErrorsMVC.Controllers
{
    public class ErrorController : Controller
    {

        public ErrorController()
        {

        }

        public ActionResult Generic()
        {
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return View();
        }

        public ActionResult NotFound(string aspxErrorPath)
        {
            Response.StatusCode = (int)HttpStatusCode.NotFound;

            return View();
        }

    }
}
