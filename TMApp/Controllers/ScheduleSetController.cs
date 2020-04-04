using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult ScheduleSet()
        {
            return View();
        }

        
    }
}