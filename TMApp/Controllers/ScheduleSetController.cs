using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class ScheduleSetController : Controller
    {


        public ActionResult ScheduleSetView()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScheduleSet(ScheduleSet Task)
        {
            TMAppContext db =  new TMAppContext();
            ScheduleSet newTask = new ScheduleSet();
            newTask.Description = Task.Description;
            newTask.Categories = Task.Categories;
            newTask.Date =Task.Date;
            newTask.Location = Task.Location;
            newTask.Email = Task.Email;
            newTask.Username = Task.Username;
            newTask.Password = Task.Password;

            var CheckUser = db.RegistersTable.Where(m => m.Username.Equals(Task.Username) && m.Password.Equals(Task.Password)).FirstOrDefault();
            if(CheckUser!=null)
            {
                db.ScheduleSetsTable.Add(newTask);
                db.SaveChanges();

                TempData["Msg"]="<script> alert('Task Successfully set');</script>";
                return RedirectToAction("ScheduleSetView");

            }
            else
            {
                TempData["Errormsg"]="<script> alert('Wrong Username or Password');</script>";
                return View("ScheduleSetView");
            }

       
        }

        
    }
}