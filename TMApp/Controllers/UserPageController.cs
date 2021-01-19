using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class UserPageController : Controller
    {
        // GET: UserPage
        public ActionResult UserPage()
        {
            return View();
        }

        public ActionResult LogOut()
        {
         

            return RedirectToAction("Home","Home");
        }

    }
}