using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        public ActionResult ContactView()
        {
            TMAppContext db = new TMAppContext();
            db.ContactsTable.ToList();
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Message(Contact GetContact)
        {
            TMAppContext db = new TMAppContext();
            var Cont = new Contact();
            Cont.Name = GetContact.Name;
            Cont.Email = GetContact.Email;
            Cont.Subject = GetContact.Subject;
            Cont.Message = GetContact.Message;

           
            db.ContactsTable.Add(Cont);
           
            db.SaveChanges();

            TempData["msg"] = "<script> alert('Message Sent');</script>";
            return RedirectToAction("ContactView");
        }
       
    }
}