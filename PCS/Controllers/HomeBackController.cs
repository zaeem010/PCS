using PCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PCS.Controllers
{
    [SessionTimeout]
    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if (HttpContext.Current.Session["UserID"] == null)
            {
                filterContext.Result = new RedirectResult("~/Home/Login");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
    public class HomeBackController : Controller
    {
        private ApplicationDbContext _context;

        public HomeBackController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: HomeBack
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username,string pass)
        {
            string dir = "";
            if (ModelState.IsValid)
            {
                var obj = _context.Database.SqlQuery<UserLogin>("SELECT * FROM UserLogins WHERE UserName='" + username + "' AND Pass ='" + pass + "' ").FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.id;
                    Session["UserName"] = obj.UserName.ToString();
                    dir = "Index";
                }
                else
                {
                    TempData["Invalid"] = "Invalid Login Details";
                    dir = "Login";
                }
            }
            return RedirectToAction(dir);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            Session["UserID"] = null;
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();

            return RedirectToAction("Index","Main");
        }
    }
}