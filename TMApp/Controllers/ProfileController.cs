using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class ProfileController : Controller
    {
      
       [HttpGet]
        public ActionResult MyProfile()
        {

            TMAppContext db = new TMAppContext();
            var Users = db.RegistersTable.Find(Session["Email"]);
            //if (Users != null)
            //{
            //    ViewData["Name"] = Users.Name;
            //    ViewData["Email"] = Users.Email;
            //    ViewData["PhoneNo"] = Users.PhoneNo;
            //    ViewData["Country"] = Users.Country;
            //    ViewData["State"] = Users.State;
            //    ViewData["Username"] = Users.Username;

            //    return View(Users);
            //}

            //TempData["error"]="<script> alert('Error occurred');</script>";
            return View(Users);

        }

        

      


        public ActionResult PasswordView()
        {


            return View();
        }
        public ActionResult EditPwd()
        {
            return View();
        }

    }

}