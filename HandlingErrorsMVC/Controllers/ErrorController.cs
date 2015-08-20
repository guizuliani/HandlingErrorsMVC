using System.Net;
using System.Web.Mvc;

namespace HandlingErrorsMVC.Controllers
{
    public class ErrorController : Controller
    {

        public ErrorController()
        {

        }

        public ActionResult Forbidden()
        {
            Response.StatusCode = (int)HttpStatusCode.Forbidden;

            return View();
        }

        public ActionResult NotFound()
        {
            Response.StatusCode = (int)HttpStatusCode.NotFound;

            return View();
        }

        public ActionResult InternalServerError()
        {
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return View();
        }

    }
}
