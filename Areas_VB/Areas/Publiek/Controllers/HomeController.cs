using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas_VB.Areas.Publiek.Controllers
{
    public class HomeController : Controller
    {
        // GET: Publiek/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}