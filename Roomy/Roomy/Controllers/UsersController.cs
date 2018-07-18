﻿using Roomy.Data;
using Roomy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roomy.Utils;

namespace Roomy.Controllers
{
    public class UsersController : Controller
    {
        private RoomyDbContext db = new RoomyDbContext();

        // GET: Users
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Civilities = db.Civilities.ToList();
            //ViewBag.NbrPersonne = 4; stocker des valeurs complémentaire à la vue, permet de partager des données en le controller, la vue...etc
            //ViewData["NbrPersonne"] = 42; Autre façon d'écrire la ligne du dessus

            return View();
        }

        // POST: Users
        [HttpPost]
        public ActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                db.Configuration.ValidateOnSaveEnabled = false;
                user.Password = user.Password.HashMD5();

                //Enregistrer en bdd
                db.Users.Add(user);
                db.SaveChanges();
                //Redirection
            }
            ViewBag.Civilities = db.Civilities.ToList();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}