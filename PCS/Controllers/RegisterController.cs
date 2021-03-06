using PCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCS.Controllers
{
    public class RegisterController : Controller
    {
        private ApplicationDbContext _context;

        public RegisterController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Register
        public ActionResult Index(Registration Registration)
        {
            Registration.fee = 0;
            Registration.Hotel = 0;
            Registration.Total = 0;
            return View(Registration);
        }
        public ActionResult All()
        {
            var List = _context.Registration.ToList();
            return View(List);
        }
        [HttpPost]
        public ActionResult Save(Registration Registration)
        {
            _context.Registration.Add(Registration);
            _context.SaveChanges();
            TempData["Insert"] = "Submitted Successfully...";
            return RedirectToAction("Index");
        }
        public ActionResult Report(int id)
        {
            var list = _context.Registration.SingleOrDefault(c=>c.id == id);
            return View(list);
        }
    }
}