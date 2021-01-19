using System;
using System.Collections.Generic;
using System.IO;
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
            if (ModelState.IsValid)
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
                    reg.LastLogin = DateTime.Now;
                    reg.LastUpdate = DateTime.Now;
                    if (model.Gender == "Female")
                    {
                        reg.ProfilePic = "~/images/profile Pictures/female avarta2.png";
                    }
                    else
                    {
                        reg.ProfilePic = "~/images/profile Pictures/male avarta.jpg";
                    }

                    if (ModelState.IsValid)
                    {
                        var CheckEmail = db.RegistersTable.Find(model.Email);
                        var CheckUsername = db.RegistersTable.Find(model.Username);

                        if (CheckEmail != null)
                        {
                            TempData["Error"] = "<script> alert('Email already Exist'); </script>";
                        }
                        else if (CheckUsername != null)
                        {
                            TempData["UsernameError"] = "<script> alert('Username already Exist'); </script>";
                        }
                        else
                        {
                            db.RegistersTable.Add(reg);
                            db.SaveChanges();
                            //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.tblRegister OFF");
                            TempData["msg"] = "<script> alert('Succesfully Registered!! Login to access more features');</script>";

                            return RedirectToAction("LoginView", "Login");
                            //TempData["Error"] = "<script> alert('Invalid Entry'); </script>";



                        }


                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            return View("RegisterView");
        }

       public ActionResult Clear()
        {

            return View();
        }

    }
}
