using System;
using System.Web.Mvc;

namespace Areas_VB.Areas.Publiek
{
    public class PubliekAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Publiek";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Publiek_default",
                "Publiek/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new String[] { "Areas_VB.Areas.Publiek.Controllers" }
            );
        }
    }
}