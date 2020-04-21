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
            return View();
        }

        public ViewResult GetProfile( Register UserRecord)
        {

            TMAppContext db = new TMAppContext();
            var Users = db.RegistersTable.Find(Session["Email"]);
            if (Users !=null)
            {
                ViewData["Name"] = Users.Name;
                ViewData["Email"] = Users.Email;
                ViewData["PhoneNo"] = Users.PhoneNo;
                ViewData["Country"] = Users.Country;
                ViewData["State"] = Users.State;
                ViewData["Username"] = Users.Username;

            }
            else
            {
               TempData["error"]="<script> alert('Error occurred');</script>";
            }


            return View(); 
  
        }
    }
}