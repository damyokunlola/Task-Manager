using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class TaskListController : Controller
    {
        [HttpGet]
        public ActionResult TaskList()
        { 
            
            using (TMAppContext db= new TMAppContext ())
            {
                string userEmail =Session["Email"].ToString();
               var Tasklist = db.ScheduleSetsTable.Where(m => m.Email==userEmail).ToList();
              
                 return View(Tasklist);
            }
       
        }
        
    }
}