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

        public ActionResult ChangePwd()
        {
            return View();
        }



        public ActionResult Userlogout()
        {
            //TempData["Logoutmsg"] = "<script> alert('Logging out?');</script>";

            return RedirectToAction("Home","Home");
        }

    }
}