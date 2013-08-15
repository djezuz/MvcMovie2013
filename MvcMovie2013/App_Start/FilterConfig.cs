using System.Web;
using System.Web.Mvc;

namespace MvcMovie2013
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Oleg 
            filters.Add(new HandleErrorAttribute());
        }
    }
}
