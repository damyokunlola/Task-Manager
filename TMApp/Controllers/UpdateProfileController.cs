using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class UpdateProfileController : Controller
    {
        // GET: UpdateProfile
        public ActionResult UpdateProfileView()
        {
            TMAppContext db = new TMAppContext();
            var Users = db.RegistersTable.Find(Session["Email"]);
         
            return View(Users);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateProfile(Register NewRecord)
        {
            TMAppContext db = new TMAppContext();

            
                try
                {


                    var UserEmail = Session["Email"];
                    var Edit = db.RegistersTable.Find(UserEmail);
                    Edit.Name = NewRecord.Name;
                    Edit.PhoneNo = NewRecord.PhoneNo;
                    Edit.State = NewRecord.State;
                    Edit.Country = NewRecord.Country;
                    Edit.Username = NewRecord.Username;
                // NewRecord.Name = UpdateIn.Name;
                // NewRecord.PhoneNo = UpdateIn.PhoneNo;
                // NewRecord.Country = UpdateIn.Country;
                // NewRecord.State = UpdateIn.State;
                // NewRecord.Username = UpdateIn.Username;
                // NewRecord.Gender = UpdateIn.Gender;
                // NewRecord.Password = UpdateIn.Password;
                //NewRecord.Email = UpdateIn.Email; 
                // NewRecord.Password = UpdateIn.Password;


                // db.Entry(UpdateIn).State = EntityState.Modified;
                //db.Configuration.ValidateOnSaveEnabled = false;
                
                    db.SaveChanges();


                    TempData["editmsg"] = "<script> alert('Succesfully Updated');</script>";
                    return RedirectToAction("MyProfile", "Profile");
                
               }

            catch(Exception ex)
            {
                throw ex;
               
            }
           
               
        }


    }
}