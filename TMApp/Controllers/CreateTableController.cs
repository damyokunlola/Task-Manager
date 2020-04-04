using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class CreateTableController : Controller
    {
        TMAppContext db = new TMAppContext();
        // GET: CreateTable
        public ActionResult CreateTable()
        {
            db.RegistersTable.ToList();
            db.UserLoginsTable.ToList();
            db.ScheduleSetsTable.ToList();
            return View();
        }
    }
}