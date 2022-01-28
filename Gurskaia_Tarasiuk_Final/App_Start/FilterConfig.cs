using System.Web;
using System.Web.Mvc;

namespace Gurskaia_Tarasiuk_Final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
