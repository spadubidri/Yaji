using System.Web.Mvc;

namespace Yaji.UI.Areas.Devalaya
{
    public class DevalayaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Devalaya";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Devalaya_default",
                "Devalaya/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
