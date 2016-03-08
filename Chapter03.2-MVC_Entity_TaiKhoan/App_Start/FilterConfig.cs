using System.Web;
using System.Web.Mvc;

namespace Chapter03._2_MVC_Entity_TaiKhoan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}