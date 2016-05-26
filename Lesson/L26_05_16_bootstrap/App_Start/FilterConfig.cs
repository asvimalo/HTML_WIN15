using System.Web;
using System.Web.Mvc;

namespace L26_05_16_bootstrap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
