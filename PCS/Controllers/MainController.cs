using PCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCS.Controllers
{
    public class MainController : Controller
    {
        private ApplicationDbContext _context;

        public MainController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Main
        public ActionResult Index()
        {
            var List = _context.NationalFaculty.ToList();
            var List1 = _context.InNationalFaculty.ToList();
            ViewBag.Data = List1;
            return View(List);
        }
        public ActionResult PSIC()
        {
            return View();
        }
        public ActionResult PCS()
        {
            return View();
        }
        public ActionResult ScientificSession()
        {
            return View();
        }
        public ActionResult WorkShop()
        {
            return View();
        }
    }
}