using System.Web;
using System.Web.Mvc;

namespace OpenQbit.Insurance.Test.TestWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
