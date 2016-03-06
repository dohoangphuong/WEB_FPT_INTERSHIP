using System.Web;
using System.Web.Mvc;

namespace Chapter02_MVC_LinQ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}