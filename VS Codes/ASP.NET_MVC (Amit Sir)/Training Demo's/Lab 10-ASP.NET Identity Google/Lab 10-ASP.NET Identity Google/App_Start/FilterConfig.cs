using System.Web;
using System.Web.Mvc;

namespace Lab_10_ASP.NET_Identity_Google
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
