using System.Web;
using System.Web.Mvc;

namespace Actividad3Mirna_G
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
