using System.Web;
using System.Web.Mvc;

namespace DEMO_DOC_GHI_FILE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
