using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewDiff.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FullView()
        {
            return PartialView();
        }

        public PartialViewResult PartialDataView()
        {
            return PartialView();
        }
    }
}