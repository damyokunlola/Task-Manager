using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TMApp.Models;
using System.IO;

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
                string fileName = Path.GetFileNameWithoutExtension(NewRecord.ImageFile.FileName);
                string extension = Path.GetExtension(NewRecord.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                NewRecord.ProfilePic = "~/images/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/images/"), fileName);
                NewRecord.ImageFile.SaveAs(fileName);

                var UserEmail = Session["Email"];
                var Edit = db.RegistersTable.Find(UserEmail);
                Edit.Name = NewRecord.Name;
                Edit.PhoneNo = NewRecord.PhoneNo;
                Edit.State = NewRecord.State;
                Edit.Country = NewRecord.Country;
                Edit.Username = NewRecord.Username;
                Edit.ProfilePic = NewRecord.ProfilePic;
              
                    





                db.SaveChanges();


                TempData["editmsg"] = "<script> alert('Succesfully Updated');</script>";
                return RedirectToAction("MyProfile", "Profile");

            }

            catch (Exception ex)
            {
                throw ex;

            }


        }


    }
}