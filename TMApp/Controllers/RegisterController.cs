﻿using System;
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
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.tblRegister ON");
                reg.Name = model.Name;
                reg.Email = model.Email;
                reg.Gender = model.Gender;
                reg.Country = model.Country;
                reg.State = model.State;
                reg.PhoneNo = model.PhoneNo;
               
                reg.Username = model.Username;
                reg.Password = model.Password;
                reg.DateRegistered = DateTime.Today;

                if (ModelState.IsValid)
                {
                    var CheckEmail = db.RegistersTable.Find(reg.Email);

                    if (CheckEmail == null)
                    {
                        db.RegistersTable.Add(reg);
                        db.SaveChanges();
                        //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.tblRegister OFF");
                        TempData["msg"] = "<script> alert('Succesfully Registered');</script>";

                        return RedirectToAction("RegisterView");
                    }
                    else if (CheckEmail != null)
                    {
                        TempData["Error"] = "<script> alert('Email already Exist'); </script>";
                    }
                    else
                    {
                        TempData["Error"] = "<script> alert('Invalid Entry'); </script>";
                    }


                }
          
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return View("RegisterView");
        }

       public ActionResult Clear()
        {

            return View();
        }

    }
}