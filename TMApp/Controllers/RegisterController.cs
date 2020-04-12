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
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.tblRegister ON");
                reg.Name = model.Name;
                reg.Email = model.Email;
                reg.Gender = model.Gender;
                reg.Country = model.Country;
                reg.State = model.State;
                reg.PhoneNo = model.PhoneNo;
               
                reg.Username = model.Username;
                reg.Password = model.Password;

          if (reg.Password.Length < 5)
                {
                    TempData["StringPLen"] = "<script> alert('Password must be at least 5 characters');</script>";
                  
                }

                else if (reg.Username.Length < 8)
                {
                    TempData["StringULen"] = "<script> alert('Username must be at least 8 characters')</script>";
                }
                else
                {


                    var CheckEmail = db.RegistersTable.Find(reg.Email);
                    //var CheckUsername = db.RegistersTable.Find(reg.Username);
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
                        //TempData["ErrorUsername"] = "<script> alert('Username already exist');</script>";
                    }



                    //else if (CheckEmail !=null)
                    //{
                    //    TempData["ErrorEmail"] = "<script> alert('Email already exist');</script>";
                    //}
                    else
                    {
                        TempData["Error"] = "<script> alert('Invalid Entry'); </script>";
                    }
          }

                //}
                //else if (CheckEmail != null)
                // {
                //     TempData["ErrorEmail"] = "<script> alert('Email already exist');</script>";
                //     //return View("RegisterView");
                // }

                // else if (CheckUsername != null)
                // {
                //     TempData["ErrorUsername"] = "<script> alert('Username already exist');</script>";
                //     //return View("RegisterView");
                // }

                //else if (CheckUsername !=null && CheckEmail != null)
                //{
                //    TempData["Error"] = "<script> alert('Username and Email already exist');</script>";
                //    //return View("RegisterView");
                //}
                //else
                //{
                //    TempData["Error"] = "<script> alert('Username and Email already exist');</script>";
                //}



                return View("RegisterView");




            }
            catch (Exception ex)
            {
                throw ex;
            }


          
        }

    }
}