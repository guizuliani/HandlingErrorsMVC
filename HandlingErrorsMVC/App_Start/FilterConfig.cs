using HandlingErrorsMVC.Handles;
using System.Web.Mvc;

namespace HandlingErrorsMVC.App_Start
{
    public class FilterConfig
    {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomHandleErrorAttribute());
        }

    }
}