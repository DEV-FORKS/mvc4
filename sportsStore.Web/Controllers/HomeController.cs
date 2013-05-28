using sportsStore.Core;
using sportsStore.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sportsStore.Web.Controllers
{

    public class HomeController : Controller
    {
        private ISportDataSource _db;

        public HomeController(ISportDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allSports = _db.Sports;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
