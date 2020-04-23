using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class ProfileController : Controller
    {
      
       
        public ActionResult MyProfile()
        {

            TMAppContext db = new TMAppContext();
            var Users = db.RegistersTable.Find(Session["Email"]);
            if (Users != null)
            {
                ViewData["Name"] = Users.Name;
                ViewData["Email"] = Users.Email;
                ViewData["PhoneNo"] = Users.PhoneNo;
                ViewData["Country"] = Users.Country;
                ViewData["State"] = Users.State;
                ViewData["Username"] = Users.Username;

                return View(Users);
            }
            else
            {
                return HttpNotFound();
                //TempData["error"]="<script> alert('Error occurred');</script>";
            }

         
        }

        public ActionResult EditProfile(Register UserRecord)
        {

          
            return View();



        }
    }
}