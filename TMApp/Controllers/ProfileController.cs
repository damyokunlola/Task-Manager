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

        public ViewResult GetProfile( Register Userdetails)
        {

            TMAppContext db = new TMAppContext();
          

            return View(); 
  
        }
    }
}