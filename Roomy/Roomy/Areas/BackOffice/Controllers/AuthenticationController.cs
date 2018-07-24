using Roomy.Areas.BackOffice.Models;
using Roomy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roomy.Utils;
using Roomy.Filters;
using Roomy.Controllers;

namespace Roomy.Areas.BackOffice.Controllers
{
    public class AuthenticationController : BaseController
    {
        //private RoomyDbContext db = new RoomyDbContext();

        // GET: BackOffice/Authentication/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: BackOffice/Authentication/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AuthenticationLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var passwordHash = model.Password.HashMD5();
                var user = db.Users.SingleOrDefault(x => x.Mail == model.Login && x.Password == passwordHash);
                if (user == null)
                {
                    //1
                    //ModelState.AddModelError("", "Utilisateur ou mot de passe incorrect.");

                    //2
                    ViewBag.ErrorMEssage = "Utilisateur ou mot de passe incorrect.";

                    return View(model);
                    //return RedirectToAction("Login");
                }
                else
                {

                    Session.Add("USER_BO", user);
                    return RedirectToAction("Index", "DashBoard", new { area = "BackOffice" });
                }
            }
            return View(model);
        }

        // GET: BackOffice/Authentication/Logout
        [AuthenticationFilter]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}