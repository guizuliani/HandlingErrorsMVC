using System.Web.Mvc;

namespace HandlingErrorsMVC.Handles
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {

        public CustomHandleErrorAttribute()
        {

        }

        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

    }
}