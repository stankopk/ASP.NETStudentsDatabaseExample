using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Students_Database_Example
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
