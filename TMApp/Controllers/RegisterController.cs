using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class RegisterController : Controller
    {


        
        public ActionResult RegisterView()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            try
            {
                TMAppContext db = new TMAppContext();
                Register reg = new Register();
                
                    reg.Name = model.Name;
                    reg.Email = model.Email;
                    reg.Gender = model.Gender;
                    reg.Country = model.Country;
                    reg.State = model.State;
                    reg.PhoneNo = model.PhoneNo;
                    db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.tblRegister ON");
                    reg.Username = model.Username;
                    reg.Password = model.Password;

                    db.RegistersTable.Add(reg);
                    db.SaveChanges();
                    db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.tblRegister OFF");
                    //int lastestId = reg.Id;

                model.SuccessMessage = "Successfully registered";
                
             
            }
            catch(Exception ex)
            {
                throw ex;
            }


            return RedirectToAction("RegisterView");


        }

    }
}