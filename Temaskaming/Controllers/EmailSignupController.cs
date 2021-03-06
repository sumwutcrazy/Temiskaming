﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temiskaming.Models;

namespace VeronikaProject.Controllers
{
    public class EmailSignupController : Controller
    {
        linqemailsClass objSignup = new linqemailsClass();
        // action method which shows all email signups
        public ActionResult EmailSignup()
        {
            return View();
        }
        // action method which redirect to email signup page if it not a post
        public ActionResult SignupComplete()
        {
            return RedirectToAction("EmailSignup");
        }
        // action method which on post creates email signup if the data is valid
        [HttpPost]
        public ActionResult SignupComplete(email_signup valid)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    objSignup.commitInsert(valid);
                    return PartialView(valid);
                }
                catch
                {
                    return View("EmailSignup");
                }
            }
            else
            {
                return View("EmailSignup");
            }
        }

    }
}
