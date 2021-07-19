using PCS.Models;
using PCS.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCS.Controllers
{
    [ValidateInput(false)]
    public class SessionsController : Controller
    {
        private ApplicationDbContext _context;
        public SessionsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Sessions
        public ActionResult Index()
        {
            var List = _context.Session.ToList();
            return View(List);
        }
        public ActionResult Create(Session Session)
        {
            return View(Session);
        }
        [HttpPost]
        public ActionResult Save(Session Session)
        {
            string d = "";
            if (Session.id == 0) 
            {
                _context.Session.Add(Session);
                d = "Create";
            }
            else
            {
                var db = _context.Session.SingleOrDefault(c => c.id == Session.id);
                db.Name = Session.Name;
                db.Desc = Session.Desc;
                d = "Index";
            }
            _context.SaveChanges();
            return RedirectToAction(d);
        }
        public ActionResult Edit(int id)
        {
            var db = _context.Session.SingleOrDefault(c => c.id == id);
            return View("Create",db);
        }
    }
}