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


        public ActionResult LoadProfile()
        {
         
            //using (TMAppContext db = new TMAppContext())
            //{
            //    var GetProfile = db.RegistersTable.Where
            //        (m => m.Username.Equals(UserProfile.Username) && m.Password.Equals(UserProfile.Password)).FirstOrDefault();
            //    if (GetProfile !=null)
            //    {
            //        ViewData["Name"] = UserProfile.Name;
            //        ViewData["Email"] = UserProfile.Email;
            //        ViewData["PhoneNo"] = UserProfile.PhoneNo;
            //        ViewData["Country"] = UserProfile.Country;
            //        ViewData["State"] = UserProfile.State;
            //        ViewData["Username"] = UserProfile.Username;

            //    }
            //    else
            //    {
            //        return View("MyProfile", "Profile");
            //    }


            //}
           
            

            return RedirectToAction("MyProfile","Profile");
    
        }

        public ActionResult Userlogout()
        {
  
            return RedirectToAction("LoginView","Login");
        }

    }
}