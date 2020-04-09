using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
   
    public class HomeController : Controller
    {

        

        // GET: Home
        public ActionResult Home()
        {
            TMAppContext db = new TMAppContext();
            db.RegistersTable.ToList();
            db.UserLoginsTable.ToList();
            db.ScheduleSetsTable.ToList();
        
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }
    }
}