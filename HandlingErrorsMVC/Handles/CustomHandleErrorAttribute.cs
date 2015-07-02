using System.Web.Mvc;

namespace HandlingErrorsMVC.Handles
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {

        public CustomHandleErrorAttribute()
        {
            //Injectar biblioteca de log
        }

        public override void OnException(ExceptionContext filterContext)
        {
            //Registrar exception no log
            //filterContext.Exception

            base.OnException(filterContext);
        }

    }
}