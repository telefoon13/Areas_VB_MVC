using System;
using System.Web.Mvc;

namespace Areas_VB.Areas.Prive
{
    public class PriveAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Prive";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Prive_default",
                "Prive/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new String[] { "Areas_VB.Areas.Prive.Controllers" }
            );
        }
    }
}