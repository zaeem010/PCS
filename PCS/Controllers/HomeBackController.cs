using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCS.Controllers
{
    public class HomeBackController : Controller
    {
        // GET: HomeBack
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string pass)
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}