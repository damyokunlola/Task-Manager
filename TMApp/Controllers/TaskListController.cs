using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMApp.Controllers
{
    public class TaskListController : Controller
    {
        // GET: TaskList
        public ActionResult TaskList()
        {
            return View();
        }
    }
}