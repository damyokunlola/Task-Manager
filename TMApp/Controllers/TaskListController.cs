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
        // GET: TaskList
        public ActionResult TaskList(String Pointer)
        {
            using (TMAppContext db = new TMAppContext())
            {
                var UserTask = db.ScheduleSetsTable.Find(Session["Email"]);
              

                return View(db.ScheduleSetsTable.ToList());
            }
            
        }
    }
}